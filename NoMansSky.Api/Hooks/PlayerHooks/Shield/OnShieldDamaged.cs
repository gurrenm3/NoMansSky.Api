using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System;
using System.Runtime.InteropServices;

namespace NoMansSky.Api.Hooks.PlayerHooks
{
    public unsafe class OnShieldDamaged : IModHook
    {
        #region Hook Stuff

        [Function(CallingConventions.Microsoft)]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate long HookDelegate(long a1, float a2, int a3, long* a4, long* a5, long a6, float** a7);
        public static IFunction<HookDelegate> Function { get; set; }
        public static IHook<HookDelegate> Hook;

        #endregion


        /// <summary>
        /// The stat this hook is tied to.
        /// </summary>
        private static Stat<int> Stat => Game.Instance?.Player?.Shield;

        /// <summary>
        /// ModEventHook that's called when the original function is called.
        /// </summary>
        public static IModEventHook<int> ModEventHook => Stat?.OnValueChanged;


        public string HookName => "On Player Shield Damaged.";
        private EventParam<int> amountChangedParam = new EventParam<int>();
        private IModLogger logger;

        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;
            
            string pattern = "48 8B C4 4C 89 48 20 44 89 40 18 55 56 57 41 54 41 55 41 56 41 57 48 8D";

            Function = _hooks.CreateFunction<HookDelegate>(new Signature(pattern).Scan());
            Hook = Function.Hook(CodeToExecute).Activate();
        }

        private long CodeToExecute(long self, float damage, int a3, long* a4, long* a5, long a6, float** a7)
        {
            bool hasGcPlayerState = Game.Instance?.Player != null && Game.Instance.Player.HasGcPlayerState;

            // Player failed to initialize. Can't do hooking.
            if (Stat == null || !hasGcPlayerState)
                return Hook.OriginalFunction(self, damage, a3, a4, a5, a6, a7);


            var currentShield = Stat.Value;
            var damageFloored = Mathf.FloorToInt(damage);
            var newShieldValue = currentShield + damageFloored;
            amountChangedParam.value = newShieldValue;

            ModEventHook.Prefix.Invoke(amountChangedParam);
            float actualDamage = amountChangedParam.value - currentShield;

            var result = Hook.OriginalFunction(self, actualDamage, a3, a4, a5, a6, a7);
            ModEventHook.Postfix.Invoke(amountChangedParam);

            return result;
        }
    }
}
