using libMBIN;
using libMBIN.NMS;
using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace NoMansSky.Api
{
    public unsafe class MemoryManager
    {
        public static MemoryManager Instance => _instance;
        private static MemoryManager _instance;
        private static List<IMBin> RegisteredMbins => Game.Instance?.MBinManager?.GetAllMBIN();
        private static IModLogger logger;

        public MemoryManager(IModLogger logger)
        {
            if (_instance != null)
                return;

            MemoryManager.logger = logger;
            _instance = this;
        }

        public bool IsMbinRegistered(string mbinName)
        {
            foreach (var mbin in RegisteredMbins)
            {
                string name = mbin.Name;
                if (name.StartsWith("Gc"))
                    name = name.Remove(0, 2);

                if (mbinName == name)
                    return true;
            }
            return false;
        }


        public string ReadString(long address) => Strings.ToString(address);
        public bool IsStringType<T>() => IsStringType(typeof(T));
        public bool IsStringType(Type typeToCheck) =>
            typeToCheck == typeof(string) || typeToCheck == typeof(char*) || typeToCheck.Name.Contains("NMSString");


        public T ReadEnum<T>(long address) => (T)ReadEnum(typeof(T), address);
        public object ReadEnum(Type enumType, long address)
        {
            int enumId = *(int*)(address);
            var values = Enum.GetValues(enumType);
            if (values == null)
                throw new Exception($"Failed to get values for the enum \"{enumType.Name}\"");
            var value = values.GetValue(enumId);
            if (value == null)
                throw new Exception($"Failed to read value for the enum \"{enumType.Name}\"." +
                    $" Enum does not have any values with an ID of {enumId}");
            return value;
        }


        public T ReadVector<T>(long address) => (T)ReadVector(typeof(T), address);
        public object ReadVector(Type vectorType, long address)
        {
            float x = *(float*)address;
            float y = *(float*)(address + 0x4);

            if (vectorType.Name == "Vector2f")
                return new Vector2f(x, y);

            float z = *(float*)(address + 0x8);
            if (vectorType.Name == "Vector3f")
                return new Vector3f(x, y, z);

            float t = *(float*)(address + 0x12);
            return new Vector4f(x, y, z, t);
        }


        public T ReadValuePrimitive<T>(long address) => (T)ReadPrimitiveValue(typeof(T), address);
        public object ReadPrimitiveValue(Type valueType, long address)
        {
            if (valueType == typeof(bool))
                return *(bool*)address;
            if (valueType == typeof(byte))
                return *(byte*)address;
            if (valueType == typeof(sbyte))
                return *(sbyte*)address;
            if (valueType == typeof(Int16))
                return *(Int16*)address;
            if (valueType == typeof(UInt16))
                return *(UInt16*)address;
            if (valueType == typeof(Int32))
                return *(Int32*)address;
            if (valueType == typeof(UInt32))
                return *(UInt32*)address;
            if (valueType == typeof(Int64))
                return *(Int64*)address;
            if (valueType == typeof(UInt64))
                return *(UInt64*)address;
            if (valueType == typeof(IntPtr))
                return *(IntPtr*)address;
            if (valueType == typeof(UIntPtr))
                return *(UIntPtr*)address;
            if (valueType == typeof(char))
                return *(char*)address;
            if (valueType == typeof(decimal))
                return *(decimal*)address;
            if (valueType == typeof(double))
                return *(double*)address;
            if (valueType == typeof(Single))
                return *(Single*)address;

            throw new Exception("Tried converting a primitive type that is not supported");
        }


        public T ReadNMSTemplate<T>(long address)
        {
            var value = ReadNMSTemplate(typeof(T), address);
            return value == null ? default(T) : (T)value;
        }
        public object ReadNMSTemplate(Type templateType, long address)
        {
            var instance = Activator.CreateInstance(templateType);

            foreach (var field in templateType.GetFields())
            {
                if (field.FieldType.IsArray)
                    continue;

                object fieldValue = null;
                if (!field.FieldType.IsArray)
                {
                    var fieldOffset = NMSTemplate.OffsetOf(templateType, field.Name);
                    fieldValue = ReadObject(field.FieldType, address + fieldOffset);
                }
                /*else
                {
                    
                    int? arrayLength = field.GetCustomAttribute<NMSAttribute>()?.Size;
                    if (!arrayLength.HasValue)
                        throw new Exception($"Failed to get size of array for {templateType.Name}.{field.Name}");

                    var arrayType = field.FieldType.GetElementType();
                    var fieldOffset = NMSTemplate.SizeOf(arrayType);
                    fieldValue = ReadArray(field.FieldType, address + fieldOffset, arrayLength.Value);
                }*/

                string msg = "";
                if (field.FieldType.Name.Contains("NMSString"))
                {
                    var nmsString = NMSString.CreateFrom(field.FieldType, fieldValue.ToString());
                    fieldValue = nmsString;
                    msg = string.Format("name= {0, -48} value= {1,-10}", field.Name, nmsString.StringValue() ?? "null");
                }
                else
                    msg = string.Format("name= {0, -48} value= {1,-10}", field.Name, fieldValue ?? "null");

                logger.WriteLine(msg);

                if (fieldValue != null)
                    field.SetValue(instance, fieldValue);
            }

            return instance;
        }


        public static T ReadObject<T>(long address)
        {
            var value = ReadObject(typeof(T), address);
            return value == null ? default(T) : (T)value;
        }
        public static object ReadObject(Type objectType, long address)
        {
            if (objectType.IsPrimitive || objectType == typeof(decimal))
                return Instance.ReadPrimitiveValue(objectType, address);
            if (objectType.IsEnum)
                return Instance.ReadEnum(objectType, address);

            if (Instance.IsStringType(objectType))
                return Instance.ReadString(address);

            if (objectType.IsVectorType())
                return Instance.ReadVector(objectType, address);

            if (objectType.IsAssignableTo(typeof(NMSTemplate))) // it inherits or is NMSTemplate
                return Instance.ReadNMSTemplate(objectType, address);


            return null;
        }


        public static T[] ReadArray<T>(long address, int arrayLength)
        {
            var array = ReadArray(typeof(T), address, arrayLength);
            T[] values = new T[arrayLength];
            for (int i = 0; i < values.Length; i++)
                values[i] = (T)array[i];
            return values;
        }

        public static object[] ReadArray(Type objectType, long address, int arrayLength)
        {
            var array = new object[arrayLength];
            var arrayType = objectType.GetElementType();
            int objectSize = NMSTemplate.SizeOf(arrayType);

            for (int i = 0; i < arrayLength; i++)
            {

            }

            return null;
        }
    }
}
