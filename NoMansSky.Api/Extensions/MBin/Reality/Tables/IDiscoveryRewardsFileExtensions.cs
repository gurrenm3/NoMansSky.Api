using libMBIN.NMS.GameComponents;
using System;
using System.Threading.Tasks;

namespace NoMansSky.Api
{
    /// <summary>
    /// Extension methods for <see cref="IDiscoveryRewardsFile"/>.
    /// </summary>
    public static class IDiscoveryRewardsFileExtensions
    {
        /// <summary>
        /// Reads this object in memory.
        /// <br/>This is the same as MBin.GetValue and is provided for convinience.
        /// </summary>
        /// <param name="instance"></param>
        /// <returns></returns>
        public static GcDiscoveryRewardLookupTable GetValue(this IDiscoveryRewardsFile instance)
        {
            return instance.MBin.GetValue<GcDiscoveryRewardLookupTable>();
        }

        /// <summary>
        /// Reads this object in memory.
        /// <br/>This is the same as MBin.GetValue and is provided for convinience.
        /// <br/>Runs on a different thread and returns when done to prevent locking the game. 
        /// <br/>NOTE: Not synced with game loop.
        /// </summary>
        /// <param name="instance"></param>
        /// <returns></returns>
        public static async Task<GcDiscoveryRewardLookupTable> GetValueAsync(this IDiscoveryRewardsFile instance)
        {
            return await instance.MBin.GetValueAsync<GcDiscoveryRewardLookupTable>();
        }

        /// <summary>
        /// Provides an easy way to get this mbin in memory, modify it, and apply the changes back to the game.
        /// <br/>This is the same as MBin.Modify and is provided for convinience.
        /// </summary>
        /// <param name="instance"></param>
        /// <param name="modifyAction"></param>
        public static void Modify(this IDiscoveryRewardsFile instance, Action<GcDiscoveryRewardLookupTable> modifyAction)
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
        public static async Task ModifyAsync(this IDiscoveryRewardsFile instance, Action<GcDiscoveryRewardLookupTable> modifyAction)
        {
            await instance.MBin.ModifyAsync(modifyAction);
        }
    }
}
