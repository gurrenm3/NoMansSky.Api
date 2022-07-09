using libMBIN;
using Reloaded.ModHelper;
using System;
using System.Reflection;
using System.Threading.Tasks;

namespace NoMansSky.Api
{
    /// <summary>
    /// A multithreaded converter for all NMS Template objects.
    /// </summary>
    public class ThreadedNMSTemplateConverter : IMemoryConverter
    {
        public IGameLoop GameLoop => IGame.Instance?.GameLoop!;

        IMemoryManager memory;

        public ThreadedNMSTemplateConverter(IMemoryManager manager)
        {
            if (manager == null)
                throw new NullReferenceException($"Can't create {nameof(ThreadedNMSTemplateConverter)} because the provided" +
                    $" {nameof(MemoryManager)} was null!");

            this.memory = manager;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="address"></param>
        /// <param name="valueType"></param>
        /// <returns></returns>
        public object GetValue(long address, Type valueType)
        {
            var instance = Activator.CreateInstance(valueType);
            var fields = valueType.GetFields();

            Parallel.ForEach(fields, field =>
            {
                var fieldOffset = NMSTemplate.OffsetOf(valueType, field.Name);
                var value = GetFieldValue(valueType, field, address + fieldOffset);

                if (value == null)
                {
                    ConsoleUtil.LogWarning($"{nameof(ThreadedNMSTemplateConverter)}: The field \"{field.Name}\" is is null. Skipping...");
                }
                else
                {
                    field.SetValue(instance, value);
                }
            });

            return instance;
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
                ConsoleUtil.LogError($"{nameof(ThreadedNMSTemplateConverter)}: Failed to set value because valueToSet is null");
                return;
            }

            var valueType = valueToSet.GetType();
            var fields = valueType.GetFields();
            Parallel.ForEach(fields, field =>
            {
                var fieldOffset = NMSTemplate.OffsetOf(valueType, field.Name);
                var newFieldValue = field.GetValue(valueToSet);
                memory.SetValue(address + fieldOffset, newFieldValue);
            });
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="address"></param>
        /// <returns></returns>
        public T GetValue<T>(long address) => (T)GetValue(address, typeof(T));





        private object GetFieldValue(Type classType, FieldInfo field, long address)
        {
            if (!field.FieldType.IsArray)
                return memory.GetValue(address, field.FieldType);

            // Get converter for the array.
            var converter = (ArrayConverter)memory.GetObjectConverter(field.FieldType);
            if (converter == null)
            {
                ConsoleUtil.LogError($"{nameof(ThreadedNMSTemplateConverter)}: Failed to get converter for this Array.");
                return null!;
            }

            // Get size of the array.
            int? arrayLength = field.GetCustomAttribute<NMSAttribute>()?.Size;
            if (!arrayLength.HasValue)
            {
                ConsoleUtil.LogError($"{nameof(ThreadedNMSTemplateConverter)}: Failed to get size of array for {classType.Name}.{field.Name}");
                return null!;
            }

            return converter.GetValue(address, field.FieldType, arrayLength.Value);
        }




        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public bool CanConvert<T>() => CanConvert(typeof(T));

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="typeToCheck"></param>
        /// <returns></returns>
        public bool CanConvert(Type typeToCheck)
        {
            if (typeToCheck == null)
            {
                ConsoleUtil.LogError($"{nameof(ThreadedNMSTemplateConverter)} can't check if this type can be converted," +
                   $" because the type to check is NULL");
                return false;
            }

            return typeToCheck.IsAssignableTo(typeof(NMSTemplate));
        }
    }
}
