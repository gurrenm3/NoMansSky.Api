using Reloaded.Hooks.Definitions;
using Reloaded.Mod.Interfaces;
using Reloaded.ModHelper;
using System;
using System.IO;
using System.Threading.Tasks;

namespace NoMansSky.Api
{
    /// <summary>
    /// A base class for No Man's Sky mods.
    /// </summary>
    public class NMSMod : ReloadedMod
    {
        /// <summary>
        /// The location of the "Binaries" folder for No Mans Sky.
        /// </summary>
        public string BinariesDirectory => _binariesDirectory;
        private string _binariesDirectory;

        /// <summary>
        /// The location of the "GAMEDATA" folder for No Mans Sky.
        /// </summary>
        public string GameDataDirectory => _gameDataDirectory;
        private string _gameDataDirectory;

        /// <summary>
        /// The main directory for No Mans Sky.
        /// </summary>
        public string NmsDirectory => _nmsDirectory;
        private string _nmsDirectory;

        /// <summary>
        /// The location of the "Mods" folder used by all mods made with this API.
        /// <br/>Note: this is not the same mods folder that MBIN mods use.
        /// </summary>
        public string ModsFolder => _modsFolder;
        private string _modsFolder;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public override string MyModFolder => _myModFolder;
        private string _myModFolder;

        /// <summary>
        /// Represents the instance of the Game class.
        /// </summary>
        public IGame Game => IGame.Instance;

        /// <summary>
        /// Represents the instance of the Game Loop.
        /// </summary>
        public IGameLoop GameLoop => Game?.GameLoop!;

        /// <summary>
        /// A shortcut for accsessing the Globals files.
        /// </summary>
        public IGlobalsManager Globals => Game?.Globals!;

        /// <summary>
        /// Represents the Galaxy Map.
        /// </summary>
        public IGalaxyMap GalaxyMap => Game?.GalaxyMap!;

        /// <summary>
        /// Represents the current solar system.
        /// </summary>
        public ISolarSystem CurrentSystem => Game?.CurrentSystem!;

        /// <summary>
        /// A shortcut for accsessing the MBinManager.
        /// </summary>
        public IMBinManager MBinManager => Game?.MBinManager!;

        /// <summary>
        /// Represents the instance of the Player class.
        /// </summary>
        public IPlayer Player => Game?.Player!;

        /// <summary>
        /// Represents the player's exosuit.
        /// </summary>
        public IExosuit Exosuit => Player?.Exosuit!;

        /// <summary>
        /// Represents the player's current ship.
        /// </summary>
        public IShip ActiveShip => Player?.Ship!;

        /// <summary>
        /// Represents the player's current multitool.
        /// </summary>
        public IMultiTool ActiveMultiTool => Player?.ActiveMultiTool!;

        /// <summary>
        /// Instance of the memory manager. 
        /// </summary>
        protected readonly MemoryManager memory;

