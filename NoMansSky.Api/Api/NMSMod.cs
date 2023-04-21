using Reloaded.Mod.Interfaces;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

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
        public string BinariesDirectory => Game?.BinariesDirectory;

        /// <summary>
        /// The location of the "GAMEDATA" folder for No Mans Sky.
        /// </summary>
        public string GameDataDirectory => Game?.GameDataDirectory;

        /// <summary>
        /// The main directory for No Mans Sky.
        /// </summary>
        public string NMSDirectory => Game?.NMSDirectory;

        /// <summary>
        /// The location of the "Mods" folder used by all mods made with this API.
        /// <br/>Note: this is not the same mods folder that traditional MBIN mods use.
        /// </summary>
        public string ModsDirectory => Game?.ModsDirectory;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public override string MyModDirectory => _myModFolder;
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
        /// A shortcut for accsessing the MBinManager.
        /// </summary>
        public IMBinManager MBinManager => Game?.MBinManager!;

        /// <summary>
        /// Represents the instance of the Player class.
        /// </summary>
        public IPlayer Player => Game?.Player!;

        /// <summary>
        /// Contains all of the hooks using NMSHookAttribute.
        /// </summary>
        public List<INMSHook> NMSHooks { get; private set; }

        /// <summary>
        /// Creates an instance of this class.
        /// </summary>
        public NMSMod(ModContext context) : base(context)
        {
            GameLoop.OnUpdate.After += () => Update(GameLoop.Time.DeltaTime);
            GameLoop.OnUpdate.After += Update;
        }

        /// <summary>
        /// Creates an instance of this class.
        /// </summary>
        /*public NMSMod(IModConfig _config, IReloadedHooks _hooks, IModLogger _logger, bool autoInitialize = true) : base(_config, _hooks, _logger, autoInitialize)
        {
            GameLoop.OnUpdate.After += Update;
            GameLoop.OnUpdate.After += () => Update(GameLoop.Time.DeltaTime);
        }*/

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        protected override void Awake()
        {
            base.Awake();
            _myModFolder = $"{ModsDirectory}\\{ModConfig.ModName}";
            Directory.CreateDirectory(_myModFolder);
        }

        protected override void OnInitialized()
        {
            NMSHooks = LoadedModAttributes.FindAll(attr => attr is INMSHook).Cast<INMSHook>().ToList();
            base.OnInitialized();
        }

        protected override string GetRegisterHooksMessage()
        {
            int totalHooks = LoadedHooks.Count + NMSHooks.FindAll(hook => hook.IsSuccessfullyLoaded).Count; 
            if (totalHooks == 0)
                return "No new hooks were registered by this mod.";

            return $"Successfully registered {(totalHooks == 1 ? "1 hook" : $"{totalHooks} hooks")} found in this mod.";
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


        #region For Exports, Serialization etc.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public NMSMod() { }
#pragma warning restore CS8618
        #endregion
    }
}