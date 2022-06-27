using libMBIN;
using Reloaded.ModHelper;
using System;
using System.Reflection;

namespace NoMansSky.Api
{
    /// <summary>
    /// A converter for all NMS Template objects.
    /// </summary>
    public class NMSTemplateConverter : IMemoryConverter
    {
        IMemoryManager manager;

        public NMSTemplateConverter(IMemoryManager manager)
        {
            this.manager = manager;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="typeToCheck"></param>
        /// <returns></returns>
        public bool CanConvert(Type typeToCheck)
        {
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
        public object GetValue(Type valueType, long address)
        {
            var instance = Activator.CreateInstance(valueType);

            foreach (var field in valueType.GetFields())
            {
                var fieldOffset = NMSTemplate.OffsetOf(valueType, field.Name);
                var value = GetFieldValue(valueType, field, address + fieldOffset);
                field.SetValue(instance, value);
            }

            return instance;
        }

        private object GetFieldValue(Type classType, FieldInfo field, long address)
        {
            if (!field.FieldType.IsArray)
                return manager.GetValue(field.FieldType, address);

            int? arrayLength = field.GetCustomAttribute<NMSAttribute>()?.Size;
            if (!arrayLength.HasValue)
                throw new Exception($"Failed to get size of array for {classType.Name}.{field.Name}");

            var converter = (ArrayConverter)manager.GetConverter(field.FieldType);
            var array = converter.GetValue(field.FieldType, address, arrayLength.Value);
            return array;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="address"></param>
        /// <returns></returns>
        public T GetValue<T>(long address)
        {
            var value = GetValue(typeof(T), address);
            return value == null ? default(T) : (T)value;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="address"></param>
        /// <param name="valueToSet"></param>
        public void SetValue(long address, object valueToSet)
        {
            var valueType = valueToSet.GetType();
            foreach (var field in valueType.GetFields())
            {
                var fieldOffset = NMSTemplate.OffsetOf(valueType, field.Name);
                var fieldValue = field.GetValue(valueToSet);
                if (fieldValue != null)
                    manager.SetValue(address + fieldOffset, fieldValue);
            }
        }
    }
}
