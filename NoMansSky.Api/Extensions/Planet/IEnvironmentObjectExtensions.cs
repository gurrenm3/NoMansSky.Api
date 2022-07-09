using libMBIN.NMS.GameComponents;
using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api
{
    /// <summary>
    /// Extension methods for <see cref="IEnvironmentObject"/>.
    /// </summary>
    public static class IEnvironmentObjectExtensions
    {
        private static MemoryManager memory = new MemoryManager();

        /// <summary>
        /// Returns the <see cref="GcEnvironmentSpawnData"/> for this <see cref="IEnvironmentObject"/>.
        /// </summary>
        /// <param name="environmentObject"></param>
        /// <returns></returns>
        public static GcEnvironmentSpawnData GetSpawnData(this IEnvironmentObject environmentObject)
        {
            return memory.GetValue<GcEnvironmentSpawnData>(environmentObject.Address);
        }

        /// <summary>
        /// Sets the <see cref="GcEnvironmentSpawnData"/> for this <see cref="IEnvironmentObject"/>.
        /// </summary>
        /// <param name="environmentObject"></param>
        /// <param name="valueToSet"></param>
        public static void SetSpawnData(this IEnvironmentObject environmentObject, GcEnvironmentSpawnData valueToSet)
        {
            memory.SetValue(environmentObject.Address, valueToSet);
        }

        /// <summary>
        /// Provides a simpler way to load the SpawnData from memory, modify it, and apply the changes
        /// back to the game.
        /// </summary>
        /// <param name="environmentObject"></param>
        /// <param name="modAction"></param>
        public static void ModifySpawnData(this IEnvironmentObject environmentObject, Action<GcEnvironmentSpawnData> modAction)
        {
            var spawnData = environmentObject.GetSpawnData();
            modAction?.Invoke(spawnData);
            environmentObject.SetSpawnData(spawnData);
        }
    }
}
