using libMBIN;
using Reloaded.ModHelper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace NoMansSky.Api
{
    public unsafe class ListConverter : IMemoryConverter
    {
        IMemoryManager manager;

        public ListConverter(IMemoryManager manager)
        {
            if (manager == null)
                throw new NullReferenceException($"Can't create {nameof(ListConverter)} because the provided" +
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
                throw new Exception($"{nameof(ListConverter)} can't check if this type can be converted," +
                    $" because the type to check is NULL");

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
            var elementType = valueType?.GetGenericArguments()?.FirstOrDefault();
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
            var elementType = listType?.GetGenericArguments()?.FirstOrDefault();
            if (elementType == null)
                return;

            var list = (IList)valueToSet;
            int previousSize = manager.GetValue<int>(address + 0x8);
            if (list.Count != previousSize)
            {
                throw new NotImplementedException("The API currently does not support changing the size of lists in memory." +
                    " Make sure you are trying to set a list of the same size.");
            }

            int objectSize = NMSTemplate.SizeOf(elementType);
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
