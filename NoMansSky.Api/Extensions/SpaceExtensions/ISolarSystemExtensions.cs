using libMBIN.NMS.GameComponents;
using Reloaded.ModHelper;
using System;
using System.Threading.Tasks;

namespace NoMansSky.Api
{
    /// <summary>
    /// Extension Methods for <see cref="ISolarSystemData"/>.
    /// </summary>
    public static class ISolarSystemExtensions
    {
        private static MemoryManager memory = new MemoryManager();


        /// <summary>
        /// Returns the System Data for this solar system.
        /// </summary>
        /// <param name="instance"></param>
        /// <returns></returns>
        public static GcSolarSystemData GetSystemData(this ISolarSystem instance)
        {
            return memory.GetValue<GcSolarSystemData>(instance.SystemDataAddress);
        }

        /// <summary>
        /// Returns the System Data for this solar system.
        /// <br/>Runs on a different thread and returns when done to prevent locking the game.
        /// <br/>NOTE: Not synced with game loop.
        /// </summary>
        /// <param name="instance"></param>
        /// <returns></returns>
        public static async Task<GcSolarSystemData> GetSystemDataAsync(this ISolarSystem instance)
        {
            return await memory.GetValueAsync<GcSolarSystemData>(instance.SystemDataAddress);
        }

        /// <summary>
        /// Sets the System Data for this solar system.
        /// </summary>
        /// <param name="instance"></param>
        /// <param name="systemData"></param>
        /// <returns></returns>
        public static void SetSystemData(this ISolarSystem instance, GcSolarSystemData systemData)
        {
            memory.SetValue(instance.SystemDataAddress, systemData);
        }

        /// <summary>
        /// Sets the System Data for this solar system.
        /// <br/>Runs on a different thread and returns when done to prevent locking the game. 
        /// <br/>NOTE: Not synced with game loop.
        /// </summary>
        /// <param name="instance"></param>
        /// <param name="systemData"></param>
        /// <returns></returns>
        public static async Task SetSystemDataAsync(this ISolarSystem instance, GcSolarSystemData systemData)
        {
            await memory.SetValueAsync(instance.SystemDataAddress, systemData);
        }



        /// <summary>
        /// Provides a simpler way to load the current SolarSystemData from memory, modify it, and apply the changes
        /// back to the game.
        /// </summary>
        /// <param name="solarSystem"></param>
        /// <param name="modify"></param>
        public static void ModifySystemData(this ISolarSystem solarSystem, Action<GcSolarSystemData> modify)
        {
            var systemData = solarSystem.GetSystemData();
            modify?.Invoke(systemData);
            solarSystem.SetSystemData(systemData);
        }


        /// <summary>
        /// Provides a simpler way to load the current SolarSystemData from memory, modify it, and apply the changes
        /// back to the game.
        /// <br/>Runs on a different thread and returns when done to prevent locking the game. 
        /// <br/>NOTE: Not synced with game loop.
        /// </summary>
        /// <param name="solarSystem"></param>
        /// <param name="modify"></param>
        public static async Task ModifySystemDataAsync(this ISolarSystem solarSystem, Action<GcSolarSystemData> modify)
        {
            await Task.Run(() =>
            {
                var systemData = solarSystem.GetSystemData();
                modify?.Invoke(systemData);
                solarSystem.SetSystemData(systemData);
            });
        }

        /// <summary>
        /// A high performance foreach loop that loops over every planet in the system at the same time.
        /// <br/>It's recommended that you use this if you're able to, because it's significantly faster than
        /// a normal foreach loop and it iterates over each planet simultaneously.
        /// </summary>
        /// <param name="solarSystem"></param>
        /// <param name="modifyPlanet"></param>
        public static void ForEachPlanet(this ISolarSystem solarSystem, Action<IPlanet> modifyPlanet)
        {
            Parallel.ForEach(solarSystem.Planets, planet =>
            {
                modifyPlanet?.Invoke(planet);
            });
        }

        /// <summary>
        /// A high performance foreach loop that loops over every planet in the system at the same time.
        /// <br/>Runs on a different thread and returns when done to prevent locking the game. 
        /// <br/>NOTE: Not synced with game loop.
        /// </summary>
        /// <param name="solarSystem"></param>
        /// <param name="modifyPlanet"></param>
        /// <returns></returns>
        public static async Task ForEachPlanetAsync(this ISolarSystem solarSystem, Action<IPlanet> modifyPlanet)
        {
            await Task.Run(() =>
            {
                Parallel.ForEach(solarSystem.Planets, planet =>
                {
                    modifyPlanet?.Invoke(planet);
                });
            });
        }
    }
}
