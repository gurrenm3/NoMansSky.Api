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
        private IMemoryManager memoryMgr = null!;

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

            // memory manager stuff
            memoryMgr = new MemoryManager();
            memoryMgr.AddConverter(new NMSStringConverter(memoryMgr), alwaysRegister: true);
            memoryMgr.AddConverter(new ArrayConverter(memoryMgr), alwaysRegister: true);
            memoryMgr.AddConverter(new ListConverter(memoryMgr), alwaysRegister: true);
            //memoryMgr.AddConverter(new ThreadedNMSTemplateConverter(memoryMgr), alwaysRegister: true);
            memoryMgr.AddConverter(new NMSTemplateConverter(memoryMgr), alwaysRegister: true);




            gameInstance = new Game(Logger);
            gameLoop = gameInstance.GameLoop;

            _modLoader.AddOrReplaceController(this, gameInstance);
            _modLoader.AddOrReplaceController(this, gameLoop);

            _mod = new Mod(_modConfig, _hooks, Logger);

            // Load all ModAttrAttributes from NoMansSky.Api.Lib
            ModAttributeLoader.LoadAllFromAssembly(typeof(IGame).Assembly, out loadedApiModAttributes);
        }


        /* Automatically called by the mod loader when the mod is about to be unloaded. */
        public Action Disposing { get; } = null!;

        public Type[] GetTypes() => new Type[] { typeof(IGame), typeof(IGameLoop) };

        public bool CanUnload() => false;
        public bool CanSuspend() => false;
        public void Suspend() { }
        public void Resume() { }
        public void Unload() { }
    }
}