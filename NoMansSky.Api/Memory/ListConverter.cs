using libMBIN;
using Reloaded.ModHelper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoMansSky.Api
{
    public unsafe class ListConverter : IMemoryConverter
    {
        IMemoryManager manager;

        public ListConverter(IMemoryManager manager)
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
            return typeToCheck.IsGenericType && typeToCheck.GetGenericTypeDefinition() == typeof(List<>);
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
        /// <param name="listType"></param>
        /// <param name="address"></param>
        /// <returns></returns>
        public object GetValue(Type valueType, long address)
        {
            var elementType = valueType.GetGenericArguments().FirstOrDefault();
            if (elementType == null)
                return null;

            var listType = typeof(List<>).MakeGenericType(elementType);
            var list = (IList)Activator.CreateInstance(listType);            
            
            int objectSize = NMSTemplate.SizeOf(elementType);
            long currentAddress = *(long*)address;
            int listSize = manager.GetValue<int>(address + 0x8);
            for (int i = 0; i < listSize; i++)
            {
                var listITem = manager.GetValue(elementType, currentAddress);
                list.Add(listITem);
                currentAddress += objectSize;
            }

            return list;
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
            var listType = valueToSet.GetType();
            var elementType = listType.GetGenericArguments().FirstOrDefault();
            if (elementType == null)
                return;

            var list = (IList)valueToSet;            
            int objectSize = NMSTemplate.SizeOf(elementType);

            int previousSize = manager.GetValue<int>(address + 0x8);
            long currentAddress = *(long*)address;
            for (int i = 0; i < list.Count; i++)
            {
                manager.SetValue(currentAddress, list[i]);
                currentAddress += objectSize;
            }

            manager.SetValue(address + 0x8, list.Count);
        }
    }
}
