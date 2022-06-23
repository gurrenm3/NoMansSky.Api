using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System.Runtime.InteropServices;

namespace NoMansSky.Api.Hooks
{
    public unsafe class LoadPlayerProfile : IModHook
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
        
        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;

            string pattern = "40 55 56 57 41 56 41 57 48 8D 6C 24 ? 48 81 EC ? ? ? ? 48 C7 45 ? ? ? ? ? 48 89 9C 24 ? ? ? ? 48 8B F1 45";
            var address = new Signature(pattern).Scan();
            Function = _hooks.CreateFunction<HookDelegate>(address);
            Hook = Function.Hook(CodeToExecute).Activate();
            ModEventHook.Postfix += () => Game.Instance.OnProfileSelected.Invoke();
        }

       
        private long CodeToExecute(long a1)
        {
            isLoadingProfile = true;
            ModEventHook.Prefix.Invoke();

            var result = Hook.OriginalFunction(a1);

            //a1 = 0; // this is for testing. MUST NOT BE IN RELEASE.
            TrySetPlayerStateAddress(a1);
            isLoadingProfile = false;
            ModEventHook.Postfix.Invoke();

            return result;
        }

        private void TrySetPlayerStateAddress(long address)
        {
            if (Game.Instance?.Player != null && Game.Instance.Player.GcPlayerStateAddress > 0)
                return;

            if (address == 0)
            {
                logger.WriteLine("Critical Failure! Failed to get address for GcPlayerStateData. Many API features will not work. Please contact devs for API", LogLevel.Error);
                return;
            }

            address += 0x20; // adding 0x20 to skip some network stuff.

            logger.WriteLine("Successfully aquired GcPlayerStateData!");
            logger.WriteLine($"Address of GcPlayerStateData: {address.ToString("X")}", LogLevel.CheatEngine);

            Game.Instance?.Player?.OnPlayerStateAquired.Invoke(address);
            
        }
    }
}