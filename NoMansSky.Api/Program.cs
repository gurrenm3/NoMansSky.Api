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

        ModLogger Logger;

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
            _modLoader.AddOrReplaceController(this, game);

            // Register this mod.
            _mod = new Mod(game, _modConfig, _hooks, _logger);
            Logger = _mod.Logger;
        }

        /*private unsafe void Test()
        {
            Signature scan = new Signature("48 8D 1D ? ? ? ? 45 33 F6 41 8B");
            long address = scan.Scan();
            int offset = *(int*)(address + 3);
            long target = (address + 7) + offset; // address + 7 = the end of LEA instruction.

            
           // var gcPlayerStatePointer = GetAddressFromOffsets(target + 0x68, 0xB8, 0x8, 0x158, 0x4A8, 0x40, 0);
            //var gcPlayerStatePointer = GetPlayerStructAddress(target);
            _logger.WriteLine($"gcPlayerStatePointer: {gcPlayerStatePointer.ToString("X")}");

            var pointer = *(long*)gcPlayerStatePointer;
            var player = (GcPlayerStateData*)pointer;
            Logger.WriteLine(player->shield);
            Logger.WriteLine(player->health);
            Logger.WriteLine(player->units);
            Logger.WriteLine(player->nanites);
            Logger.WriteLine(player->quicksilver);
            Logger.WriteLine(player->shipHealth);

            *//*var healthAddress = *(long*)gcPlayerStatePointer + 0xB4;
            var health = *(int*)healthAddress;
            Logger.WriteLine(health);*//*
        }*/

        /*private unsafe long GetPlayerStructAddress(long mbinArrayAddress)
        {
            var offset1 = mbinArrayAddress + 0x68;

            var offset2 = *(long*)offset1 + 0xB8;
            if (offset2 == 0xB8)
                return -1;

            var offset3 = *(long*)offset2 + 0x8;
            if (offset3 == 0x8)
                return -1;

            var offset4 = *(long*)offset3 + 0x158;
            if (offset4 == 0x158)
                return -1;

            var offset5 = *(long*)offset4 + 0x4A8;
            if (offset5 == 0x4A8)
                return -1;

            var offset6 = *(long*)offset5 + 0x40;
            if (offset6 == 0x40)
                return -1;

            var offset7 = *(long*)offset6 + 0x0;
            if (offset7 == 0x0)
                return -1;

            var offset8 = *(long*)offset7 + 0x0;
            if (offset8 == 0x0)
                return -1;

            return offset7;
        }*/

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
                Player = CreatePlayerInstance()
            };

            instance.Initialize();

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