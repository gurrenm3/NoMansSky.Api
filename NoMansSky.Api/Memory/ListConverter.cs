using libMBIN;
using Reloaded.ModHelper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace NoMansSky.Api
{
    /// <summary>
    /// Converts lists from memory into actual C# Lists.
    /// </summary>
    public unsafe class ListConverter : IMemoryConverter
    {
        IMemoryManager memory;

        /// <summary>
        /// Creates an object of this converter, along with a memory manager for recursion.
        /// </summary>
        /// <param name="manager"></param>
        public ListConverter(IMemoryManager manager)
        {
            if (manager == null)
                throw new NullReferenceException($"Can't create {nameof(ListConverter)} because the provided" +
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
                ConsoleUtil.LogError($"{nameof(ListConverter)} can't check if this type can be converted," +
                    $" because the type to check is NULL");
                return false;
            }

            //return typeToCheck.IsGenericType && typeToCheck.GetGenericTypeDefinition() == typeof(List<>);
            return typeToCheck.IsGenericType && typeToCheck.GetGenericTypeDefinition().IsAssignableTo(typeof(IList));
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
            if (address <= 0)
            {
                ConsoleUtil.LogError($"{nameof(ListConverter)}: Can't get List because address was {address} and is not valid");
                return null!;
            }

            // get the type of item this list holds.
            var elementType = valueType?.GetGenericArguments()?.FirstOrDefault();
            if (elementType == null)
            {
                ConsoleUtil.LogError($"{nameof(ListConverter)}: Failed to get ElementType for List");
                return null!;
            }

            var listType = typeof(List<>).MakeGenericType(elementType);
            var list = (IList)Activator.CreateInstance(listType)!;
            int listSize = memory.GetValue<int>(address + 0x8);

            if (listSize == 0)
                return list;


            int objectSize = NMSTemplate.SizeOf(elementType);
            long currentAddress = *(long*)address;

            for (int i = 0; i < listSize; i++)
            {
                if (elementType != typeof(NMSTemplate))
                {
                    var listItem = memory.GetValue(currentAddress, elementType);
                    list.Add(listItem);
                    currentAddress += objectSize;
                }
                else
                {
                    // This object is treated as a NMSTemplate, the base class, but is actually something else (inheritance).
                    // Need to convert it properly to get/set data.

                    // get actual field type:
                    long addressOfFieldType = (currentAddress + 0x8);
                    string nameOfFieldType = Strings.ToString(addressOfFieldType);

                    // it's empty, treat it as a NMSTemplate
                    if (string.IsNullOrEmpty(nameOfFieldType) || string.IsNullOrWhiteSpace(nameOfFieldType))
                    {
                        var itemToAdd = memory.GetValue(currentAddress, elementType);
                        list.Add(itemToAdd);
                        currentAddress += objectSize;
                        continue;
                    }

                    // try to get the corrisponding libmbin class
                    var actualFieldType = IGame.Instance.MBinManager.GetMBinType(nameOfFieldType);
                    //Console.WriteLine($"checking type: {actualFieldType.Name} | IsAssignableTo: {actualFieldType.IsAssignableTo(typeof(NMSTemplate))} | BaseType: {actualFieldType.BaseType.Name}");

                    if (actualFieldType == null) // not found. Probably an internal class.
                    {
                        // treat it as a regular NMSTemplate
                        ConsoleUtil.LogError($"Failed to get libmbin type for {nameOfFieldType}");

                        var itemToAdd = memory.GetValue(currentAddress, elementType);
                        list.Add(itemToAdd);
                        currentAddress += objectSize;
                        continue;
                    }


                    // we have the actual type and actual address of this field. Return correct value.
                    long actualFieldAddress = *(long*)currentAddress; // dereference since it's stored as a pointer.
                    var listItem = memory.GetValue(actualFieldAddress, actualFieldType);

                    list.Add(listItem);
                    currentAddress += objectSize;
                }
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
            int previousSize = memory.GetValue<int>(address + 0x8);

            if (list.Count != previousSize)
            {
                ConsoleUtil.LogError("The API currently does not support changing the size of lists in memory." +
                    " Make sure you are trying to set a list of the same size.");
                return;
            }


            int objectSize = NMSTemplate.SizeOf(elementType);
            long currentAddress = *(long*)address;

            for (int i = 0; i < list.Count; i++)
            {
                if (elementType != typeof(NMSTemplate))
                {
                    var currentValue = list[i];
                    if (currentValue != null)
                        memory.SetValue(currentAddress, currentValue);
                    currentAddress += objectSize;
                }
                else
                {
                    // This says it's a NMSTemplate but it's not. NMSTemplate is being used as the base class and it's actually something else.
                    // We need to set it properly.

                    var currentValue = list[i];
                    if (currentValue == null)
                    {
                        currentAddress += objectSize;
                        continue;
                    }

                    // the actual name of the class is at offset 8. Do that now
                    var type = currentValue.GetType();
                    string actualTypeName = type.Name.Remove(0,2).Insert(0, "cGc");
                    memory.SetValue(currentAddress + 0x8, actualTypeName);

                    // set the actual value. It's a pointer
                    long actualValueAddress = *(long*)currentAddress;
                    memory.SetValue(actualValueAddress, currentValue);
                    currentAddress += objectSize;
                }
            }


            memory.SetValue(address + 0x8, list.Count);
        }
    }
}
