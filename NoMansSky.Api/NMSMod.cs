using Newtonsoft.Json;
using Reloaded.Hooks.Definitions;
using Reloaded.Mod.Interfaces;
using Reloaded.ModHelper;
using System;

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
        public IGameLoop GameLoop => Game?.GameLoop;

        /// <summary>
        /// Represents the instance of the Player class.
        /// </summary>
        public IPlayer Player => Game?.Player;

        /// <summary>
        /// Represents the player's exosuit.
        /// </summary>
        public IExosuit Exosuit => Player?.Exosuit;

        /// <summary>
        /// Represents the player's current ship.
        /// </summary>
        public IShip ActiveShip => Player?.Ship;

        /// <summary>
        /// Represents the player's current multitool.
        /// </summary>
        public IMultiTool ActiveMultiTool => Player?.ActiveMultiTool;

        /// <summary>
        /// Creates an instance of this class.
        /// </summary>
        public NMSMod(IModConfig _config, IReloadedHooks _hooks, IModLogger _logger, bool autoInitialize = true) : base(_config, _hooks, _logger, autoInitialize)
        {
            GameLoop.OnUpdate.Postfix += Update;
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
        }

        /// <summary>
        /// Called once every time the game loop runs.
        /// <br/>This will run in the PostFix of the Game loop.
        /// </summary>
        public virtual void Update() { }
    }
}