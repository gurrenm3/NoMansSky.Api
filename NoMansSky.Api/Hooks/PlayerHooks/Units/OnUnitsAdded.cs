using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System;
using System.Runtime.InteropServices;

namespace NoMansSky.Api.Hooks.PlayerHooks
{
    public unsafe class OnUnitsAdded : IModHook
    {
        [Function(CallingConventions.Microsoft)]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate long HookDelegate(long gcPlayerStateData, int amountToAdd);

        /// <summary>
        /// ModEventHook that's called when the original function is called.
        /// </summary>
        public static IModEventHook<int> ModEventHook => Game.Instance.Player.Units.OnValueChanged;
        public static IFunction<HookDelegate> Function { get; set; }
        public static IHook<HookDelegate> Hook;

        public string HookName => "Player Add Units.";
        private EventParam<int> amountChangedParam = new EventParam<int>();
        private IModLogger logger;

        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;
            
            string pattern = "48 89 5C 24 ? 48 89 6C 24 ? 48 89 74 24 ? 48 89 7C 24 ? 41 56 48 83 EC 40 8B 81 BC";

            Function = _hooks.CreateFunction<HookDelegate>(new Signature(pattern).Scan());
            Hook = Function.Hook(CodeToExecute).Activate();
        }

        private long CodeToExecute(long gcPlayerStateData, int amountToAdd)
        {
            int currentUnits = Game.Instance.Player.Units;
            int newUnits = currentUnits + amountToAdd;
            amountChangedParam.value = newUnits;

            ModEventHook.Prefix.Invoke(amountChangedParam);

            int newAmountToAdd = amountChangedParam - currentUnits;
            var unitsAfterAdding = Hook.OriginalFunction(gcPlayerStateData, newAmountToAdd);
            ModEventHook.Postfix.Invoke(amountChangedParam);

            return unitsAfterAdding;
        }
    }
}
