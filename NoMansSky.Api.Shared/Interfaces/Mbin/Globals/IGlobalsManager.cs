using Reloaded.ModHelper;
using System.Collections.Generic;

namespace NoMansSky.Api
{
    /// <summary>
    /// A container for all globals files.
    /// </summary>
    public interface IGlobalsManager
    {
        /// <summary>
        /// A list of all the globals files in this class.
        /// <br/>Provided for convenience.
        /// </summary>
        public List<IGlobalsFile> AllGlobals { get; set; }

        /// <summary>
        /// Called whenever a global file gets loaded.
        /// <br/>Passes the global file that was loaded as an argument.
        /// </summary>
        public IModEvent<IGlobalsFile> OnGlobalLoaded { get; set; }

        /// <summary>
        /// Represents the AISpaceshipGlobals mbin file.
        /// <br/>The exact mbin type is GcAISpaceshipGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public IGlobalsFile AISpaceshipGlobals { get; }

        /// <summary>
        /// Represents the AtlasGlobals mbin file.
        /// <br/>The exact mbin type is GcAtlasGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public IGlobalsFile AtlasGlobals { get; }

        /// <summary>
        /// Represents the AudioGlobals mbin file.
        /// <br/>The exact mbin type is GcAudioGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public IGlobalsFile AudioGlobals { get; }

        /// <summary>
        /// Represents the BuildingGlobals mbin file.
        /// <br/>The exact mbin type is GcBuildingGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public IGlobalsFile BuildingGlobals { get; }

        /// <summary>
        /// Represents the CameraGlobals mbin file.
        /// <br/>The exact mbin type is GcCameraGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public IGlobalsFile CameraGlobals { get; }

        /// <summary>
        /// Represents the CharacterGlobals mbin file.
        /// <br/>The exact mbin type is GcCharacterGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public IGlobalsFile CharacterGlobals { get; }

        /// <summary>
        /// Represents the CreatureGlobals mbin file.
        /// <br/>The exact mbin type is GcCreatureGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public IGlobalsFile CreatureGlobals { get; }

        /// <summary>
        /// Represents the DebugOptions mbin file.
        /// <br/>The exact mbin type is GcDebugOptions.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public IGlobalsFile DebugOptions { get; }

        /// <summary>
        /// Represents the EffectsGlobals mbin file.
        /// <br/>The exact mbin type is GcEffectsGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public IGlobalsFile EffectsGlobals { get; }

        /// <summary>
        /// Represents the EnvironmentGlobals mbin file.
        /// <br/>The exact mbin type is GcEnvironmentGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public IGlobalsFile EnvironmentGlobals { get; }

        /// <summary>
        /// Represents the FleetGlobals mbin file.
        /// <br/>The exact mbin type is GcFleetGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public IGlobalsFile FleetGlobals { get; }

        /// <summary>
        /// Represents the GalaxyGlobals mbin file.
        /// <br/>The exact mbin type is GcGalaxyGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public IGlobalsFile GalaxyGlobals { get; }

        /// <summary>
        /// Represents the GameplayGlobals mbin file.
        /// <br/>The exact mbin type is GcGameplayGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public IGlobalsFile GameplayGlobals { get; }

        /// <summary>
        /// Represents the GraphicsGlobals mbin file.
        /// <br/>The exact mbin type is GcGraphicsGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public IGlobalsFile GraphicsGlobals { get; }

        /// <summary>
        /// Represents the MultiplayerGlobals mbin file.
        /// <br/>The exact mbin type is GcMultiplayerGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public IGlobalsFile MultiplayerGlobals { get; }

        /// <summary>
        /// Represents the PlacementGlobals mbin file.
        /// <br/>The exact mbin type is GcPlacementGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public IGlobalsFile PlacementGlobals { get; }

        /// <summary>
        /// Represents the PlayerGlobals mbin file.
        /// <br/>The exact mbin type is GcPlayerGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public IGlobalsFile PlayerGlobals { get; }

        /// <summary>
        /// Represents the RichPresenceGlobals mbin file.
        /// <br/>The exact mbin type is GcRichPresenceGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public IGlobalsFile RichPresenceGlobals { get; }

        /// <summary>
        /// Represents the RobotGlobals mbin file.
        /// <br/>The exact mbin type is GcRobotGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public IGlobalsFile RobotGlobals { get; }

        /// <summary>
        /// Represents the SceneOptions mbin file.
        /// <br/>The exact mbin type is GcSceneOptions.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public IGlobalsFile SceneOptions { get; }

        /// <summary>
        /// Represents the ScratchpadGlobals mbin file.
        /// <br/>The exact mbin type is GcScratchpadGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public IGlobalsFile ScratchpadGlobals { get; }

        /// <summary>
        /// Represents the SimulationGlobals mbin file.
        /// <br/>The exact mbin type is GcSimulationGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public IGlobalsFile SimulationGlobals { get; }

        /// <summary>
        /// Represents the SkyGlobals mbin file.
        /// <br/>The exact mbin type is GcSkyGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public IGlobalsFile SkyGlobals { get; }

        /// <summary>
        /// Represents the SmokeTestOptions mbin file.
        /// <br/>The exact mbin type is GcSmokeTestOptions.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public IGlobalsFile SmokeTestOptions { get; }

        /// <summary>
        /// Represents the SolarGenerationGlobals mbin file.
        /// <br/>The exact mbin type is GcSolarGenerationGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public IGlobalsFile SolarGenerationGlobals { get; }

        /// <summary>
        /// Represents the SpaceshipGlobals mbin file.
        /// <br/>The exact mbin type is GcSpaceshipGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public IGlobalsFile SpaceshipGlobals { get; }

        /// <summary>
        /// Represents the SettlementGlobals mbin file.
        /// <br/>The exact mbin type is GcSettlementGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public IGlobalsFile SettlementGlobals { get; }

        /// <summary>
        /// Represents the TerrainGlobals mbin file.
        /// <br/>The exact mbin type is GcTerrainGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public IGlobalsFile TerrainGlobals { get; }

        /// <summary>
        /// Represents the UIGlobals mbin file.
        /// <br/>The exact mbin type is GcUIGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public IGlobalsFile UIGlobals { get; }

        /// <summary>
        /// Represents the VehicleGlobals mbin file.
        /// <br/>The exact mbin type is GcVehicleGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public IGlobalsFile VehicleGlobals { get; }

        /// <summary>
        /// Represents the WaterGlobals mbin file.
        /// <br/>The exact mbin type is GcWaterGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public IGlobalsFile WaterGlobals { get; }
    }
}
