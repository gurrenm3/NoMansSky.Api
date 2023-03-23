using NativeGenericDelegates;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NoMansSky.Api.Hooks;
using NoMansSky.Api.Hooks.Game;
using NoMansSky.Api.libMBIN.Globals;
using Reloaded.Hooks.Definitions.Structs;
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
using static NoMansSky.Api.Hooks.Game.cGcApplication_GetGameState;
using Random = Reloaded.ModHelper.Random;
using IReloadedHooks = Reloaded.Hooks.ReloadedII.Interfaces.IReloadedHooks;
using Reloaded.Hooks.Definitions;
using NoMansSky.Api.libMBIN;
using System.Windows.Automation.Peers;

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

        [NMSHook<GcPlayerState.awardUnits>(RunHook.Before)]
        public static void MyBeforeHook(long self, ref int Change)
        {
            Change = 999999;
        }

        //[NMSHook<GcPlayerState.awardUnits>(RunHook.After)]
        public static void MyAfterHook(long self, int liChange, ref uint __result)
        {
            //var ptr = (GcPlayerState*)self;
            Instance.Logger.WriteLine("HOLY SHIT IT WORKED AGAIN!!!!!!!!!!");
            __result = 69696969;
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
                
                var playerOffset = 0x20;
                var playerPtr = cGcApplication_GetGameState.GcGameStatePtr + playerOffset;
                Logger.WriteLine($"PlayerPtr: {playerPtr.ToString("X")}");
                var player = (GcPlayerState*)playerPtr;
                player->AwardUnits(10);
            }
            if (Keyboard.IsPressed(Key.LeftArrow))
            {
                /*var hook = GcPlayerState.HookDefinitions.awardUnitsFuncDef.Hook((a, b) =>
                {
                    Logger.WriteLine("ZZZZ THe hook is running ZZZ");
                    return hook.OriginalFunction(a, b);
                });*/
            }
            if (Keyboard.IsPressed(Key.DownArrow))
            {
                var hook = GcPlayerState.GetOrAddHook<GcPlayerState.awardUnits>();
                /*hook.Before.AddRunner(args =>
                {
                    Logger.WriteLine($"About to gain {args[1]} units! Adding 1 more!");

                    var amountToAdd = (int)args[1];
                    args[1] = amountToAdd + 1;
                });*/

                hook.After.AddRunner(args =>
                {
                    args[2] = 69696969;
                    //Logger.WriteLine($"You now have {args[2]} units!");
                });
            }
        }


#endif

        internal static void WriteLine(object message, LogLevel logLevel = LogLevel.Normal) => WriteLine(message?.ToString(), logLevel);

        internal static void WriteLine(string message, LogLevel logLevel = LogLevel.Normal)
        {
            Instance.Logger.WriteLine(message, logLevel);
        }
    }
}