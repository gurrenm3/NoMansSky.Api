using NoMansSky.Api.Configuration;
using NoMansSky.Api.Configuration.Implementation;
using NoMansSky.Api.Hooks;
using Reloaded.Hooks.ReloadedII.Interfaces;
using Reloaded.Mod.Interfaces;
using Reloaded.Mod.Interfaces.Internal;
using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

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

        private List<ModAttrAttribute> loadedApiModAttributes;

        IModLogger Logger;

        /// <summary>
        /// Entry point for your mod.
        /// </summary>
        public unsafe void StartEx(IModLoaderV1 loaderApi, IModConfigV1 modConfig)
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
            

            // Register this mod.
            _mod = new Mod(game, _modConfig, _hooks, _logger);
            Logger = _mod.Logger;

            _modLoader.AddOrReplaceController(this, game);

            // Load all ModAttrAttributes from NoMansSky.Api.Lib
            ModAttributeLoader.LoadAllFromAssembly(typeof(Game).Assembly, out loadedApiModAttributes);
        }

        private Game CreateGameInstance()
        {
            Game instance = new Game()
            {
                Time = new TimeHooked(),
                OnUpdate = new SharedModEventHook(),
                OnMainMenu = new SharedModEvent(),
                OnProfileSelected = new SharedModEvent(),
                OnGameJoined = new SharedModEvent(),
                OnInventoriesOpened = new SharedModEvent(),
                OnInventoriesClosed = new SharedModEvent(),
                OnInitialized = new SharedModEvent(),
            };
            instance.Player = CreatePlayerInstance(instance);
            instance.Initialize();

            instance.Player.ActiveShip.OnHealthChanged = new SharedModEventHook<float>();
            instance.Player.ActiveShip.OnShieldChanged = new SharedModEventHook<float>();

            instance.OnInitialized.Invoke(); // invoke the initialize event as late as possible.
            return instance;
        }

        private Player CreatePlayerInstance(Game gameInstance)
        {
            Player instance = new Player();
            instance.OnBaseAddressAquired = new SharedModEvent<long>();
            instance.OnPlayerStateAquired = new SharedModEvent<long>();

            // init player stats
            instance.Health.OnValueChanged = new SharedModEventHook<int>();
            instance.Shield.OnValueChanged = new SharedModEventHook<int>();
            instance.Units.OnValueChanged = new SharedModEventHook<int>();
            instance.Nanites.OnValueChanged = new SharedModEventHook<int>();
            instance.Quicksilver.OnValueChanged = new SharedModEventHook<int>();

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