using libMBIN;
using Reloaded.ModHelper;
using System.Collections.Concurrent;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace NoMansSky.Api;

public abstract class MbinClass : PropertyChangedNotifier
{
    protected static MemoryManager memoryMgr;
    protected static IMemoryConverter nmsStringConverter;
    protected static IMemoryConverter classConverter;
    protected static IMemoryConverter listConverter;
    protected static ArrayConverter arrayConverter;

    public readonly long address;

    protected Dictionary<string, int> propertyOffsets;

    public MbinClass(long address) : base()
    {
        this.address = address;

        if (memoryMgr == null)
        {
            memoryMgr = new MemoryManager();
            memoryMgr.AddConverter(new NMSStringConverter(memoryMgr), alwaysRegister: true);

            arrayConverter = new ArrayConverter(memoryMgr);
            memoryMgr.AddConverter(arrayConverter, alwaysRegister: true);
            memoryMgr.AddConverter(new ListConverter(memoryMgr), alwaysRegister: true);
            memoryMgr.AddConverter(new ThreadedNMSTemplateConverter(memoryMgr), alwaysRegister: true);
        }

        propertyOffsets = GetPropertyOffsets();
    }

    protected unsafe void TrySetValue<T>(object newValue, [CallerMemberName] string propertyName = "")
    {
        var currentValue = GetValue<T>(propertyName);
        if (currentValue.Equals((T)newValue))
            return;

        else if (StringUtils.IsString<T>())
            ChangePropertyValue(newValue, valueAfterHook => StringUtils.SetValue(address + GetOffset(propertyName), valueAfterHook), propertyName);

        else if (EnumUtils.IsEnum<T>())
            ChangePropertyValue(newValue, valueAfterHook => EnumUtils.SetValue(address + GetOffset(), valueAfterHook), propertyName);

        else if (PrimitiveUtils.IsPrimitive<T>())
            ChangePropertyValue(newValue, valueAfterHook => *(T*)(address + GetOffset(propertyName)) = (T)valueAfterHook, propertyName);

        else // assume it's a class
        {
            ChangePropertyValue(newValue, valueAfterHook =>
            {
                IMemoryConverter converter = null;
                if (typeof(T).Name.Contains("List`1"))
                    converter = listConverter;
                else if (typeof(T).IsArray)
                    converter = arrayConverter;
                else
                    converter = classConverter;

                converter.SetValue(address + GetOffset(propertyName), valueAfterHook);
                cache.AddOrUpdateValue(valueAfterHook, propertyName);
            }, propertyName);

            
        }
    }

    protected unsafe T GetValue<T>([CallerMemberName] string propertyName = "", int arrayElementOffset = 0)
    {
        if (PrimitiveUtils.IsPrimitive<T>())
            return *(T*)(address + GetOffset(propertyName));

        if (EnumUtils.IsEnum<T>())
            return EnumUtils.GetValue<T>(address + GetOffset(propertyName));

        if (StringUtils.IsString<T>())
            return (T)Convert.ChangeType(StringUtils.GetValue(address + GetOffset(propertyName)), typeof(T));

        return cache.GetOrAddValue((T)Activator.CreateInstance(typeof(T), address + GetOffset(propertyName)));
    }

    protected int GetOffset([CallerMemberName] string propertyName = "")
    {
        propertyOffsets.TryGetValue(propertyName, out var offset);
        return offset;
    }

    private Dictionary<string, int> GetPropertyOffsets()
    {
        var type = this.GetType();
        var offsets = new Dictionary<string, int>();

        foreach (var property in type.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static))
        {
            int? offset = null;
            var attributes = property.GetCustomAttributes<FindOffsetAttribute>();
            if (attributes != null && attributes.Any())
            {
                offset = 0;
                foreach (var attribute in attributes)
                    offset += attribute.DiscoveredOffset;
            }
            else
            {
                try { offset = OffsetOf(type, property.Name); }
                catch (Exception ex)
                {
                    ConsoleUtils.LogError(ex.Message);
                }
            }

            //ConsoleUtils.Log($"{property.Name} has an offset of {offset}");
            if (!offset.HasValue)
            {
                ConsoleUtils.LogError($"Failed to get offset for {property.Name}");
                continue;
            }
            offsets.Add(property.Name, offset.Value);
        }

