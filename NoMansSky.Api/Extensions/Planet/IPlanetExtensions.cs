using libMBIN.NMS.GameComponents;
using Reloaded.ModHelper;
using System;
using System.Threading.Tasks;

namespace NoMansSky.Api
{
    /// <summary>
    /// Extensions for IPlanet
    /// </summary>
    public static class IPlanetExtensions
    {
        private static MemoryManager memory = new MemoryManager();

        /// <summary>
        /// Returns the planet data for this planet.
        /// </summary>
        /// <param name="planet"></param>
        /// <returns></returns>
        public static GcPlanetData GetPlanetData(this IPlanet planet)
        {
            return memory.GetValue<GcPlanetData>(planet.PlanetDataAddress);
        }

        /// <summary>
        /// Returns the planet data for this planet.
        /// <br/>Runs on a different thread and returns when done to prevent locking the game. 
        /// <br/>NOTE: Not synced with game loop.
        /// </summary>
        /// <returns></returns>
        public static async Task<GcPlanetData> GetPlanetDataAsync(this IPlanet planet)
        {
            return await memory.GetValueAsync<GcPlanetData>(planet.PlanetDataAddress);
        }

        /// <summary>
        /// Set's the entire planet data of this planet.
        /// </summary>
        /// <param name="planet"></param>
        /// <param name="dataToSet"></param>
        public static void SetPlanetData(this IPlanet planet, GcPlanetData dataToSet)
        {
            memory.SetValue(planet.PlanetDataAddress, dataToSet);
        }

        /// <summary>
        /// Set the PlanetData of the Planet at the provided address to a different value.
        /// <br/>Runs on a different thread and returns when done to prevent locking the game.
        /// <br/>NOTE: Not synced with game loop.
        /// </summary>
        /// <param name="planet"></param>
        /// <param name="dataToSet"></param>
        /// <returns></returns>
        public static async Task SetPlanetDataAsync(this IPlanet planet, GcPlanetData dataToSet)
        {
            await memory.SetValueAsync(planet.PlanetDataAddress, dataToSet);
        }

        /// <summary>
        /// Provides a simpler way to load the current PlanetData from memory, modify it, and apply the changes
        /// back to the game.
        /// </summary>
        /// <param name="planet"></param>
        /// <param name="modifyAction"></param>
        public static void ModifyPlanetData(this IPlanet planet, Action<GcPlanetData> modifyAction)
        {
            var planetData = planet.GetPlanetData();
            modifyAction?.Invoke(planetData);
            planet.SetPlanetData(planetData);
        }

        /// <summary>
        /// Provides a simpler way to load the current PlanetData from memory, modify it, and apply the changes
        /// back to the game.
        /// <br/>Runs on a different thread and returns when done to prevent locking the game.
        /// <br/>NOTE: Not synced with game loop
        /// </summary>
        /// <param name="planet"></param>
        /// <param name="modifyAction"></param>
        /// <returns></returns>
        public static async Task ModifyPlanetDataAsync(this IPlanet planet, Action<GcPlanetData> modifyAction)
        {
            await Task.Run(() =>
            {
                var planetData = planet.GetPlanetData();
                modifyAction?.Invoke(planetData);
                planet.SetPlanetData(planetData);
            });
        }
    }
}
