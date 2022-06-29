using libMBIN;
using System;

namespace Reloaded.ModHelper
{
    /// <summary>
    /// Used to convert arrays in memory.
    /// </summary>
    public class ArrayConverter : IMemoryConverter
    {
        IMemoryManager manager;

        public ArrayConverter(IMemoryManager manager)
        {
            if (manager == null)
                throw new NullReferenceException($"Can't create {nameof(ArrayConverter)} because the provided" +
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
            return typeToCheck != null && typeToCheck.IsArray;
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
        /// Get's this array in memory.
        /// </summary>
        /// <param name="arrayType"></param>
        /// <param name="address"></param>
        /// <param name="arrayLength"></param>
        /// <returns></returns>
        public Array GetValue(Type arrayType, long address, int arrayLength)
        {
            if (arrayType == null)
                return null;

            var elementType = arrayType.GetElementType();
            if (elementType == null)
                return null;

            dynamic array = Activator.CreateInstance(arrayType, arrayLength);
            int objectSize = NMSTemplate.SizeOf(elementType);

            long currentAddress = address;
            for (int i = 0; i < arrayLength; i++)
            {
                var arrayItem = manager.GetValue(elementType, currentAddress);
                if (arrayItem != null)
                    array.SetValue(arrayItem, i);
                currentAddress += objectSize;
            }

            return array;
        }

        public T[] GetValue<T>(long address, int arrayLength)
        {
            var array = GetValue(typeof(T), address, arrayLength);
            T[] values = new T[arrayLength];
            for (int i = 0; i < values.Length; i++)
                values[i] = (T)array.GetValue(i);
            return values;
        }

        /// <summary>
        /// Do not use this with arrays. Will not work because you must provide an array length.
        /// </summary>
        /// <param name="valueType"></param>
        /// <param name="address"></param>
        /// <returns></returns>
        public object GetValue(Type valueType, long address)
        {
            throw new NotSupportedException("Cannot use GetValue without providing an array length. Please use overloads that accept array length.");
        }

        /// <summary>
        /// Do not use this with arrays. Will not work because you must provide an array length.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="address"></param>
        /// <returns></returns>
        public T GetValue<T>(long address)
        {
            throw new NotSupportedException("Cannot use GetValue without providing an array length. Please use overloads that accept array length.");
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="address"></param>
        /// <param name="valueToSet"></param>
        public void SetValue(long address, object valueToSet)
        {
            var elementType = valueToSet.GetType().GetElementType();
            int objectSize = NMSTemplate.SizeOf(elementType);

            var array = (Array)valueToSet;
            long currentAddress = address;
            for (int i = 0; i < array.Length; i++)
            {
                var value = array.GetValue(i);
                manager.SetValue(currentAddress, value);

                /*var arrayItem = manager.GetValue(elementType, currentAddress);
                array.SetValue(arrayItem, i);*/
                currentAddress += objectSize;
            }
        }
    }
}
