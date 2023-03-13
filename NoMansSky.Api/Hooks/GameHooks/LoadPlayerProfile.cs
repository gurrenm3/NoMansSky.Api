using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System;
using System.Net;
using System.Runtime.InteropServices;

namespace NoMansSky.Api.Hooks
{
    internal unsafe class LoadPlayerProfile : IModHook
    {
        #region Hook stuff

        [Function(CallingConventions.Microsoft)]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate long HookDelegate(long a1);
        public static IFunction<HookDelegate> Function { get; set; }
        public static IHook<HookDelegate> Hook;

        #endregion


        /// <summary>
        /// ModEvent that's called when the original function is called.
        /// </summary>
        public static IModEvent<long> ModEvent { get; set; } = new SharedModEvent<long>();
        internal static bool isLoadingProfile = false;
        public string HookName => "OnPlayerProfileLoaded";
        private IModLogger logger;

        private bool firstRun = true;
        
        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;
            //debug = new DebugLogger(logger);

            logger.WriteLine($"Running LoadPlayerProfile hook");


            string pattern = "40 55 56 57 41 56 41 57 48 8D 6C 24 ? 48 81 EC ? ? ? ? 48 C7 45 ? ? ? ? ? 48 89 9C 24 ? ? ? ? 48 8B F1 45";
            var address = new Signature(pattern).Scan();
            Function = _hooks.CreateFunction<HookDelegate>(address);
            logger.WriteLine("LoadPlayerProfile is temporarily disabled...");
            //Hook = Function.Hook(CodeToExecute).Activate();





            /*var playerStateFunction = new Signature("4C 8B FA 4C 8B F1 48 8D 0D ? ? ? ? E8 ? ? ? ? 48 8D 95 ? ? ? ? ").Scan() + 14; // it's 14 bytes to the function

            var bitReader = new ByteReader(EndianType.Little);
            var functionBytes = bitReader.ReadBytes(playerStateFunction, 4);
            var functionOffset = BitConverter.ToInt32(functionBytes);
            var playerStateFuncAddr = playerStateFunction + functionOffset + 4;

            Function = _hooks.CreateFunction<HookDelegate>(playerStateFuncAddr);
            Hook = Function.Hook(CodeToExecute).Activate();*/






            /*string pattern = "40 55 56 57 41 56 41 57 48 8D 6C 24 ? 48 81 EC ? ? ? ? 48 C7 45 ? ? ? ? ? 48 89 9C 24 ? ? ? ? 48 8B F1 45";

            debug.WriteLine("Scanning for function signature");
            var address = new Signature(pattern).Scan();

            debug.WriteLine("Creating Function from signature");
            Function = _hooks.CreateFunction<HookDelegate>(address);

            debug.WriteLine("Creating Hook from Function.");
            Hook = Function.Hook(CodeToExecute).Activate();

            debug.WriteLine("Subscribing to Game.Instance.OnProfileSelected");
            ModEvent.Postfix += () => IGame.Instance.OnProfileSelected.Invoke();*/
        }


        private long CodeToExecute(long a1)
        {
            if (!firstRun)
                return Hook.OriginalFunction(a1);

            
            var result = Hook.OriginalFunction(a1);
            ModEvent.Invoke(result);
            firstRun = false;
            
            return result;
        }


        /*private long CodeToExecute(long a1)
        {
            debug.WriteLine($"{nameof(LoadPlayerProfile)} hook has just started.");
            isLoadingProfile = true;

            debug.WriteLine($"Invoking Prefix");
            ModEvent.Prefix.Invoke();

            debug.WriteLine($"Executing original game function.");
            var result = Hook.OriginalFunction(a1);

            //a1 = 0; // for testing when it fails to get address. MUST NOT BE IN RELEASE.

            TrySetPlayerStateAddress(a1);

            isLoadingProfile = false;

            debug.WriteLine("Invoking Postfix");
            ModEvent.Postfix.Invoke();

            debug.WriteLine("Hook finished executing.");
            return result;
        }*/

        /*private void TrySetPlayerStateAddress(long address)
        {
            debug.WriteLine("Attempting to get PlayerStateAddress");
            if (IGame.Instance?.Player != null && IGame.Instance.Player.GcPlayerStateAddress > 0)
            {
                debug.WriteLine($"GcPlayerStateData was aready set");
                return;
            }

            if (address == 0)
            {
                logger.WriteLine("Critical Failure! Failed to get address for GcPlayerStateData. Many API features will not work. Please contact devs for API", LogLevel.Error);
                return;
            }

            address += 0x20; // adding 0x20 to skip some network stuff.

            logger.WriteLine("Successfully aquired GcPlayerStateData!");
            logger.WriteLine($"Address of GcPlayerStateData: {address.ToString("X")}", LogLevel.CheatEngine);

            debug.WriteLine("Invoking Game.Instance?.Player?.OnPlayerStateAquired");
            IGame.Instance?.Player?.OnPlayerStateAquired.Invoke(address);
            
        }*/
    }
}