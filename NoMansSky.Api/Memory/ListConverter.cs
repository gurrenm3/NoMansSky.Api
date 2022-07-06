using libMBIN;
using Reloaded.ModHelper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace NoMansSky.Api
{
    /// <summary>
    /// Converts lists from memory into actual C# Lists.
    /// </summary>
    public unsafe class ListConverter : IMemoryConverter
    {
        IMemoryManager manager;

        /// <summary>
        /// Creates an object of this converter, along with a memory manager for recursion.
        /// </summary>
        /// <param name="manager"></param>
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
            {
                ConsoleUtil.LogError($"{nameof(ListConverter)} can't check if this type can be converted," +
                    $" because the type to check is NULL");
                return false;
            }

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
        /// <param name="valueType"></param>
        /// <param name="address"></param>
        /// <returns></returns>
        public object GetValue(long address, Type valueType)
        {
            /*if (address <= 0)
            {
                ConsoleUtil.LogError($"{nameof(ListConverter)}: Can't get List because address was {address} and is not valid");
                return null!;
            }
            if (valueType == null)
            {
                ConsoleUtil.LogError($"{nameof(ListConverter)}: Can't get List because provided type is null");
                return null!;
            }*/

            // get the type of item this list holds.
            var elementType = valueType?.GetGenericArguments()?.FirstOrDefault();
            if (elementType == null)
            {
                ConsoleUtil.LogError($"{nameof(ListConverter)}: Failed to get ElementType for List");
                return null!;
            }

            var listType = typeof(List<>).MakeGenericType(elementType);
            var list = (IList)Activator.CreateInstance(listType)!;
            int listSize = manager.GetValue<int>(address + 0x8);
            if (listSize == 0)
                return list;

            int objectSize = NMSTemplate.SizeOf(elementType);
            long currentAddress = *(long*)address;


            /*Parallel.For(0, listSize, i =>
            {
                var listItem = manager.GetValue(currentAddress, elementType);
                lock (list)
                {
                    list.Add(listItem);
                }
                currentAddress += objectSize;
            });*/
            for (int i = 0; i < listSize; i++)
            {
                var listItem = manager.GetValue(currentAddress, elementType);
                list.Add(listItem);
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
            // get the type of item this list holds.
            var listType = valueToSet.GetType();
            var elementType = listType?.GetGenericArguments()?.FirstOrDefault();
            if (elementType == null)
            {
                ConsoleUtil.LogError($"{nameof(ListConverter)}: Failed to get ElementType for List");
                return;
            }

            var list = (IList)valueToSet;
            int previousSize = manager.GetValue<int>(address + 0x8);
            if (list.Count != previousSize)
            {
                ConsoleUtil.LogError("The API currently does not support changing the size of lists in memory." +
                    " Make sure you are trying to set a list of the same size.");
                return;
            }


            // previous code for setting lists of the same size.
            int objectSize = NMSTemplate.SizeOf(elementType);
            long currentAddress = *(long*)address;
            for (int i = 0; i < list.Count; i++)
            {
                var currentValue = list[i];
                if (currentValue != null)
                    manager.SetValue(currentAddress, currentValue);
                currentAddress += objectSize;
            }


            manager.SetValue(address + 0x8, list.Count);
        }
    }
}
