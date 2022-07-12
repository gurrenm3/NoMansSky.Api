using Reloaded.ModHelper;
using libMBIN;
using System;
using System.Threading.Tasks;

namespace NoMansSky.Api
{
    /// <summary>
    /// Used to convert arrays in memory.
    /// </summary>
    public class ArrayConverter : IMemoryConverter
    {
        IMemoryManager manager;

        /// <summary>
        /// Creates an object of this converter, along with a MemoryManager for recursion.
        /// </summary>
        /// <param name="manager"></param>
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
            if (typeToCheck == null)
            {
                ConsoleUtil.LogError($"{nameof(ArrayConverter)} can't check if this type can be converted," +
                    $" because the type to check is NULL");
                return false;
            }

            return typeToCheck.IsArray;
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
        public Array GetValue(long address, Type arrayType, int arrayLength)
        {
            var elementType = arrayType.GetElementType();
            dynamic array = Activator.CreateInstance(arrayType, arrayLength)!;
            int objectSize = NMSTemplate.SizeOf(elementType);

            long currentAddress = address;

            for (int i = 0; i < arrayLength; i++)
            {
                var arrayItem = manager.GetValue(currentAddress, elementType);
                currentAddress += objectSize;

                if (arrayItem == null)
                {
                    ConsoleUtil.LogWarning($"{nameof(ArrayConverter)}: Field value is null. Skipping...");
                    continue;
                }

                array.SetValue(arrayItem, i);
            }

            return array;
        }

        /// <summary>
        /// Get's this array in memory.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="address"></param>
        /// <param name="arrayLength"></param>
        /// <returns></returns>
        public T[] GetValue<T>(long address, int arrayLength)
        {
            var array = GetValue(address, typeof(T), arrayLength);
            if (array == null)
                return default(T[])!;

            T[] values = new T[arrayLength];
            for (int i = 0; i < values.Length; i++)
                values[i] = (T)array.GetValue(i)!;

            return values;
        }

        /// <summary>
        /// Do not use this with arrays. Will not work because you must provide an array length.
        /// <br/>Use the GetValue method that takes arrayLength as an argument.
        /// </summary>
        /// <param name="arrayType"></param>
        /// <param name="address"></param>
        /// <returns></returns>
        public object GetValue(long address, Type arrayType)
        {
            ConsoleUtil.LogError("Cannot use GetValue without providing an array length. Please use overloads that accept array length.");
            return null!;
        }

        /// <summary>
        /// Do not use this with arrays. Will not work because you must provide an array length.
        /// <br/>Use the GetValue method that takes arrayLength as an argument.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="address"></param>
        /// <returns></returns>
        public T GetValue<T>(long address)
        {
            ConsoleUtil.LogError("Cannot use GetValue without providing an array length. Please use overloads that accept array length.");
            return default(T)!;
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
                if (value != null)
                    manager.SetValue(currentAddress, value);

                currentAddress += objectSize;
            }
        }
    }
}
