using NoMansSky.Api.Configuration;
using NoMansSky.Api.Configuration.Implementation;
using Reloaded.Hooks.ReloadedII.Interfaces;
using Reloaded.Mod.Interfaces;
using Reloaded.Mod.Interfaces.Internal;
using Reloaded.ModHelper;
using System;

#if DEBUG
using System.Diagnostics;
#endif

namespace NoMansSky.Api
{
    public class Program : IMod, IExports
    {
        /// <summary>
        /// Used for writing text to the Reloaded log.
        /// </summary>
        private ILogger _logger = null!;

        /// <summary>
        /// Provides access to the mod loader API.
        /// </summary>
        private IModLoader _modLoader = null!;

        /// <summary>
        /// Stores the contents of your mod's configuration. Automatically updated by template.
        /// </summary>
        private Config _configuration = null!;

        /// <summary>
        /// An interface to Reloaded's the function hooks/detours library.
        /// See: https://github.com/Reloaded-Project/Reloaded.Hooks
        ///      for documentation and samples. 
        /// </summary>
        private IReloadedHooks _hooks = null!;

        /// <summary>
        /// Configuration of the current mod.
        /// </summary>
        private IModConfig _modConfig = null!;

        /// <summary>
        /// Encapsulates your mod logic.
        /// </summary>
        private Mod _mod = null!;

        private IGameLoop gameLoop;

        /// <summary>
        /// Entry point for your mod.
        /// </summary>
        public void StartEx(IModLoaderV1 loaderApi, IModConfigV1 modConfig)
        {
#if DEBUG
        // Attaches debugger in debug mode; ignored in release.
        Debugger.Launch();
#endif

            _modLoader = (IModLoader)loaderApi;
            _modConfig = (IModConfig)modConfig;
            _logger = (ILogger)_modLoader.GetLogger();
            _modLoader.GetController<IReloadedHooks>().TryGetTarget(out _hooks!);

            // Your config file is in Config.json.
            // Need a different name, format or more configurations? Modify the `Configurator`.
            // If you do not want a config, remove Configuration folder and Config class.
            var configurator = new Configurator(_modLoader.GetModConfigDirectory(_modConfig.ModId));
            _configuration = configurator.GetConfiguration<Config>(0);
            _configuration.ConfigurationUpdated += OnConfigurationUpdated;

            /*
                Your mod code starts below.
                Visit https://github.com/Reloaded-Project for additional optional libraries.
            */

            var game = CreateGameInstance();
            _modLoader.AddOrReplaceController(this, game);

            gameLoop = PseudoGameLoop.CreateNew(isSharedInstance: true).Initialize();
            _modLoader.AddOrReplaceController(this, gameLoop);

            game.GameLoop = gameLoop;

            // Register this mod.
            _mod = new Mod(game, _modConfig, _hooks, _logger);
        }

        private Game CreateGameInstance()
        {
            Game instance = new Game();
            instance.OnProfileSelected = new SharedModEvent();
            instance.OnMainMenu = new SharedModEvent();
            instance.Player = CreatePlayerInstance();

            return instance;
        }

        private Player CreatePlayerInstance()
        {
            Player instance = new Player();
            instance.OnHealthChanged = new SharedModEventHook<int>();
            instance.OnShieldChanged = new SharedModEventHook<float>();
            instance.CurrentShip.OnHealthChanged = new SharedModEventHook<float>();
            instance.CurrentShip.OnShieldChanged = new SharedModEventHook<float>();

            return instance;
        }

        private void OnConfigurationUpdated(IConfigurable obj)
        {
            /*
                This is executed when the configuration file gets 
                updated by the user at runtime.
            */

            // Replace configuration with new.
            _configuration = (Config)obj;
            _logger.WriteLine($"[{_modConfig.ModId}] Config Updated: Applying");

            // Apply settings from configuration.
            // ... your code here.
        }



        /* Automatically called by the mod loader when the mod is about to be unloaded. */
        public Action Disposing { get; } = null!;

        public Type[] GetTypes() => new Type[] { typeof(Game), typeof(IGameLoop) };

        public bool CanUnload() => false;
        public bool CanSuspend() => false;
        public void Suspend() { }
        public void Resume() { }
        public void Unload() { }
    }
}