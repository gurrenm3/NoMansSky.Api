using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System;
using System.Runtime.InteropServices;

namespace NoMansSky.Api.Hooks
{
    public unsafe class InGame_Update : IModHook
    {
        [Function(CallingConventions.Microsoft)]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate double HookDelegate();

        /// <summary>
        /// ModEventHook that's called when the original function is called.
        /// </summary>
        public static IModEventHook ModEventHook { get; } = new SharedModEventHook();
        public static IFunction<HookDelegate> Function { get; set; }
        public static IHook<HookDelegate> Hook;
        internal static bool firstRun = false;

        public string HookName => "InGame_Update";
        private IModLogger logger;
        bool didInventoryUpdate = false;

        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;
            
            string pattern = "48 83 EC 28 48 8D 0D ? ? ? ? E8 ? ? ? ? 83 B8 ? ? ? ? ? 74 2E";

            Function = _hooks.CreateFunction<HookDelegate>(new Signature(pattern).Scan());
            Hook = Function.Hook(CodeToExecute).Activate();
            Game.Instance.OnMainMenu += () => firstRun = true; // reset firstRun so OnGameJoined works again
            Inventories_Update.ModEventHook.Prefix += () => didInventoryUpdate = true;

            ModEventHook.Postfix += () =>
            {
                // was inventory closed but api still thinks its opened? If so let API know it's closed.
                bool shouldCloseInventory = !didInventoryUpdate && Game.Instance.IsInventoryOpen;
                if (shouldCloseInventory)
                {
                    Game.Instance.OnInventoriesClosed.Invoke();
                }

                didInventoryUpdate = false;
            };
        }

        private double CodeToExecute()
        {
            ModEventHook.Prefix.Invoke();
            var result = Hook.OriginalFunction();
            ModEventHook.Postfix.Invoke();

            if (firstRun)
            {
                Game.Instance.OnGameJoined.Invoke();
                firstRun = false;
            }

            return result;
        }
    }
}