        /// <summary>
        /// Creates an instance of this class.
        /// </summary>
        public NMSMod(IModConfig _config, IReloadedHooks _hooks, IModLogger _logger, bool autoInitialize = true) : base(_config, _hooks, _logger, autoInitialize)
        {
            GameLoop.OnUpdate.Postfix += Update;
            GameLoop.OnUpdate.Postfix += () => Update(GameLoop.Time.DeltaTime);
            Game.MBinManager.OnMBinLoaded += OnMBinLoaded;
            Game.OnGameJoined += OnGameJoined;

            memory = new MemoryManager();
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        protected override void Awake()
        {
            base.Awake();

            _binariesDirectory = Environment.CurrentDirectory;
            _nmsDirectory = $"{_binariesDirectory.Replace("\\Binaries", "")}";
            _gameDataDirectory = $"{_nmsDirectory}\\GAMEDATA";
            _modsFolder = $"{_gameDataDirectory}\\MODS";
            _myModFolder = $"{_modsFolder}\\{ModConfig.ModName}";

            Directory.CreateDirectory(_myModFolder);
        }

        /// <summary>
        /// Called once every time the game loop runs.
        /// <br/>This will run in the PostFix of the Game loop.
        /// <br/>Gives extra convenience by providing deltaTime. Will run before the other Update method.
        /// </summary>
        /// <param name="deltaTime"></param>
        public virtual void Update(double deltaTime) { }

        /// <summary>
        /// Called once every time the game loop runs.
        /// <br/>This will run in the PostFix of the Game loop.
        /// <br/>Will run after the Update method that provides DeltaTime.
        /// </summary>
        public virtual void Update() { }


        /// <summary>
        /// Called everytime an mbin gets loaded/registered by the API. Will only work with
        /// currently supported MBINs.
        /// </summary>
        /// <param name="loadedMbin"></param>
        public virtual void OnMBinLoaded(IMBin loadedMbin) { }

        /// <summary>
        /// Called when the main menu is reached.
        /// </summary>
        public virtual void OnMainMenu() { }

        /// <summary>
        /// Called when the player loads into the game after selecting a save file.
        /// </summary>
        public virtual void OnGameJoined() { }


        /// <summary>
        /// A shortcut for MemoryManager.SetValue. 
        /// <br/>Sets a value in memory at the provided path. Path must be the full location of the object you want
        /// to set, separated by periods. Works on nested objects. 
        /// <br/>Example Path: "GcPlayerGlobals.GroundRunSpeed"
        /// </summary>
        /// <param name="pathToValue">The full path to the object you want to set, separated by periods.</param>
        /// <param name="valueToSet">The value to be assigned to the provided path.</param>
        protected void SetValue(string pathToValue, object valueToSet) => memory.SetValue(pathToValue, valueToSet);

        /// <summary>
        /// A shortcut for MemoryManager.SetValue. 
        /// </summary>
        /// <param name="address"></param>
        /// <param name="valueToSet"></param>
        protected void SetValue(long address, object valueToSet) => memory.SetValue(address, valueToSet);

        /// <summary>
        /// A shortcut for MemoryManager.SetValueAsync.
        /// <br/>Sets a value in memory at the provided path. Path must be the full location of the object you want
        /// to set, separated by periods. Works on nested objects.
        /// <br/>Example Path: "GcPlayerGlobals.GroundRunSpeed"
        /// 
        /// <br/><br/>Runs on a separate thread and returns when it's done.
        /// It's recommended that you use this for bigger objects so you don't lock the game while
        /// the value is being set.
        /// <br/>Note: Since this runs on a separate thread it will not be synced with game loop.
        /// </summary>
        /// <param name="pathToValue"></param>
        /// <param name="valueToSet"></param>
        /// <returns></returns>
        protected async Task SetValueAsync(string pathToValue, object valueToSet) => await memory.SetValueAsync(pathToValue, valueToSet);

        /// <summary>
        /// A shortcut for MemoryManager.SetValueAsync.
        /// <br/>Sets an object in memory at the provided address on a separate thread and returns when its done.
        /// Use this for big objects so you don't lock the game.
        /// </summary>
        /// <param name="address"></param>
        /// <param name="valueToSet"></param>
        /// <returns></returns>
        protected async Task SetValueAsync(long address, object valueToSet) => await memory.SetValueAsync(address, valueToSet);

        /// <summary>
        /// A shortcut for MemoryManager.GetValue.
        /// <br/>Returns the value that is stored in memory at the provided path. Path must be the full location 
        /// of the object you want to get, separated by periods. Works on nested objects.
        /// <br/><br/>Example Path: "GcPlayerGlobals.GroundRunSpeed"
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pathToValue">The full path to the object you want to set, separated by periods.</param>
        /// <returns></returns>
        protected T GetValue<T>(string pathToValue) => memory.GetValue<T>(pathToValue);

        /// <summary>
        /// A shortcut for MemoryManager.GetValue.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="address"></param>
        /// <returns></returns>
        protected T GetValue<T>(long address) => memory.GetValue<T>(address);

        /// <summary>
        /// A shortcut for MemoryManager.GetValueAsync.
        /// <br/>Reads an object in memory on a separate thread and returns when its done.
        /// Use this for big objects so you don't lock the game.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="address"></param>
        /// <returns></returns>
        protected async Task<T> GetValueAsync<T>(long address) => await memory.GetValueAsync<T>(address);

        /// <summary>
        /// A shortcut for MemoryManager.GetValueAsync.
        /// <br/>Returns the value that is stored in memory at the provided path. Path must be the full location 
        /// of the object you want to get, separated by periods. Works on nested objects.
        /// <br/>Example Path: "GcPlayerGlobals.GroundRunSpeed"
        /// 
        /// <br/><br/>Runs on a separate thread and returns when it's done.
        /// It's recommended that you use this for bigger objects so you don't lock the game while
        /// the value is being retrieved.
        /// <br/>Note: Since this runs on a separate thread it will not be synced with game loop.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pathToValue"></param>
        /// <returns></returns>
        protected async Task<T> GetValueAsync<T>(string pathToValue) => await memory.GetValueAsync<T>(pathToValue);

    }
}