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
        IMemoryManager manager;

        /// <summary>
        /// Creates an instance of this class while providing a manager for recursion.
        /// </summary>
        /// <param name="manager"></param>
        public NMSTemplateConverter(IMemoryManager manager)
        {
            if (manager == null)
                throw new NullReferenceException($"Can't create {nameof(NMSTemplateConverter)} because the provided" +
                    $" {nameof(MemoryManager)} was null!");

            this.manager = manager;
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
                ConsoleUtil.LogError($"{nameof(NMSTemplateConverter)} can't check if this type can be converted," +
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

            var fields = valueType.GetFields();

            foreach (var field in valueType.GetFields())
            {
                var fieldOffset = NMSTemplate.OffsetOf(valueType, field.Name);
                var value = GetFieldValue(valueType, field, address + fieldOffset);

                if (value == null)
                {
                    ConsoleUtil.LogWarning($"{nameof(NMSTemplateConverter)}: The field \"{field.Name}\" is is null. Skipping...");
                    continue;
                }

                field.SetValue(instance, value);
            }

            return instance!;
        }

        private object GetFieldValue(Type classType, FieldInfo field, long address)
        {
            if (!field.FieldType.IsArray)
                return manager.GetValue(address, field.FieldType);

            // Get converter for the array.
            var converter = (ArrayConverter)manager.GetObjectConverter(field.FieldType);
            if (converter == null)
            {
                ConsoleUtil.LogError($"{nameof(NMSTemplateConverter)}: Failed to get converter for this Array.");
                return null!;
            }

            // Get size of the array.
            int? arrayLength = field.GetCustomAttribute<NMSAttribute>()?.Size;
            if (!arrayLength.HasValue)
            {
                ConsoleUtil.LogError($"{nameof(NMSTemplateConverter)}: Failed to get size of array for {classType.Name}.{field.Name}");
                return null!;
            }

            return converter.GetValue(address, field.FieldType, arrayLength.Value);
        }

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
                ConsoleUtil.LogError($"{nameof(NMSTemplateConverter)}: Failed to set value because valueToSet is null");
                return;
            }

            var valueType = valueToSet.GetType();
            foreach (var field in valueType.GetFields())
            {
                var fieldOffset = NMSTemplate.OffsetOf(valueType, field.Name);
                var newFieldValue = field.GetValue(valueToSet);

                /*if (fieldValue == null)
                {
                    ConsoleUtil.LogWarning($"{nameof(NMSTemplateConverter)}: Can't set field value because it's is null. Skipping...");
                    continue;
                }*/

                manager.SetValue(address + fieldOffset, newFieldValue);
            }
        }
    }
}
