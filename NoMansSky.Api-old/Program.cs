using libMBIN;
using NoMansSky.Api.Definitions;
using Reloaded.Hooks.ReloadedII.Interfaces;
using Reloaded.Mod.Interfaces;
using Reloaded.Mod.Interfaces.Internal;
using System.Collections.Generic;
using IReloadedHooks = Reloaded.Hooks.ReloadedII.Interfaces.IReloadedHooks;

#if DEBUG
using System.Diagnostics;
#endif

namespace NoMansSky.Api
{
    /// <summary>
    /// Entry point for reloaded mods.
    /// </summary>
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

        private IModLogger Logger = null!;

        private IGame gameInstance = null!;
        private IGameLoop gameLoop = null!;

        /// <summary>
        /// This is needed to sync the instances of libmbin between API and mods.
        /// </summary>
        private NMSTemplate libmbinInstance;

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

            /*
                Your mod code starts below.
                Visit https://github.com/Reloaded-Project for additional optional libraries.
            */


            Logger = new ModLogger(_modConfig, _logger);
            IModLogger.Instance = Logger;

            // memory manager stuff


            // publish controllers to sync mods.
            libmbinInstance = new NMSTemplate();
            gameInstance = new Game(Logger);
            gameLoop = gameInstance.GameLoop;
            HookDefinitionsUtils.hooksInstance = _hooks;

            _modLoader.AddOrReplaceController(this, libmbinInstance);
            _modLoader.AddOrReplaceController(this, gameInstance);
            _modLoader.AddOrReplaceController(this, gameLoop);

            //_mod = new Mod(_modConfig, _hooks, Logger);
            _mod = new Mod(new ModContext()
            {
                Hooks = _hooks,
                Logger = Logger,
                ModConfig = _modConfig,
                ModLoader = _modLoader,
                Owner = this
            });

            // Load all ModAttrAttributes from NoMansSky.Api.Shared
            ModAttributeLoader.LoadAllFromAssembly(typeof(IGame).Assembly, out loadedApiModAttributes);
        }


        /* Automatically called by the mod loader when the mod is about to be unloaded. */
        public Action Disposing { get; } = null!;

        public Type[] GetTypes() => new Type[] { typeof(IGame), typeof(IGameLoop), typeof(NMSTemplate), };//typeof(Class1) };

        public bool CanUnload() => false;
        public bool CanSuspend() => false;
        public void Suspend() { }
        public void Resume() { }
        public void Unload() { }
    }
}