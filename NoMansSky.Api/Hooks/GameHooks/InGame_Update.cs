using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System;
using System.Runtime.InteropServices;

namespace NoMansSky.Api.Hooks.GameHooks
{
    public unsafe class InGame_Update : IModHook
    {
        #region Hook stuff

        [Function(CallingConventions.Microsoft)]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate double HookDelegate();
        public static IFunction<HookDelegate> Function { get; set; }
        public static IHook<HookDelegate> Hook;

        #endregion

        /// <summary>
        /// Reflects whether or not this is currently firing.
        /// <br/>It does not run on main menu, on galaxy map, or on warp.
        /// </summary>
        public static bool IsFiring { get; private set; }

        /// <summary>
        /// ModEventHook that's called when the original function is called.
        /// </summary>
        public static IModEventHook ModEventHook { get; } = new SharedModEventHook();

        internal static bool firstRun = false; // used to track the first time we enter the game.
        public string HookName => "InGame_Update";
        bool didInventoryUpdate = false;
        private IModLogger logger;

        private bool didRunThisFrame = false;

        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;

            string pattern = "48 83 EC 28 48 8D 0D ? ? ? ? E8 ? ? ? ? 83 B8 ? ? ? ? ? 74 2E";

            Function = _hooks.CreateFunction<HookDelegate>(new Signature(pattern).Scan());
            Hook = Function.Hook(CodeToExecute).Activate();
            IGame.Instance.OnMainMenu += () => firstRun = true; // reset firstRun so OnGameJoined works again
            Inventories_Update.ModEventHook.Prefix += () => didInventoryUpdate = true;

            ModEventHook.Postfix += () =>
            {
                // was inventory closed but api still thinks its opened? If so let API know it's closed.
                bool shouldCloseInventory = !didInventoryUpdate && IGame.Instance.IsInventoryOpen;
                if (shouldCloseInventory)
                {
                    IGame.Instance.OnInventoriesClosed.Invoke();
                }

                didInventoryUpdate = false;
            };

            IGame.Instance.GameLoop.OnUpdate.Prefix += () =>
            {
                didRunThisFrame = false;
            };
            IGame.Instance.GameLoop.OnUpdate.Postfix += () =>
            {
                // it's not currently running.
                if (!didRunThisFrame)
                {
                    IsFiring = false;
                }
            };
        }


        private double CodeToExecute()
        {
            IsFiring = true;
            didRunThisFrame = true;

            ModEventHook.Prefix.Invoke();
            var result = Hook.OriginalFunction();
            ModEventHook.Postfix.Invoke();

            if (firstRun)
            {
                IGame.Instance.OnGameJoined.Invoke();
                firstRun = false;
            }

            return result;
        }
    }
}
