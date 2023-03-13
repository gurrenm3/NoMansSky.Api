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
        /// Represents the AISpaceshipGlobals mbin file.
        /// <br/>The exact mbin type is GcAISpaceshipGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public IAISpaceshipGlobalFile AISpaceshipGlobals { get; }

        /// <summary>
        /// Represents the AtlasGlobals mbin file.
        /// <br/>The exact mbin type is GcAtlasGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public IAtlasGlobalFile AtlasGlobals { get; }

        /// <summary>
        /// Represents the AudioGlobals mbin file.
        /// <br/>The exact mbin type is GcAudioGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public IAudioGlobalFile AudioGlobals { get; }

        /// <summary>
        /// Represents the BuildingGlobals mbin file.
        /// <br/>The exact mbin type is GcBuildingGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public IBuildingGlobalFile BuildingGlobals { get; }

        /// <summary>
        /// Represents the CameraGlobals mbin file.
        /// <br/>The exact mbin type is GcCameraGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public ICameraGlobalFile CameraGlobals { get; }

        /// <summary>
        /// Represents the CharacterGlobals mbin file.
        /// <br/>The exact mbin type is GcCharacterGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public ICharacterGlobalFile CharacterGlobals { get; }

        /// <summary>
        /// Represents the CreatureGlobals mbin file.
        /// <br/>The exact mbin type is GcCreatureGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public ICreatureGlobalFile CreatureGlobals { get; }

        /// <summary>
        /// Represents the DebugOptions mbin file.
        /// <br/>The exact mbin type is GcDebugOptions.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public IDebugOptionsFile DebugOptions { get; }

        /// <summary>
        /// Represents the EffectsGlobals mbin file.
        /// <br/>The exact mbin type is GcEffectsGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public IEffectsGlobalFile EffectsGlobals { get; }

        /// <summary>
        /// Represents the EnvironmentGlobals mbin file.
        /// <br/>The exact mbin type is GcEnvironmentGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public IEnvironmentGlobalFile EnvironmentGlobals { get; }

        /// <summary>
        /// Represents the FleetGlobals mbin file.
        /// <br/>The exact mbin type is GcFleetGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public IFleetGlobalFile FleetGlobals { get; }

        /// <summary>
        /// Represents the GalaxyGlobals mbin file.
        /// <br/>The exact mbin type is GcGalaxyGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public IGalaxyGlobalFile GalaxyGlobals { get; }

        /// <summary>
        /// Represents the GameplayGlobals mbin file.
        /// <br/>The exact mbin type is GcGameplayGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public IGameplayGlobalFile GameplayGlobals { get; }

        /// <summary>
        /// Represents the GraphicsGlobals mbin file.
        /// <br/>The exact mbin type is GcGraphicsGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public IGraphicsGlobalFile GraphicsGlobals { get; }

        /// <summary>
        /// Represents the MultiplayerGlobals mbin file.
        /// <br/>The exact mbin type is GcMultiplayerGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public IMultiplayerGlobalFile MultiplayerGlobals { get; }

        /// <summary>
        /// Represents the PlacementGlobals mbin file.
        /// <br/>The exact mbin type is GcPlacementGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public IPlacementGlobalFile PlacementGlobals { get; }

        /// <summary>
        /// Represents the PlayerGlobals mbin file.
        /// <br/>The exact mbin type is GcPlayerGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public IPlayerGlobalFile PlayerGlobals { get; }

        /// <summary>
        /// Represents the RichPresenceGlobals mbin file.
        /// <br/>The exact mbin type is GcRichPresenceGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public IRichPresenceGlobalFile RichPresenceGlobals { get; }

        /// <summary>
        /// Represents the RobotGlobals mbin file.
        /// <br/>The exact mbin type is GcRobotGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public IRobotGlobalFile RobotGlobals { get; }

        /// <summary>
        /// Represents the SceneOptions mbin file.
        /// <br/>The exact mbin type is GcSceneOptions.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public ISceneOptionsFile SceneOptions { get; }

        /// <summary>
        /// Represents the ScratchpadGlobals mbin file.
        /// <br/>The exact mbin type is GcScratchpadGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public IScratchpadGlobalFile ScratchpadGlobals { get; }

        /// <summary>
        /// Represents the SimulationGlobals mbin file.
        /// <br/>The exact mbin type is GcSimulationGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public ISimulationGlobalFile SimulationGlobals { get; }

        /// <summary>
        /// Represents the SkyGlobals mbin file.
        /// <br/>The exact mbin type is GcSkyGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public ISkyGlobalFile SkyGlobals { get; }

        /// <summary>
        /// Represents the SmokeTestOptions mbin file.
        /// <br/>The exact mbin type is GcSmokeTestOptions.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public ISmokeTestOptionsFile SmokeTestOptions { get; }

        /// <summary>
        /// Represents the SolarGenerationGlobals mbin file.
        /// <br/>The exact mbin type is GcSolarGenerationGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public ISolarGenerationGlobalFile SolarGenerationGlobals { get; }

        /// <summary>
        /// Represents the SpaceshipGlobals mbin file.
        /// <br/>The exact mbin type is GcSpaceshipGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public ISpaceshipGlobalFile SpaceshipGlobals { get; }

        /// <summary>
        /// Represents the SettlementGlobals mbin file.
        /// <br/>The exact mbin type is GcSettlementGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public ISettlementGlobalFile SettlementGlobals { get; }

        /// <summary>
        /// Represents the TerrainGlobals mbin file.
        /// <br/>The exact mbin type is GcTerrainGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public ITerrainGlobalFile TerrainGlobals { get; }

        /// <summary>
        /// Represents the UIGlobals mbin file.
        /// <br/>The exact mbin type is GcUIGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public IUiGlobalFile UIGlobals { get; }

        /// <summary>
        /// Represents the VehicleGlobals mbin file.
        /// <br/>The exact mbin type is GcVehicleGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public IVehicleGlobalFile VehicleGlobals { get; }

        /// <summary>
        /// Represents the WaterGlobals mbin file.
        /// <br/>The exact mbin type is GcWaterGlobals.
        /// <br/><br/>This mbin file is located in GAMEDATA\PCBANKS
        /// </summary>
        public IWaterGlobalFile WaterGlobals { get; }
    }
}
