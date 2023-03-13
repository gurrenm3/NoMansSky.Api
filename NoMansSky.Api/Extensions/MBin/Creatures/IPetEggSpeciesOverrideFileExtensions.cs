using libMBIN.NMS.GameComponents;
using System;
using System.Threading.Tasks;

namespace NoMansSky.Api
{
    /// <summary>
    /// Extension methods for <see cref="IPetEggSpeciesOverrideFile"/>.
    /// </summary>
    public static class IPetEggSpeciesOverrideFileExtensions
    {
        /// <summary>
        /// Reads this object in memory.
        /// <br/>This is the same as MBin.GetValue and is provided for convinience.
        /// </summary>
        /// <param name="instance"></param>
        /// <returns></returns>
        public static GcPetEggSpeciesOverrideTable GetValue(this IPetEggSpeciesOverrideFile instance)
        {
            return instance.MBin.GetValue<GcPetEggSpeciesOverrideTable>();
        }

        /// <summary>
        /// Reads this object in memory.
        /// <br/>This is the same as MBin.GetValue and is provided for convinience.
        /// <br/>Runs on a different thread and returns when done to prevent locking the game. 
        /// <br/>NOTE: Not synced with game loop.
        /// </summary>
        /// <param name="instance"></param>
        /// <returns></returns>
        public static async Task<GcPetEggSpeciesOverrideTable> GetValueAsync(this IPetEggSpeciesOverrideFile instance)
        {
            return await instance.MBin.GetValueAsync<GcPetEggSpeciesOverrideTable>();
        }


        /// <summary>
        /// Provides an easy way to get this mbin in memory, modify it, and apply the changes back to the game.
        /// <br/>This is the same as MBin.Modify and is provided for convinience.
        /// </summary>
        /// <param name="instance"></param>
        /// <param name="modifyAction"></param>
        public static void Modify(this IPetEggSpeciesOverrideFile instance, Action<GcPetEggSpeciesOverrideTable> modifyAction)
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
        public static async Task ModifyAsync(this IPetEggSpeciesOverrideFile instance, Action<GcPetEggSpeciesOverrideTable> modifyAction)
        {
            await instance.MBin.ModifyAsync(modifyAction);
        }
    }
}
