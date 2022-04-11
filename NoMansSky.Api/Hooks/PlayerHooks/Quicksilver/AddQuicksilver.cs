using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System.Runtime.InteropServices;

namespace NoMansSky.Api.Hooks.PlayerHooks
{
    public unsafe class AddQuicksilver : IModHook
    {
        [Function(CallingConventions.Microsoft)]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate long HookDelegate(long gcPlayerStateData, int amountToAdd);

        /// <summary>
        /// ModEventHook that's called when the original function is called.
        /// </summary>
        public static IModEventHook<int> ModEventHook => Game.Instance.Player.Quicksilver.OnValueChanged;
        public static IFunction<HookDelegate> Function { get; set; }
        public static IHook<HookDelegate> Hook;

        public string HookName => "Add Quicksilver";
        private EventParam<int> amountChangedParam = new EventParam<int>();
        private IModLogger logger;

        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;

            string pattern = "44 8B 81 ? ? ? ? 41 8B C0 F7 D0 3B D0 0F 42 C2 48 FF 81 ? ? ? ? 41 03 C0 ";

            Function = _hooks.CreateFunction<HookDelegate>(new Signature(pattern).Scan());
            Hook = Function.Hook(CodeToExecute).Activate();
        }

        private long CodeToExecute(long gcPlayerStateData, int amountToAdd)
        {
            int currentQuicksilver = Game.Instance.Player.Quicksilver;
            int newQuicksilver = currentQuicksilver + amountToAdd;
            amountChangedParam.value = newQuicksilver;

            ModEventHook.Prefix.Invoke(amountChangedParam);
            Game.Instance.Player.Quicksilver.Value = amountChangedParam.value;
            ModEventHook.Postfix.Invoke(amountChangedParam);

            return Game.Instance.Player.Quicksilver;
        }
    }
}
