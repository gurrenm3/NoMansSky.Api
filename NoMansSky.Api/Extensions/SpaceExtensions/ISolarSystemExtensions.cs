using libMBIN.NMS.GameComponents;
using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
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
        /// Provides an easier way to mod a Planet.
        /// </summary>
        /// <param name="system"></param>
        /// <param name="modify"></param>
        public static void ModifyPlanets(this ISolarSystem system, Action<List<GcPlanetData>> modify)
        {
            var planets = system.GetPlanets();
            modify.Invoke(planets);

            for (int i = 0; i < planets.Count; i++)
            {
                var planet = planets[i];
                if (planet == null)
                    continue;

                long planetAddress = system.PlanetAddresses[i];
                memory.SetValue(planetAddress, planet);
            }
        }

        /// <summary>
        /// Provides an easier way to mod a Planet.
        /// </summary>
        /// <param name="system"></param>
        /// <param name="planetIndex"></param>
        /// <param name="modify"></param>
        public static void ModifyPlanet(this ISolarSystem system, int planetIndex, Action<GcPlanetData> modify)
        {
            if (planetIndex >= system.PlanetAddresses.Count)
            {
                ConsoleUtil.LogError($"PlanetIndex out of bounds! Can't access planet with index of" +
                    $" {planetIndex} because no planet exists at that index!");
                return;
            }

            long planetAddress = system.PlanetAddresses[planetIndex];
            var planet = system.GetPlanetData(planetAddress);
            if (planet == null)
            {
                ConsoleUtil.LogError($"Failed to get Planet to Modify");
                return;
            }

            modify.Invoke(planet);
            memory.SetValue(planetAddress, planet);
        }

        /// <summary>
        /// Provides an easier way to mod a Planet.
        /// </summary>
        /// <param name="system"></param>
        /// <param name="planetAddress"></param>
        /// <param name="modify"></param>
        public static void ModifyPlanet(this ISolarSystem system, long planetAddress, Action<GcPlanetData> modify)
        {
            if (planetAddress <= 0)
            {
                ConsoleUtil.LogError($"Can't modify Planet data. planetAddress is invald!");
                return;
            }

            var planet = system.GetPlanetData(planetAddress);
            if (planet == null)
            {
                ConsoleUtil.LogError($"Failed to get Planet to Modify");
                return;
            }

            modify.Invoke(planet);
            memory.SetValue(planetAddress, planet);
        }

        /// <summary>
        /// Provides an easier way of modifying the system.
        /// </summary>
        /// <param name="solarSystem"></param>
        /// <param name="modify"></param>
        public static void ModifySystemData(this ISolarSystem solarSystem, Action<GcSolarSystemData> modify)
        {
            solarSystem.ModifySystemData(solarSystem.SystemAddress, modify);
        }

        /// <summary>
        /// Provides an easier way of modifying the system.
        /// </summary>
        /// <param name="solarSystem"></param>
        /// <param name="systemAddress"></param>
        /// <param name="modify"></param>
        public static void ModifySystemData(this ISolarSystem solarSystem, long systemAddress, Action<GcSolarSystemData> modify)
        {
            if (systemAddress <= 0)
            {
                ConsoleUtil.LogError($"Can't modify system data. SystemAddress is invald!");
                return;
            }

            var systemData = solarSystem.GetSystemData();
            modify.Invoke(systemData);
            memory.SetValue(systemAddress, systemData);
        }

        /// <summary>
        /// Returns the System Data for this solar system.
        /// </summary>
        /// <param name="instance"></param>
        /// <returns></returns>
        public static GcSolarSystemData GetSystemData(this ISolarSystem instance)
        {
            return memory.GetValue<GcSolarSystemData>(instance.SystemAddress);
        }

        /// <summary>
        /// Returns the System Data for this solar system.
        /// <br/>Runs on a different thread and returns when done to prevent locking the game. 
        /// Use this for big objects so you don't lock the game.
        /// <br/>NOTE: Not synced with game loop.
        /// </summary>
        /// <param name="instance"></param>
        /// <returns></returns>
        public static async Task<GcSolarSystemData> GetSystemDataAsync(this ISolarSystem instance)
        {
            return await memory.GetValueAsync<GcSolarSystemData>(instance.SystemAddress);
        }

        /// <summary>
        /// Sets the System Data for this solar system.
        /// </summary>
        /// <param name="instance"></param>
        /// <param name="systemData"></param>
        /// <returns></returns>
        public static void SetSystemData(this ISolarSystem instance, GcSolarSystemData systemData)
        {
            memory.SetValue(instance.SystemAddress, systemData);
        }

        /// <summary>
        /// Sets the System Data for this solar system.
        /// <br/>Runs on a different thread and returns when done to prevent locking the game. 
        /// Use this for big objects so you don't lock the game.
        /// <br/>NOTE: Not synced with game loop.
        /// </summary>
        /// <param name="instance"></param>
        /// <param name="systemData"></param>
        /// <returns></returns>
        public static async Task GetSystemDataAsync(this ISolarSystem instance, GcSolarSystemData systemData)
        {
            await memory.SetValueAsync(instance.SystemAddress, systemData);
        }


        /// <summary>
        /// Returns the Planet Data for all of the planets in this system.
        /// </summary>
        /// <param name="instance"></param>
        /// <returns></returns>
        public static List<GcPlanetData> GetPlanets(this ISolarSystem instance)
        {
            List<GcPlanetData> planets = new List<GcPlanetData>();
            foreach (var planetAddress in instance.PlanetAddresses)
            {
                var planet = memory.GetValue<GcPlanetData>(planetAddress);
                planets.Add(planet);
            }
            return planets;
        }

        /// <summary>
        /// Returns the planet data for a planet with the provided address.
        /// </summary>
        /// <param name="instance"></param>
        /// <param name="planetAddress"></param>
        /// <returns></returns>
        public static GcPlanetData GetPlanetData(this ISolarSystem instance, long planetAddress)
        {
            return memory.GetValue<GcPlanetData>(planetAddress);
        }

        /// <summary>
        /// Returns the planet data for a planet with the provided address.
        /// <br/>Runs on a different thread and returns when done to prevent locking the game. 
        /// Use this for big objects so you don't lock the game.
        /// <br/>NOTE: Not synced with game loop.
        /// </summary>
        /// <param name="instance"></param>
        /// <param name="planetAddress"></param>
        /// <returns></returns>
        public static async Task<GcPlanetData> GetPlanetDataAsync(this ISolarSystem instance, long planetAddress)
        {
            return await memory.GetValueAsync<GcPlanetData>(planetAddress);
        }

        /// <summary>
        /// Set the PlanetData of the Planet at the provided address to a different value.
        /// </summary>
        /// <param name="instance"></param>
        /// <param name="planetAddress"></param>
        /// <param name="planetData"></param>
        public static void SetPlanetData(this ISolarSystem instance, long planetAddress, GcPlanetData planetData)
        {
            memory.SetValue(planetAddress, planetData);
        }

        /// <summary>
        /// Set the PlanetData of the Planet at the provided address to a different value.
        /// <br/>Runs on a different thread and returns when done to prevent locking the game. 
        /// Use this for big objects so you don't lock the game.
        /// <br/>NOTE: Not synced with game loop.
        /// </summary>
        /// <param name="instance"></param>
        /// <param name="planetAddress"></param>
        /// <param name="planetData"></param>
        /// <returns></returns>
        public static async Task SetPlanetDataAsync(this ISolarSystem instance, long planetAddress, GcPlanetData planetData)
        {
            await memory.SetValueAsync(planetAddress, planetData);
        }
    }
}
