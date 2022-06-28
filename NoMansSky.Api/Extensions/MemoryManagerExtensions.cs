using Reloaded.ModHelper;
using System;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace NoMansSky.Api
{
    /// <summary>
    /// Extension methods for <see cref="MemoryManager"/>.
    /// </summary>
    public static class MemoryManagerExtensions
    {
        private static MemoryManagerCache cache = new MemoryManagerCache();

        /// <summary>
        /// Sets an object in memory at the provided address on a separate thread and returns when its done.
        /// Use this for big objects so you don't lock the game.
        /// <br/><br/>Takes a full path to the object you want to set.
        /// <br/>Example: pathToValue = "GcPlayerGlobals.GroundRunSpeed"
        /// </summary>
        /// <param name="manager"></param>
        /// <param name="pathToValue"></param>
        /// <param name="valueToSet"></param>
        /// <returns></returns>
        public static async Task SetValueAsync(this MemoryManager manager, string pathToValue, object valueToSet)
        {
            try
            {
                await Task.Run(() => manager.SetValue(pathToValue, valueToSet));
            }
            catch (Exception ex) { throw ex; }
        }

        /// <summary>
        /// Sets an object in memory at the provided address. Takes a full path to the object you want to set.
        /// <br/>Example: pathToValue = "GcPlayerGlobals.GroundRunSpeed"
        /// </summary>
        /// <param name="manager"></param>
        /// <param name="pathToValue"></param>
        /// <param name="valueToSet"></param>
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


        /// <summary>
        /// Reads an object in memory on a separate thread and returns when its done.
        /// Use this for big objects so you don't lock the game.
        /// <br/><br/>Takes a full path to the object you want to set.
        /// <br/>Example: pathToValue = "GcPlayerGlobals.GroundRunSpeed"
        /// </summary>
        /// <param name="manager"></param>
        /// <param name="pathToValue"></param>
        /// <returns></returns>
        public static async Task<object> GetValueAsync(this MemoryManager manager, string pathToValue)
        {
            try
            {
                return await Task.Run(() => manager.GetValue(pathToValue));
            }
            catch (Exception ex) { throw ex; }
        }

        /// <summary>
        /// Reads an object in memory on a separate thread and returns when its done.
        /// Use this for big objects so you don't lock the game.
        /// <br/><br/>Takes a full path to the object you want to set.
        /// <br/>Example: pathToValue = "GcPlayerGlobals.GroundRunSpeed"
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="manager"></param>
        /// <param name="pathToValue"></param>
        /// <returns></returns>
        public static async Task<T> GetValueAsync<T>(this MemoryManager manager, string pathToValue)
        {
            try
            {
                var value = await Task.Run(() => manager.GetValue<T>(pathToValue));
                return value == null ? default(T) : (T)value;
            }
            catch (Exception ex) { throw ex; }
        }


        /// <summary>
        /// Reads an object in memory. Takes a full path to the object you want to set.
        /// <br/>Example: pathToValue = "GcPlayerGlobals.GroundRunSpeed"
        /// </summary>
        /// <param name="manager"></param>
        /// <param name="pathToValue"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Reads an object in memory. Takes a full path to the object you want to set.
        /// <br/>Example: pathToValue = "GcPlayerGlobals.GroundRunSpeed"
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="manager"></param>
        /// <param name="pathToValue"></param>
        /// <returns></returns>
        public static T GetValue<T>(this MemoryManager manager, string pathToValue)
        {
            var value = manager.GetValue(pathToValue);
            return value == null ? default(T) : (T)value;
        }
    }
}
