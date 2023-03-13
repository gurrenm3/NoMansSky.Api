using Reloaded.ModHelper;
using System;
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
        /// Sets a value in memory at the provided path. Path must be the full location of the object you want
        /// to set, separated by periods. Works on nested objects.
        /// <br/>Example Path: "GcPlayerGlobals.GroundRunSpeed"
        /// 
        /// <br/><br/>Runs on a separate thread and returns when it's done.
        /// It's recommended that you use this for bigger objects so you don't lock the game while
        /// the value is being set.
        /// <br/>Note: Since this runs on a separate thread it will not be synced with game loop.
        /// </summary>
        /// <param name="manager"></param>
        /// <param name="pathToValue">The full path to the object you want to set, separated by periods.</param>
        /// <param name="valueToSet">The value to be assigned to the provided path.</param>
        /// <returns></returns>
        public static async Task SetValueAsync(this MemoryManager manager, string pathToValue, object valueToSet)
        {
            try
            {
                await Task.Run(() => manager.SetValue(pathToValue, valueToSet));
            }
            catch (Exception ex) 
            {
                ConsoleUtils.LogException(ex);
            }
        }

        /// <summary>
        /// Sets a value in memory at the provided path. Path must be the full location of the object you want
        /// to set, separated by periods. Works on nested objects.
        /// <br/>Example Path: "GcPlayerGlobals.GroundRunSpeed"
        /// </summary>
        /// <param name="manager"></param>
        /// <param name="pathToValue">The full path to the object you want to set, separated by periods.</param>
        /// <param name="valueToSet">The value to be assigned to the provided path.</param>
        public static void SetValue(this MemoryManager manager, string pathToValue, object valueToSet)
        {
            if (string.IsNullOrEmpty(pathToValue))
            {
                ConsoleUtils.LogError("Cannot set value because the path to it was not set.");
                return;
            }

            var addressInfo = cache.GetAddressInfo(pathToValue);
            if (addressInfo.address == 0 || addressInfo.objectType == null)
            {
                ConsoleUtils.LogError($"Failed to get the address for {pathToValue}");
                return;
            }

            if (valueToSet.GetType() != addressInfo.objectType)
            {
                try { valueToSet = Convert.ChangeType(valueToSet, addressInfo.objectType); }
                catch (Exception) 
                {
                    ConsoleUtils.LogError($"Tried assigning a value with a type of" +
                    $" {valueToSet.GetType()} to {pathToValue}, however it's type is" +
                    $" a {addressInfo.objectType.Name}!");
                    return;
                }
            }

            manager.SetValue(addressInfo.address, valueToSet);
        }


        /// <summary>
        /// Returns the value that is stored in memory at the provided path. Path must be the full location 
        /// of the object you want to get, separated by periods. Works on nested objects.
        /// <br/>Example Path: "GcPlayerGlobals.GroundRunSpeed"
        /// 
        /// <br/><br/>Runs on a separate thread and returns when it's done.
        /// It's recommended that you use this for bigger objects so you don't lock the game while
        /// the value is being retrieved.
        /// <br/>Note: Since this runs on a separate thread it will not be synced with game loop.
        /// </summary>
        /// <param name="manager"></param>
        /// <param name="pathToValue">The full path to the object you want to set, separated by periods.</param>
        /// <returns></returns>
        public static async Task<object> GetValueAsync(this MemoryManager manager, string pathToValue)
        {
            try
            {
                return await Task.Run(() => manager.GetValue(pathToValue));
            }
            catch (Exception ex)
            {
                ConsoleUtils.LogException(ex);
                return null!;
            }
        }

        /// <summary>
        /// Returns the value that is stored in memory at the provided path. Path must be the full location 
        /// of the object you want to get, separated by periods. Works on nested objects.
        /// <br/>Example Path: "GcPlayerGlobals.GroundRunSpeed"
        /// 
        /// <br/><br/>Runs on a separate thread and returns when it's done.
        /// It's recommended that you use this for bigger objects so you don't lock the game while
        /// the value is being retrieved.
        /// <br/>Note: Since this runs on a separate thread it will not be synced with game loop.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="manager"></param>
        /// <param name="pathToValue">The full path to the object you want to set, separated by periods.</param>
        /// <returns></returns>
        public static async Task<T> GetValueAsync<T>(this MemoryManager manager, string pathToValue)
        {
            try
            {
                return await Task.Run(() => manager.GetValue<T>(pathToValue));
            }
            catch (Exception ex)
            {
                ConsoleUtils.LogException(ex);
                return default(T)!;
            }
        }


        /// <summary>
        /// Returns the value that is stored in memory at the provided path. Path must be the full location 
        /// of the object you want to get, separated by periods. Works on nested objects.
        /// <br/><br/>Example Path: "GcPlayerGlobals.GroundRunSpeed"
        /// </summary>
        /// <param name="manager"></param>
        /// <param name="pathToValue">The full path to the object you want to set, separated by periods.</param>
        /// <returns></returns>
        public static object GetValue(this MemoryManager manager, string pathToValue)
        {
            if (string.IsNullOrEmpty(pathToValue))
            {
                ConsoleUtils.LogError("Cannot get value because the path to it was not set.");
                return null!;
            }

            var addressInfo = cache.GetAddressInfo(pathToValue);
            if (addressInfo.address == 0 || addressInfo.objectType == null)
            {
                ConsoleUtils.LogError($"Failed to get the address for {pathToValue}");
                return null!;
            }

            var value = manager.GetValue(addressInfo.address, addressInfo.objectType);
            return value;
        }

        /// <summary>
        /// Returns the value that is stored in memory at the provided path. Path must be the full location 
        /// of the object you want to get, separated by periods. Works on nested objects.
        /// <br/><br/>Example Path: "GcPlayerGlobals.GroundRunSpeed"
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="manager"></param>
        /// <param name="pathToValue">The full path to the object you want to set, separated by periods.</param>
        /// <returns></returns>
        public static T GetValue<T>(this MemoryManager manager, string pathToValue)
        {
            var value = manager.GetValue(pathToValue);
            return value == null ? default(T)! : (T)value;
        }
    }
}
