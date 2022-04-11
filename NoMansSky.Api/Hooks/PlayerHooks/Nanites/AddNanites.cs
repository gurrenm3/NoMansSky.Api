using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System;
using System.Runtime.InteropServices;

namespace NoMansSky.Api.Hooks.PlayerHooks
{
    public unsafe class AddNanites : IModHook
    {
        [Function(CallingConventions.Microsoft)]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate long HookDelegate(long gcPlayerStateData, int amountToAdd);

        /// <summary>
        /// ModEventHook that's called when the original function is called.
        /// </summary>
        public static IModEventHook<int> ModEventHook => Game.Instance.Player.Nanites.OnValueChanged;
        public static IFunction<HookDelegate> Function { get; set; }
        public static IHook<HookDelegate> Hook;

        public string HookName => "Add Nanites";
        private EventParam<int> amountChangedParam = new EventParam<int>();
        private IModLogger logger;

        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;

            string pattern = "48 89 5C 24 ? 48 89 6C 24 ? 48 89 74 24 ? 48 89 7C 24 ? 41 56 48 83 EC 40 8B 81 C0";

            Function = _hooks.CreateFunction<HookDelegate>(new Signature(pattern).Scan());
            Hook = Function.Hook(CodeToExecute).Activate();
        }

        private long CodeToExecute(long gcPlayerStateData, int amountToAdd)
        {
            var currentNanites = Game.Instance.Player.Nanites;
            var newNanites = currentNanites + amountToAdd;
            amountChangedParam.value = newNanites;

            ModEventHook.Prefix.Invoke(amountChangedParam);
            int actualAmountToAdd = amountChangedParam.value - currentNanites;

            var result = Hook.OriginalFunction(gcPlayerStateData, actualAmountToAdd);
            ModEventHook.Postfix.Invoke(amountChangedParam);

            return result;
        }
    }
}
