using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NoMansSky.Api.Hooks;
using NoMansSky.Api.libMBIN.Globals;
using Reloaded.Hooks.ReloadedII.Interfaces;
using Reloaded.Mod.Interfaces;
using Reloaded.ModHelper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml;
using Random = Reloaded.ModHelper.Random;

namespace NoMansSky.Api
{
    /// <summary>
    /// Your mod logic goes here.
    /// </summary>
    public unsafe class Mod : NMSMod
    {
        /// <summary>
        /// Used for logging messages within the api. Not necessary for your mods.
        /// </summary>
        internal static Mod Instance { get; private set; }


        public Mod(IModConfig _config, IReloadedHooks _hooks, IModLogger _logger) : base(_config, _hooks, _logger)
        {
            Game.ModsWarning.Disable();
            (MBinManager as MBinManager)?.LoadPakFiles($"{GameDataDirectory}\\PCBANKS");

#if DEBUG

#endif
        }

        [NMSHook<Mod>("AwardUnits", RunHook.Before)]
        public static void MyBeforeHook(int unitsToAdd)
        {

        }

        protected override void Awake()
        {
            base.Awake();
            Instance = this;
        }

#if DEBUG


        public override void Update()
        {
            /*if (!Game.IsInGame)
                return;*/

            if (Keyboard.IsPressed(Key.UpArrow))
            {
                //long addUnitsAddress = 0x1403CF8E0;

                IModEvent<int> test = new ModEvent<int>();

                int var = 0;

                test.AddRunner(Test);
                test.Run(ref var);



                Logger.WriteLine(var);
            }
            if (Keyboard.IsPressed(Key.LeftArrow))
            {
                
            }
            if (Keyboard.IsPressed(Key.DownArrow))
            {
                
            }
        }

        private void Test(ref int a1)
        {
            a1 = 100;
        }

#endif

        internal static void WriteLine(object message, LogLevel logLevel = LogLevel.Normal) => WriteLine(message?.ToString(), logLevel);

        internal static void WriteLine(string message, LogLevel logLevel = LogLevel.Normal)
        {
            Instance.Logger.WriteLine(message, logLevel);
        }
    }
}