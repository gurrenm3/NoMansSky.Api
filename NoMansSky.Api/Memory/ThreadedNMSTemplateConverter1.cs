using libMBIN;
using Reloaded.ModHelper;
using System;
using System.Reflection;
using System.Threading.Tasks;

namespace NoMansSky.Api
{
    class ThreadedNMSTemplateConverter1 : IMemoryConverter
    {
        public IGameLoop GameLoop => IGame.Instance?.GameLoop!;

        IMemoryManager memory;

        public ThreadedNMSTemplateConverter1(IMemoryManager manager)
        {
            if (manager == null)
                throw new NullReferenceException($"Can't create {nameof(ThreadedNMSTemplateConverter1)} because the provided" +
                    $" {nameof(MemoryManager)} was null!");

            this.memory = manager;
        }


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
                    ConsoleUtil.LogWarning($"{nameof(ThreadedNMSTemplateConverter1)}: The field \"{field.Name}\" is is null. Skipping...");
                }
                else
                {
                    field.SetValue(instance, value);
                }
            });

            return instance;
        }


        public void SetValue(long address, object valueToSet)
        {
            if (valueToSet == null)
            {
                ConsoleUtil.LogError($"{nameof(ThreadedNMSTemplateConverter1)}: Failed to set value because valueToSet is null");
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

        public T GetValue<T>(long address) => (T)GetValue(address, typeof(T));





        private object GetFieldValue(Type classType, FieldInfo field, long address)
        {
            if (!field.FieldType.IsArray)
                return memory.GetValue(address, field.FieldType);

            // Get converter for the array.
            var converter = (ArrayConverter)memory.GetObjectConverter(field.FieldType);
            if (converter == null)
            {
                ConsoleUtil.LogError($"{nameof(ThreadedNMSTemplateConverter1)}: Failed to get converter for this Array.");
                return null!;
            }

            // Get size of the array.
            int? arrayLength = field.GetCustomAttribute<NMSAttribute>()?.Size;
            if (!arrayLength.HasValue)
            {
                ConsoleUtil.LogError($"{nameof(ThreadedNMSTemplateConverter1)}: Failed to get size of array for {classType.Name}.{field.Name}");
                return null!;
            }

            return converter.GetValue(address, field.FieldType, arrayLength.Value);
        }





        public bool CanConvert<T>() => CanConvert(typeof(T));
        public bool CanConvert(Type typeToCheck)
        {
            if (typeToCheck == null)
            {
                ConsoleUtil.LogError($"{nameof(ThreadedNMSTemplateConverter1)} can't check if this type can be converted," +
                   $" because the type to check is NULL");
                return false;
            }

            return typeToCheck.IsAssignableTo(typeof(NMSTemplate));
        }
    }
}
