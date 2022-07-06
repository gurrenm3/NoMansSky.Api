using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System;
using System.Runtime.InteropServices;

namespace NoMansSky.Api.Hooks.Player
{
    internal unsafe class Player_Update : IModHook
    {
        #region Hook stuff

        [Function(CallingConventions.Microsoft)]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate void HookDelegate(long self, float deltaTime);
        public static IFunction<HookDelegate> Function { get; set; }
        public static IHook<HookDelegate> Hook;

        #endregion


        /// <summary>
        /// ModEventHook that's called when the original function is called.
        /// <br/>The first parameter is the player base address.
        /// <br/>The second parameter is delta time, the time between this frame and the last one.
        /// </summary>
        public static IModEventHook<long, float> ModEventHook { get; } = new SharedModEventHook<long, float>();
        internal static bool firstRun = false;


        EventParam<long> playerAddress = new EventParam<long>();
        EventParam<float> deltaTime = new EventParam<float>();
        public string HookName => "Possible Player Update";
        private IModLogger logger;

        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;

            string pattern = "48 8B C4 48 89 58 08 48 89 68 10 48 89 70 18 57 41 56 41 57 48 81 EC ? ? ? ? 0F 29 70 D8 48 8D";

            Function = _hooks.CreateFunction<HookDelegate>(new Signature(pattern).Scan());
            Hook = Function.Hook(CodeToExecute).Activate();
        }

        private void CodeToExecute(long self, float deltaTime)
        {
            // Player failed to initialize. Can't run API code.
            if (Api.Game.Instance?.Player != null && !Api.Game.Instance.Player.HasGcPlayerState)
            {
                Hook.OriginalFunction(self, deltaTime);
                return;
            }

            if (Api.Game.Instance.Player.BaseAddress == 0)
                Api.Game.Instance.Player.OnBaseAddressAquired.Invoke(self);

            this.playerAddress.value = self;
            this.deltaTime.value = deltaTime;

            ModEventHook.Prefix.Invoke(playerAddress, this.deltaTime);
            Hook.OriginalFunction(self, deltaTime);
            ModEventHook.Postfix.Invoke(playerAddress, this.deltaTime);
        }
    }
}
