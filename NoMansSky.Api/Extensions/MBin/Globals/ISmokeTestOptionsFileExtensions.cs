using libMBIN.NMS.Globals;
using System;
using System.Threading.Tasks;

namespace NoMansSky.Api
{
    /// <summary>
    /// Extension methods for <see cref="ISmokeTestOptionsFile"/>.
    /// </summary>
    public static class ISmokeTestOptionsFileExtensions
    {
        /// <summary>
        /// Reads this object in memory.
        /// <br/>This is the same as MBin.GetValue and is provided for convinience.
        /// </summary>
        /// <param name="instance"></param>
        /// <returns></returns>
        public static GcSmokeTestOptions GetValue(this ISmokeTestOptionsFile instance)
        {
            return instance.MBin.GetValue<GcSmokeTestOptions>();
        }

        /// <summary>
        /// Reads this object in memory.
        /// <br/>This is the same as MBin.GetValue and is provided for convinience.
        /// <br/>Runs on a different thread and returns when done to prevent locking the game. 
        /// <br/>NOTE: Not synced with game loop.
        /// </summary>
        /// <param name="instance"></param>
        /// <returns></returns>
        public static async Task<GcSmokeTestOptions> GetValueAsync(this ISmokeTestOptionsFile instance)
        {
            return await instance.MBin.GetValueAsync<GcSmokeTestOptions>();
        }

        /// <summary>
        /// Provides an easy way to get this mbin in memory, modify it, and apply the changes back to the game.
        /// <br/>This is the same as MBin.Modify and is provided for convinience.
        /// </summary>
        /// <param name="instance"></param>
        /// <param name="modifyAction"></param>
        public static void Modify(this ISmokeTestOptionsFile instance, Action<GcSmokeTestOptions> modifyAction)
        {
            instance.MBin.Modify(modifyAction);
        }

        /// <summary>
        /// Provides an easy way to get this mbin in memory, modify it, and apply the changes back to the game.
        /// <br/>This is the same as MBin.Modify and is provided for convinience.
        /// <br/>Runs on a different thread and returns when done to prevent locking the game. 
        /// <br/>NOTE: Not synced with game loop.
        /// </summary>
        /// <param name="instance"></param>
        /// <param name="modifyAction"></param>
        /// <returns></returns>
        public static async Task ModifyAsync(this ISmokeTestOptionsFile instance, Action<GcSmokeTestOptions> modifyAction)
        {
            await instance.MBin.ModifyAsync(modifyAction);
        }
    }
}
