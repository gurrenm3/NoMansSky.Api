using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api
{
    /// <summary>
    /// Extension methods for <see cref="MemoryManager"/>.
    /// </summary>
    public static class MemoryManagerExtensions
    {
        private static MemoryManagerCache cache = new MemoryManagerCache();

        public static void SetValue(this MemoryManager manager, string pathToValue, object valueToSet)
        {
            if (string.IsNullOrEmpty(pathToValue))
                throw new Exception("Cannot set value because the path to it was not set.");

            var addressInfo = cache.GetAddressInfo(pathToValue);
            if (addressInfo.address == 0 || addressInfo.objectType == null)
                throw new Exception($"Failed to get the address for {pathToValue}");

            if (valueToSet.GetType() != addressInfo.objectType)
            {
                try { valueToSet = Convert.ChangeType(valueToSet, addressInfo.objectType); }
                catch (Exception) { throw new ArgumentException($"Tried assigning a value with a type of" +
                    $" {valueToSet.GetType()} to {pathToValue}, however it's type is" +
                    $" a {addressInfo.objectType.Name}!"); }
            }

            manager.SetValue(addressInfo.address, valueToSet);
        }

        public static object GetValue(this MemoryManager manager, string pathToValue)
        {
            if (string.IsNullOrEmpty(pathToValue))
                throw new Exception("Cannot get value because the path to it was not set.");

            var addressInfo = cache.GetAddressInfo(pathToValue);
            if (addressInfo.address == 0 || addressInfo.objectType == null)
                throw new Exception($"Failed to get the address for {pathToValue}");

            var value = manager.GetValue(addressInfo.objectType, addressInfo.address);
            return value;
        }

        public static T GetValue<T>(this MemoryManager manager, string pathToValue)
        {
            var value = manager.GetValue(pathToValue);
            return value == null ? default(T) : (T)value;
        }
    }
}
