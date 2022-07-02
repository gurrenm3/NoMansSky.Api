using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
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
        /// ModEventHook that's called when the original function is called.
        /// </summary>
        public static IModEventHook ModEventHook { get; set; } = new SharedModEventHook();
        internal static bool isLoadingProfile = false;
        public string HookName => "OnPlayerProfileLoaded";
        private IModLogger logger;
        private DebugLogger debug;
        
        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;
            debug = new DebugLogger(logger);

            string pattern = "40 55 56 57 41 56 41 57 48 8D 6C 24 ? 48 81 EC ? ? ? ? 48 C7 45 ? ? ? ? ? 48 89 9C 24 ? ? ? ? 48 8B F1 45";

            debug.WriteLine("Scanning for function signature");
            var address = new Signature(pattern).Scan();

            debug.WriteLine("Creating Function from signature");
            Function = _hooks.CreateFunction<HookDelegate>(address);

            debug.WriteLine("Creating Hook from Function.");
            Hook = Function.Hook(CodeToExecute).Activate();

            debug.WriteLine("Subscribing to Game.Instance.OnProfileSelected");
            ModEventHook.Postfix += () => IGame.Instance.OnProfileSelected.Invoke();
        }

       
        private long CodeToExecute(long a1)
        {
            debug.WriteLine($"{nameof(LoadPlayerProfile)} hook has just started.");
            isLoadingProfile = true;

            debug.WriteLine($"Invoking Prefix");
            ModEventHook.Prefix.Invoke();

            debug.WriteLine($"Executing original game function.");
            var result = Hook.OriginalFunction(a1);

            //a1 = 0; // for testing when it fails to get address. MUST NOT BE IN RELEASE.

            TrySetPlayerStateAddress(a1);

            isLoadingProfile = false;

            debug.WriteLine("Invoking Postfix");
            ModEventHook.Postfix.Invoke();

            debug.WriteLine("Hook finished executing.");
            return result;
        }

        private void TrySetPlayerStateAddress(long address)
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
            
        }
    }
}