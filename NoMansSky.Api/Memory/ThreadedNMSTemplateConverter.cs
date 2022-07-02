using libMBIN;
using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NoMansSky.Api
{
    class ThreadedNMSTemplateConverter : IMemoryConverter
    {
        class FieldData
        {
            public long address;
            public FieldInfo fieldInfo;
            public Type owner;
        }

        class Worker
        {
            public Task task;
            public bool isWorking;
        }

        IMemoryManager manager;

        public ThreadedNMSTemplateConverter(IMemoryManager manager)
        {
            if (manager == null)
                throw new NullReferenceException($"Can't create {nameof(NMSTemplateConverter)} because the provided" +
                    $" {nameof(MemoryManager)} was null!");

            this.manager = manager;
        }

        public bool CanConvert<T>() => CanConvert(typeof(T));
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

        
        Queue<FieldData> remainingFields = new Queue<FieldData>();
        bool isRunning = false;
        object instance;
        public object GetValue(long address, Type valueType)
        {
            isRunning = true;
            instance = Activator.CreateInstance(valueType);


            foreach (var field in valueType.GetFields())
            {
                var fieldOffset = NMSTemplate.OffsetOf(valueType, field.Name);
                var fieldData = new FieldData()
                {
                    owner = valueType,
                    fieldInfo = field,
                    address = address + fieldOffset
                };

                remainingFields.Enqueue(fieldData);
            }


            var workers = CreateWorkers(5);

            while (workers.Any(w => w.isWorking))
            {
                Thread.Sleep(10);
                continue;
            }

            isRunning = false;
            return instance;
        }

        private Worker[] CreateWorkers(int count)
        {
            // create worker threads
            Worker[] workers = new Worker[count];
            for (int i = 0; i < workers.Length; i++)
            {
                var w = new Worker();
                workers[i] = w;
                workers[i].task = Task.Run(() =>
                {
                    while (isRunning)
                    {
                        var field = GetNextField();
                        if (field == null)
                            continue;

                        w.isWorking = true;
                        var value = GetFieldValue(field.owner, field.fieldInfo, field.address);
                        //Console.WriteLine(value.ToString());
                        w.isWorking = false;
                    }
                });
            }
            return workers;
        }

        private FieldData GetNextField()
        {
            lock (this)
            {
                return remainingFields.Any() ? remainingFields.Dequeue() : null;
            }
        }

        

        public void SetValue(long address, object valueToSet)
        {
            //throw new NotImplementedException();
        }

        public T GetValue<T>(long address) => (T)GetValue(address, typeof(T));





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
    }
}
