using libMBIN.NMS.GameComponents;
using System;
using System.Threading.Tasks;

namespace NoMansSky.Api
{
    /// <summary>
    /// Extension methods for <see cref="IPurchaseableBuildingBluprintsFile"/>.
    /// </summary>
    public static class IPurchaseableBuildingBluprintsFileExtensions
    {
        /// <summary>
        /// Reads this object in memory.
        /// <br/>This is the same as MBin.GetValue and is provided for convinience.
        /// </summary>
        /// <param name="instance"></param>
        /// <returns></returns>
        public static GcPurchaseableBuildingBlueprints GetValue(this IPurchaseableBuildingBluprintsFile instance)
        {
            return instance.MBin.GetValue<GcPurchaseableBuildingBlueprints>();
        }

        /// <summary>
        /// Reads this object in memory.
        /// <br/>This is the same as MBin.GetValue and is provided for convinience.
        /// <br/>Runs on a different thread and returns when done to prevent locking the game. 
        /// <br/>NOTE: Not synced with game loop.
        /// </summary>
        /// <param name="instance"></param>
        /// <returns></returns>
        public static async Task<GcPurchaseableBuildingBlueprints> GetValueAsync(this IPurchaseableBuildingBluprintsFile instance)
        {
            return await instance.MBin.GetValueAsync<GcPurchaseableBuildingBlueprints>();
        }

        /// <summary>
        /// Provides an easy way to get this mbin in memory, modify it, and apply the changes back to the game.
        /// <br/>This is the same as MBin.Modify and is provided for convinience.
        /// </summary>
        /// <param name="instance"></param>
        /// <param name="modifyAction"></param>
        public static void Modify(this IPurchaseableBuildingBluprintsFile instance, Action<GcPurchaseableBuildingBlueprints> modifyAction)
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
        public static async Task ModifyAsync(this IPurchaseableBuildingBluprintsFile instance, Action<GcPurchaseableBuildingBlueprints> modifyAction)
        {
            await instance.MBin.ModifyAsync(modifyAction);
        }
    }
}
