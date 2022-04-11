using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System.Runtime.InteropServices;

namespace NoMansSky.Api.Hooks.PlayerHooks
{
    public unsafe class RemoveQuicksilver : IModHook
    {
        [Function(CallingConventions.Microsoft)]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate long HookDelegate(long gcPlayerStateData, int amountToRemove);

        /// <summary>
        /// ModEventHook that's called when the original function is called.
        /// </summary>
        public static IModEventHook<int> ModEventHook => Game.Instance.Player.Quicksilver.OnValueChanged;
        public static IFunction<HookDelegate> Function { get; set; }
        public static IHook<HookDelegate> Hook;

        public string HookName => "Remove Quicksilver";
        private EventParam<int> amountChangedParam = new EventParam<int>();
        private IModLogger logger;

        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;

            string pattern = "8B 81 ? ? ? ? 3B D0 44 8B C0 44 0F 42 C2 48 FF 81 ? ? ? ? 41 2B C0 89 81 ? ? ? ?";

            Function = _hooks.CreateFunction<HookDelegate>(new Signature(pattern).Scan());
            Hook = Function.Hook(CodeToExecute).Activate();
        }

        private long CodeToExecute(long gcPlayerStateData, int amountToRemove)
        {
            int currentQuicksilver = Game.Instance.Player.Quicksilver;
            int newQuicksilver = currentQuicksilver - amountToRemove;
            amountChangedParam.value = newQuicksilver;

            ModEventHook.Prefix.Invoke(amountChangedParam);
            Game.Instance.Player.Quicksilver.Value = amountChangedParam.value;
            ModEventHook.Postfix.Invoke(amountChangedParam);

            return Game.Instance.Player.Quicksilver;
        }
    }
}
