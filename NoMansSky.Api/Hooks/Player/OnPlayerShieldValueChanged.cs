using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System.Runtime.InteropServices;

namespace NoMansSky.Api.Hooks
{
    public unsafe class OnPlayerShieldValueChanged : IModHook
    {
        [Function(CallingConventions.Microsoft)]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate long HookDelegate(long a1, float a2, int a3, long* a4, long* a5, long a6, float** a7);

        public static IFunction<HookDelegate> Function { get; set; }
        public static IHook<HookDelegate> Hook;
        internal static bool isLoadingProfile = false;

        public string HookName => "ChangeShieldValue";
        private ModLogger logger;

        public void InitHook(ModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;
            
            string pattern = "48 8B C4 4C 89 48 20 44 89 40 18 55 56 57 41 54 41 55 41 56 41 57 48 8D";

            Function = _hooks.CreateFunction<HookDelegate>(new Signature(pattern).Scan());
            Hook = Function.Hook(CodeToExecute).Activate();
        }

        private long CodeToExecute(long a1, float a2, int a3, long* a4, long* a5, long a6, float** a7)
        {
            var moddableValue = new EventParams<float>(a2);

            Game.Instance.Player.OnShieldChanged.Prefix.Invoke(moddableValue);
            var result = Hook.OriginalFunction(a1, moddableValue.value, a3, a4, a5, a6, a7);
            Game.Instance.Player.OnShieldChanged.Postfix.Invoke(moddableValue.value);

            return result;
        }
    }
}
