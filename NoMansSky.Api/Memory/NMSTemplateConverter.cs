using libMBIN;
using Reloaded.ModHelper;
using System;
using System.Reflection;
using System.Threading.Tasks;

namespace NoMansSky.Api
{
    /// <summary>
    /// A converter for all NMS Template objects.
    /// </summary>
    public class NMSTemplateConverter : IMemoryConverter
    {
        IMemoryManager memory;

        /// <summary>
        /// Creates an instance of this class while providing a manager for recursion.
        /// </summary>
        /// <param name="manager"></param>
        public NMSTemplateConverter(IMemoryManager manager)
        {
            if (manager == null)
                throw new NullReferenceException($"Can't create {nameof(NMSTemplateConverter)} because the provided" +
                    $" {nameof(MemoryManager)} was null!");

            this.memory = manager;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="typeToCheck"></param>
        /// <returns></returns>
        public bool CanConvert(Type typeToCheck)
        {
            if (typeToCheck == null)
            {
                ConsoleUtils.LogError($"{nameof(NMSTemplateConverter)} can't check if this type can be converted," +
                   $" because the type to check is NULL");
                return false;
            }

            return typeToCheck.IsAssignableTo(typeof(NMSTemplate));
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public bool CanConvert<T>()
        {
            return CanConvert(typeof(T));
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="valueType"></param>
        /// <param name="address"></param>
        /// <returns></returns>
        public object GetValue(long address, Type valueType)
        {
            var instance = Activator.CreateInstance(valueType);


            foreach (var field in valueType.GetFields())
            {
                var fieldOffset = NMSTemplate.OffsetOf(valueType, field.Name);
                var value = GetFieldValue(valueType, field, address + fieldOffset);

                if (value == null)
                {
                    ConsoleUtils.LogWarning($"{nameof(NMSTemplateConverter)}: The field \"{field.Name}\" is is null. Skipping...");
                    continue;
                }

                field.SetValue(instance, value);
            }

            return instance!;
        }

        private unsafe object GetFieldValue(Type classType, FieldInfo field, long address)
        {
            if (!field.FieldType.IsArray)
            {
                if (field.FieldType != typeof(NMSTemplate))
                    return memory.GetValue(address, field.FieldType);

                // it's using NMSTemplate as a base class and using inheritance for this field. Actual field type could be anything.

                // get actual field type:
                long addressOfFieldType = (address + 0x8);
                string nameOfFieldType = StringUtils.ToString(addressOfFieldType);

                if (string.IsNullOrEmpty(nameOfFieldType) || string.IsNullOrWhiteSpace(nameOfFieldType)) // it's empty, treat it as a NMSTemplate
                    return memory.GetValue(address, field.FieldType);

                // try to get the corrisponding libmbin class
                var actualFieldType = IGame.Instance.MBinManager.GetMBinTypeFromName(nameOfFieldType);
                if (actualFieldType == null) // not found. Probably an internal class.
                {
                    ConsoleUtils.LogError($"Failed to get libmbin type for {nameOfFieldType}");
                    return memory.GetValue(address, field.FieldType);
                }

                // we have the actual type and actual address of this field. Return correct value.
                long actualFieldAddress = *(long*)address; // dereference since it's stored as a pointer.
                return memory.GetValue(actualFieldAddress, actualFieldType);
            }


            // Get converter for the array.
            var converter = (ArrayConverter)memory.GetObjectConverter(field.FieldType);
            if (converter == null)
            {
                ConsoleUtils.LogError($"{nameof(ThreadedNMSTemplateConverter)}: Failed to get converter for this Array.");
                return null!;
            }

            // Get size of the array.
            int? arrayLength = field.GetCustomAttribute<NMSAttribute>()?.Size;
            if (!arrayLength.HasValue)
            {
                ConsoleUtils.LogError($"{nameof(ThreadedNMSTemplateConverter)}: Failed to get size of array for {classType.Name}.{field.Name}");
                return null!;
            }

            return converter.GetValue(address, field.FieldType, arrayLength.Value);
        }


        // old
        /*private object GetFieldValue(Type classType, FieldInfo field, long address)
        {
            if (!field.FieldType.IsArray)
                return manager.GetValue(address, field.FieldType);

            // Get converter for the array.
            var converter = (ArrayConverter)manager.GetObjectConverter(field.FieldType);
            if (converter == null)
            {
                ConsoleUtils.LogError($"{nameof(NMSTemplateConverter)}: Failed to get converter for this Array.");
                return null!;
            }

            // Get size of the array.
            int? arrayLength = field.GetCustomAttribute<NMSAttribute>()?.Size;
            if (!arrayLength.HasValue)
            {
                ConsoleUtils.LogError($"{nameof(NMSTemplateConverter)}: Failed to get size of array for {classType.Name}.{field.Name}");
                return null!;
            }

            return converter.GetValue(address, field.FieldType, arrayLength.Value);
        }*/

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="address"></param>
        /// <returns></returns>
        public T GetValue<T>(long address)
        {
            var value = GetValue(address, typeof(T));
            return value == null ? default(T)! : (T)value;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="address"></param>
        /// <param name="valueToSet"></param>
        public void SetValue(long address, object valueToSet)
        {
            if (valueToSet == null)
            {
                ConsoleUtils.LogError($"{nameof(NMSTemplateConverter)}: Failed to set value because valueToSet is null");
                return;
            }

            var valueType = valueToSet.GetType();
            foreach (var field in valueType.GetFields())
            {
                var fieldOffset = NMSTemplate.OffsetOf(valueType, field.Name);
                var newFieldValue = field.GetValue(valueToSet);

                /*if (fieldValue == null)
                {
                    ConsoleUtils.LogWarning($"{nameof(NMSTemplateConverter)}: Can't set field value because it's is null. Skipping...");
                    continue;
                }*/

                memory.SetValue(address + fieldOffset, newFieldValue);
            }
        }
    }
}
