/*
 * This file and other files in the `Template` folder are intended to be left unedited (if possible),
 * to make it easier to upgrade to newer versions of the template.
*/

using NoMansSky.Api;
using NoMansSky.Api.TestMod.Configuration;
using NoMansSky.Api.TestMod.Template.Configuration;
using Reloaded.Hooks.ReloadedII.Interfaces;
using Reloaded.Mod.Interfaces;
using Reloaded.Mod.Interfaces.Internal;
using Reloaded.ModHelper;
using System.Diagnostics;

namespace NoMansSky.Api.TestMod.Template
{
    public class Startup : IMod
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
        private IReloadedHooks? _hooks;

        /// <summary>
        /// Configuration of the current mod.
        /// </summary>
        private IModConfig _modConfig = null!;

        /// <summary>
        /// Instance of the mod logger.
        /// </summary>
        private IModLogger _modLogger = null!;

        /// <summary>
        /// Instance of game class.
        /// </summary>
        private IGame _game = null!;

        /// <summary>
        /// Instance of the game loop.
        /// </summary>
        private IGameLoop _gameLoop = null!;

        /// <summary>
        /// Encapsulates your mod logic.
        /// </summary>
        private Mod _mod = null!;

        /// <summary>
        /// Entry point for your mod.
        /// </summary>
        public void StartEx(IModLoaderV1 loaderApi, IModConfigV1 modConfig)
        {
            _modLoader = (IModLoader)loaderApi;
            _modConfig = (IModConfig)modConfig;
            _logger = (ILogger)_modLoader.GetLogger();
            _modLoader.GetController<IReloadedHooks>()?.TryGetTarget(out _hooks!);

            // Your config file is in Config.json.
            // Need a different name, format or more configurations? Modify the `Configurator`.
            // If you do not want a config, remove Configuration folder and Config class.
            var configurator = new Configurator(_modLoader.GetModConfigDirectory(_modConfig.ModId));
            _configuration = configurator.GetConfiguration<Config>(0);
            _configuration.ConfigurationUpdated += OnConfigurationUpdated;

            _modLogger = new ModLogger(_modConfig, _logger);
            HookDefinitionsUtils.hooksInstance = _hooks;

            // The API publishes the instance of the Game class so mods can access it.
            // The lines below is where this mod aquires the Game instance that was published.
            _modLoader.GetController<IGame>().TryGetTarget(out _game);
            if (_game == null)
            {
                _modLogger.WriteLine("Critical Error! Failed to get the game instance from the API. Nothing will work until this is fixed.", LogLevel.Error);
                return;
            }

            _modLoader.GetController<IGameLoop>().TryGetTarget(out _gameLoop);
            if (_gameLoop == null)
            {
                _modLogger.WriteLine("Critical Error! Failed to get the game loop from the API. Nothing will work until this is fixed.", LogLevel.Error);
                return;
            }

            // Please put your mod code in the class below,
            // use this class for only interfacing with mod loader.
            _mod = new Mod(new ModContext()
            {
                Logger = _modLogger,
                Hooks = _hooks,
                ModLoader = _modLoader,
                ModConfig = _modConfig,
                Owner = this,
            })
            {
                Configuration = _configuration,
            };
        }

        private void OnConfigurationUpdated(IConfigurable obj)
        {
            /*
                This is executed when the configuration file gets 
                updated by the user at runtime.
            */

            // Replace configuration with new.
            _configuration = (Config)obj;
            _mod?.ConfigurationUpdated(_configuration);
        }

        /* Mod loader actions. */
        public void Suspend() => _mod?.Suspend();
        public void Resume() => _mod?.Resume();
        public void Unload() => _mod?.Unload();

        /*  If CanSuspend == false, suspend and resume button are disabled in Launcher and Suspend()/Resume() will never be called.
            If CanUnload == false, unload button is disabled in Launcher and Unload() will never be called.
        */
        public bool CanUnload() => _mod != null ? _mod.CanUnload() : false;
        public bool CanSuspend() => _mod != null ? _mod.CanSuspend() : false;

        /* Automatically called by the mod loader when the mod is about to be unloaded. */
        public Action Disposing => () => _mod?.Disposing();
    }
}