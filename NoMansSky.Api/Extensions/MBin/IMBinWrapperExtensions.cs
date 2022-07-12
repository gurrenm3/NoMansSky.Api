using Reloaded.ModHelper;
using System;
using System.Threading.Tasks;

namespace NoMansSky.Api
{
    /// <summary>
    /// Extension methods for <see cref="IGlobalsFile"/>.
    /// </summary>
    public static class IMBinWrapperExtensions
    {
        /// <summary>
        /// Reads this object in memory.
        /// <br/>This is the same as MBin.GetValue and is provided for convinience.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="wrapper"></param>
        /// <returns></returns>
        public static T GetValue<T>(this IMBinWrapper wrapper)
        {
            return wrapper.MBin.GetValue<T>();
        }

        /// <summary>
        /// Reads this object in memory.
        /// <br/>This is the same as MBin.GetValueAsync and is provided for convinience.
        /// <br/>Runs on a different thread and returns when done to prevent locking the game. 
        /// <br/>NOTE: Not synced with game loop.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="wrapper"></param>
        /// <returns></returns>
        public static async Task<T> GetValueAsync<T>(this IMBinWrapper wrapper)
        {
            return await wrapper.MBin.GetValueAsync<T>();
        }

        /// <summary>
        /// Sets the value of this mbin in memory.
        /// <br/>This is the same as MBin.SetValue and is provided for convinience.
        /// </summary>
        /// <param name="wrapper"></param>
        /// <param name="valueToSet"></param>
        public static void SetValue(this IMBinWrapper wrapper, object valueToSet)
        {
            wrapper.MBin.SetValue(valueToSet);
        }

        /// <summary>
        /// Sets the value of this mbin in memory.
        /// <br/>This is the same as MBin.SetValueAsync and is provided for convinience.
        /// <br/>Runs on a different thread and returns when done to prevent locking the game. 
        /// <br/>NOTE: Not synced with game loop.
        /// </summary>
        /// <param name="wrapper"></param>
        /// <param name="valueToSet"></param>
        /// <returns></returns>
        public static async Task SetValueAsync(this IMBinWrapper wrapper, object valueToSet)
        {
            await wrapper.MBin.SetValueAsync(valueToSet);
        }

        /// <summary>
        /// Provides an easy way to get this mbin in memory, modify it, and apply the changes back to the game.
        /// <br/>This is the same as MBin.Modify and is provided for convinience.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="wrapper"></param>
        /// <param name="modifyAction"></param>
        public static void Modify<T>(this IMBinWrapper wrapper, Action<T> modifyAction)
        {
            wrapper.MBin.Modify(modifyAction);
        }

        /// <summary>
        /// Provides an easy way to get this mbin in memory, modify it, and apply the changes back to the game.
        /// <br/>This is the same as MBin.Modify and is provided for convinience.
        /// <br/>Runs on a different thread and returns when done to prevent locking the game. 
        /// <br/>NOTE: Not synced with game loop.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="wrapper"></param>
        /// <param name="modifyAction"></param>
        /// <returns></returns>
        public static async Task ModifyAsync<T>(this IMBinWrapper wrapper, Action<T> modifyAction)
        {
            await wrapper.MBin.ModifyAsync(modifyAction);
        }
    }
}