        return offsets;
    }

    private static ConcurrentDictionary<Type, int> AlignmentMap = new ConcurrentDictionary<Type, int>();

    public static int OffsetOf(Type type, string fieldName)
    {
        IOrderedEnumerable<PropertyInfo> orderedEnumerable = from property in type.GetProperties()
                                                          orderby property.MetadataToken
                                                          select property;
        int num = 0;
        foreach (var item in orderedEnumerable)
        {
            int num2 = AlignOf(item.PropertyType);
            if (num % num2 != 0)
            {
                num += num2 - num % num2;
            }

            if (fieldName == item.Name)
            {
                return num;
            }

            num += SizeOf(item);
        }

        throw new ArgumentException(type.Name + " has no field called " + fieldName, fieldName);
    }

    public static int SizeOf(PropertyInfo property)
    {
        if (property.PropertyType.IsArray)
        {
            int num = SizeOf(property.PropertyType.GetElementType());
            return num * (property.GetCustomAttribute<NMSAttribute>()?.Size ?? 0);
        }

        if (property.PropertyType.Name == "String")
        {
            return property.GetCustomAttribute<NMSAttribute>()?.Size ?? 0;
        }

        return SizeOf(property.PropertyType);
    }

    public static int SizeOf(Type type)
    {
        int num = 0;
        switch (type.Name)
        {
            case "Boolean":
            case "Byte":
            case "String":
                num = 1;
                break;
            case "Int16":
            case "UInt16":
                num = 2;
                break;
            case "Single":
            case "Int32":
            case "UInt32":
                num = 4;
                break;
            case "Int64":
            case "UInt64":
                num = 8;
                break;
            case "VariableSizeString":
            case "List`1":
                num = 16;
                break;
            case "NMSTemplate":
                num = 80;
                break;
            default:
                {
                    if (type.IsEnum)
                    {
                        num = SizeOf(Enum.GetUnderlyingType(type));
                        break;
                    }

                    NMSAttribute customAttribute = type.GetCustomAttribute<NMSAttribute>();
                    if (customAttribute != null && customAttribute.Size > 0)
                    {
                        num = customAttribute.Size;
                        break;
                    }

                    int num2 = 1;
                    int num3 = 1;
                    var properties = type.GetProperties();
                    foreach (var propInfo in properties)
                    {
                        num3 = AlignOf(propInfo.PropertyType);
                        if (num % num3 != 0)
                        {
                            num += num3 - num % num3;
                        }

                        num += SizeOf(propInfo);
                        if (num3 > num2)
                        {
                            num2 = num3;
                        }
                    }

                    if (num % num2 != 0)
                    {
                        num += num2 - num % num2;
                    }

                    if (num == 0)
                    {
                        num = 1;
                    }

                    break;
                }
        }

        if (num != 0)
        {
            return num;
        }

        throw new ArgumentException(type.Name + " has an unknown size.");
    }

    public static int AlignOf(Type type)
    {
        if (AlignmentMap.TryGetValue(type, out var value))
        {
            return value;
        }

        switch (type.Name)
        {
            case "Boolean":
            case "Byte":
            case "String":
                value = 1;
                break;
            case "Int16":
            case "UInt16":
                value = 2;
                break;
            case "Single":
            case "Int32":
            case "UInt32":
                value = 4;
                break;
            case "Int64":
            case "UInt64":
            case "List`1":
            case "NMSTemplate":
            case "VariableSizeString":
                value = 8;
                break;
            default:
                {
                    if (type.IsArray)
                    {
                        value = AlignOf(type.GetElementType());
                        break;
                    }

                    if (type.IsEnum)
                    {
                        value = 4;
                        break;
                    }

                    NMSAttribute customAttribute = type.GetCustomAttribute<NMSAttribute>();
                    if (customAttribute != null && customAttribute.Alignment > 0)
                    {
                        value = customAttribute.Alignment;
                        break;
                    }

                    if (type.BaseType == typeof(NMSTemplate))
                    {
                        value = 1;
                        FieldInfo[] fields = type.GetFields();
                        for (int i = 0; i < fields.Length; i++)
                        {
                            int num = AlignOf(fields[i].FieldType);
                            if (num > value)
                            {
                                value = num;
                                if (value >= 16)
                                {
                                    break;
                                }
                            }
                        }

                        break;
                    }

                    throw new UnknownTypeException(type);
                }
        }

        AlignmentMap[type] = value;
        return value;
    }
}
