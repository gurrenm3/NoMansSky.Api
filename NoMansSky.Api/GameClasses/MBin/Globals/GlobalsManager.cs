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
        public List<IGlobalsFile> AllGlobals { get; set; } = new List<IGlobalsFile>();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IModEvent<IGlobalsFile> OnGlobalLoaded { get; set; } = new SharedModEvent<IGlobalsFile>();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IGlobalsFile AISpaceshipGlobals { get; private set; } = new GlobalsFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IGlobalsFile AtlasGlobals { get; private set; } = new GlobalsFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IGlobalsFile AudioGlobals { get; private set; } = new GlobalsFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IGlobalsFile BuildingGlobals { get; private set; } = new GlobalsFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IGlobalsFile CameraGlobals { get; private set; } = new GlobalsFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IGlobalsFile CharacterGlobals { get; private set; } = new GlobalsFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IGlobalsFile CreatureGlobals { get; private set; } = new GlobalsFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IGlobalsFile DebugOptions { get; private set; } = new GlobalsFile();

        /// <summary>
        /// Represents the EffectsGlobals mbin file.
        /// </summary>
        public IGlobalsFile EffectsGlobals { get; } = new GlobalsFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IGlobalsFile EnvironmentGlobals { get; private set; } = new GlobalsFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IGlobalsFile FleetGlobals { get; private set; } = new GlobalsFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IGlobalsFile GalaxyGlobals { get; private set; } = new GlobalsFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IGlobalsFile GameplayGlobals { get; private set; } = new GlobalsFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IGlobalsFile GraphicsGlobals { get; private set; } = new GlobalsFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IGlobalsFile MultiplayerGlobals { get; private set; } = new GlobalsFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IGlobalsFile PlacementGlobals { get; private set; } = new GlobalsFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IGlobalsFile PlayerGlobals { get; private set; } = new GlobalsFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IGlobalsFile RichPresenceGlobals { get; private set; } = new GlobalsFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IGlobalsFile RobotGlobals { get; private set; } = new GlobalsFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IGlobalsFile SceneOptions { get; private set; } = new GlobalsFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IGlobalsFile ScratchpadGlobals { get; private set; } = new GlobalsFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IGlobalsFile SimulationGlobals { get; private set; } = new GlobalsFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IGlobalsFile SkyGlobals { get; private set; } = new GlobalsFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IGlobalsFile SmokeTestOptions { get; private set; } = new GlobalsFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IGlobalsFile SolarGenerationGlobals { get; private set; } = new GlobalsFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IGlobalsFile SpaceshipGlobals { get; private set; } = new GlobalsFile();

        /// <summary>
        /// Represents the SettlementGlobals mbin file.
        /// </summary>
        public IGlobalsFile SettlementGlobals { get; } = new GlobalsFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IGlobalsFile TerrainGlobals { get; private set; } = new GlobalsFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IGlobalsFile UIGlobals { get; private set; } = new GlobalsFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IGlobalsFile VehicleGlobals { get; private set; } = new GlobalsFile();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public IGlobalsFile WaterGlobals { get; private set; } = new GlobalsFile();

        private Dictionary<string, IGlobalsFile> globals = new Dictionary<string, IGlobalsFile>();

        public GlobalsManager()
        {
            var properties = GetType().GetProperties();
            foreach (var property in properties)
            {
                if (!property.PropertyType.IsAssignableTo(typeof(IGlobalsFile)))
                    continue;

                var actualProperty = (IGlobalsFile)property.GetValue(this);
                globals.Add(property.Name, actualProperty);
            }


            IGame.Instance.MBinManager.OnMBinLoaded.AddListener(mbin =>
            {
                if (!mbin.IsGlobalMbin())
                    return;

                var global = globals.FirstOrDefault(global => mbin.Name.Contains(global.Key));
                if (global.Value != null)
                {
                    var globalFile = global.Value;

                    AllGlobals.Add(globalFile);
                    globalFile.MBin = mbin;
                    globalFile.OnLoaded.Invoke();
                    OnGlobalLoaded.Invoke(globalFile);
                }
                else
                {
                    ConsoleUtil.LogError($"Critical Error! Failed to load the {mbin.Name} Global MBin!!");
                }
            });
        }
    }
}
