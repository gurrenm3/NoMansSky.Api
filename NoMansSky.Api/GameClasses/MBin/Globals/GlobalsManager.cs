using Reloaded.ModHelper;
using System.Collections.Generic;
using System.Linq;

namespace NoMansSky.Api
{
    /// <summary>
    /// A container for all globals files.
    /// </summary>
    internal class GlobalsManager : IGlobalsManager
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IAISpaceshipGlobalFile AISpaceshipGlobals { get; private set; } = new AISpaceshipGlobalFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IAtlasGlobalFile AtlasGlobals { get; private set; } = new AtlasGlobalFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IAudioGlobalFile AudioGlobals { get; private set; } = new AudioGlobalFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IBuildingGlobalFile BuildingGlobals { get; private set; } = new BuildingGlobalFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public ICameraGlobalFile CameraGlobals { get; private set; } = new CameraGlobalFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public ICharacterGlobalFile CharacterGlobals { get; private set; } = new CharacterGlobalFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public ICreatureGlobalFile CreatureGlobals { get; private set; } = new CreatureGlobalFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IDebugOptionsFile DebugOptions { get; private set; } = new DebugOptionsFile();

        /// <summary>
        /// Represents the EffectsGlobals mbin file.
        /// </summary>
        public IEffectsGlobalFile EffectsGlobals { get; } = new EffectsGlobalFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IEnvironmentGlobalFile EnvironmentGlobals { get; private set; } = new EnvironmentGlobalFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IFleetGlobalFile FleetGlobals { get; private set; } = new FleetGlobalFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IGalaxyGlobalFile GalaxyGlobals { get; private set; } = new GalaxyGlobalFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IGameplayGlobalFile GameplayGlobals { get; private set; } = new GameplayGlobalFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IGraphicsGlobalFile GraphicsGlobals { get; private set; } = new GraphicsGlobalFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IMultiplayerGlobalFile MultiplayerGlobals { get; private set; } = new MultiplayerGlobalFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IPlacementGlobalFile PlacementGlobals { get; private set; } = new PlacementGlobalFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IPlayerGlobalFile PlayerGlobals { get; private set; } = new PlayerGlobalFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IRichPresenceGlobalFile RichPresenceGlobals { get; private set; } = new RichPresenceGlobalFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IRobotGlobalFile RobotGlobals { get; private set; } = new RobotGlobalFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public ISceneOptionsFile SceneOptions { get; private set; } = new SceneOptionsFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IScratchpadGlobalFile ScratchpadGlobals { get; private set; } = new ScratchpadGlobalFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public ISimulationGlobalFile SimulationGlobals { get; private set; } = new SimulationGlobalFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public ISkyGlobalFile SkyGlobals { get; private set; } = new SkyGlobalFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public ISmokeTestOptionsFile SmokeTestOptions { get; private set; } = new SmokeTestOptionsFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public ISolarGenerationGlobalFile SolarGenerationGlobals { get; private set; } = new SolarGenerationGlobalFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public ISpaceshipGlobalFile SpaceshipGlobals { get; private set; } = new SpaceshipGlobalFile();

        /// <summary>
        /// Represents the SettlementGlobals mbin file.
        /// </summary>
        public ISettlementGlobalFile SettlementGlobals { get; } = new SettlementGlobalFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public ITerrainGlobalFile TerrainGlobals { get; private set; } = new TerrainGlobalFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IUiGlobalFile UIGlobals { get; private set; } = new UiGlobalFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IVehicleGlobalFile VehicleGlobals { get; private set; } = new VehicleGlobalFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IWaterGlobalFile WaterGlobals { get; private set; } = new WaterGlobalFile();

        private Dictionary<string, IMBinWrapper> globals = new Dictionary<string, IMBinWrapper>();

        public GlobalsManager()
        {
            var properties = GetType().GetProperties();
            foreach (var property in properties)
            {
                if (!property.PropertyType.IsAssignableTo(typeof(IMBinWrapper)))
                    continue;

                var actualProperty = (IMBinWrapper)property.GetValue(this);
                globals.Add(property.Name.ToUpper(), actualProperty);
            }


            IGame.Instance.MBinManager.OnMBinLoaded.AddListener(mbin =>
            {
                if (!mbin.IsGlobalMbin())
                    return;

                var global = globals.FirstOrDefault(global => mbin.Name.Contains(global.Key));
                if (global.Value == null)
                {
                    Mod.WriteLine($"{mbin.Name} doesn't have it's own wrapper. You'll need to use MBinManager to access it until a wrapper is created.", LogLevel.Warning);
                    return;
                }

                var globalFile = global.Value;

                globalFile.MBin = mbin;
                globalFile.OnLoaded.Invoke();
            });
        }
    }
}
