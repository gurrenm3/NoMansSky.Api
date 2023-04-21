using libMBIN;
using Reloaded.ModHelper;
using System;
using System.Threading.Tasks;

namespace NoMansSky.Api
{
    /// <summary>
    /// Extension methods for <see cref="IMBin"/>.
    /// </summary>
    public static class IMBinExtensions
    {
        private static MemoryManager memory = new MemoryManager();

        /// <summary>
        /// Returns whether or not this mbin is representing a globals file.
        /// </summary>
        /// <param name="mbin"></param>
        /// <returns></returns>
        public static bool IsGlobalMbin(this IMBin mbin)
        {
            return mbin.Name.EndsWith("GLOBALS") || mbin.Name.Contains("DEBUGOPTIONS") || mbin.Name.Contains("SCENEOPTIONS") || mbin.Name.Contains("SMOKETESTOPTIONS");
        }

        /// <summary>
        /// Reads this object in memory.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="mbin"></param>
        /// <returns></returns>
        public static T GetValue<T>(this IMBin mbin) where T : NMSTemplate
        {
            return memory.GetValue<T>(mbin.Address);
        }

        /// <summary>
        /// Reads this object in memory.
        /// <br/>Runs on a different thread and returns when done to prevent locking the game. 
        /// <br/>NOTE: Not synced with game loop.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="mbin"></param>
        /// <returns></returns>
        public static async Task<T> GetValueAsync<T>(this IMBin mbin) where T : NMSTemplate
        {
            return await Task.Run(() => memory.GetValue<T>(mbin.Address));
        }

        /// <summary>
        /// Sets the value of this mbin in memory.
        /// </summary>
        /// <param name="mbin"></param>
        /// <param name="valueToSet"></param>
        public static void SetValue(this IMBin mbin, object valueToSet)
        {
            memory.SetValue(mbin.Address, valueToSet);
        }

        /// <summary>
        /// Sets the value of this mbin in memory.
        /// <br/>Runs on a different thread and returns when done to prevent locking the game. 
        /// <br/>NOTE: Not synced with game loop.
        /// </summary>
        /// <param name="mbin"></param>
        /// <param name="valueToSet"></param>
        /// <returns></returns>
        public static async Task SetValueAsync(this IMBin mbin, object valueToSet)
        {
            await Task.Run(() => memory.SetValue(mbin.Address, valueToSet));
        }

        /// <summary>
        /// Provides an easy way to get this mbin in memory, modify it, and apply the changes back to the game.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="mbin"></param>
        /// <param name="modifyAction"></param>
        public static void Modify<T>(this IMBin mbin, Action<T> modifyAction) where T : NMSTemplate
        {
            var value = mbin.GetValue<T>();
            modifyAction.Invoke(value);
            mbin.SetValue(value);
        }

        /// <summary>
        /// Provides an easy way to get this mbin in memory, modify it, and apply the changes back to the game.
        /// <br/>Runs on a different thread and returns when done to prevent locking the game. 
        /// <br/>NOTE: Not synced with game loop.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="mbin"></param>
        /// <param name="modifyAction"></param>
        /// <returns></returns>
        public static async Task ModifyAsync<T>(this IMBin mbin, Action<T> modifyAction) where T : NMSTemplate
        {
            await Task.Run(() =>
            {
                var value = mbin.GetValue<T>();
                modifyAction?.Invoke(value);
                mbin.SetValue(value);
            });
        }
    }
}
