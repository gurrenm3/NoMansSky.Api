using libMBIN.NMS.GameComponents;
using System;
using System.Threading.Tasks;

namespace NoMansSky.Api
{
    /// <summary>
    /// Extension methods for <see cref="ICreatureRoleDescriptionsFile"/>.
    /// </summary>
    public static class ICreatureRoleDescriptionsFileExtensions
    {
        /// <summary>
        /// Reads this object in memory.
        /// <br/>This is the same as MBin.GetValue and is provided for convinience.
        /// </summary>
        /// <param name="instance"></param>
        /// <returns></returns>
        public static GcCreatureRoleFilenameTable GetValue(this ICreatureRoleDescriptionsFile instance)
        {
            return instance.MBin.GetValue<GcCreatureRoleFilenameTable>();
        }

        /// <summary>
        /// Reads this object in memory.
        /// <br/>This is the same as MBin.GetValue and is provided for convinience.
        /// <br/>Runs on a different thread and returns when done to prevent locking the game. 
        /// <br/>NOTE: Not synced with game loop.
        /// </summary>
        /// <param name="instance"></param>
        /// <returns></returns>
        public static async Task<GcCreatureRoleFilenameTable> GetValueAsync(this ICreatureRoleDescriptionsFile instance)
        {
            return await instance.MBin.GetValueAsync<GcCreatureRoleFilenameTable>();
        }


        /// <summary>
        /// Provides an easy way to get this mbin in memory, modify it, and apply the changes back to the game.
        /// <br/>This is the same as MBin.Modify and is provided for convinience.
        /// </summary>
        /// <param name="instance"></param>
        /// <param name="modifyAction"></param>
        public static void Modify(this ICreatureRoleDescriptionsFile instance, Action<GcCreatureRoleFilenameTable> modifyAction)
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
        public static async Task ModifyAsync(this ICreatureRoleDescriptionsFile instance, Action<GcCreatureRoleFilenameTable> modifyAction)
        {
            await instance.MBin.ModifyAsync(modifyAction);
        }
    }
}
