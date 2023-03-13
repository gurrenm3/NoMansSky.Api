using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.Enums;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using static NoMansSky.Api.Hooks.Macros;

namespace NoMansSky.Api.Hooks.Player
{
    internal unsafe class AddUnitsFromScan : IModHook
    {
        #region Asm Hook Variables

        // The line below creates the function hook while specifying which registers the function uses.
        [Function(new FunctionAttribute.Register[2] { FunctionAttribute.Register.rcx, FunctionAttribute.Register.rdx }, FunctionAttribute.Register.rax, false)]
        public delegate void OnChangedFunc1(int currentUnits, int amountToAdd);

        private IReverseWrapper<OnChangedFunc1> pattern1ReverseWrap;
        public OnChangedFunc1 pattern1Func;
        private IAsmHook pattern1AsmHook;

        #endregion


        /// <summary>
        /// The stat this hook is tied to.
        /// </summary>
        private static Stat<int> Stat => Api.Game.Instance?.Player?.Units;

        /// <summary>
        /// ModEvent that's called when the original function is called.
        /// </summary>
        public static IModEventHook<int> ModEventHook => Stat?.OnValueChanged;


        public string HookName => "Player Remove Units.";
        private EventParam<int> amountChangedParam = new EventParam<int>();
        private IModLogger logger;

        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;
            logger.WriteLine($"{HookName} is temporarily disabled...");
            return;

            pattern1Func = CodeToExecutePattern1;

            string pattern1 = "03 CA 89 88 ? ? ? ? 48 8D 0D ? ? ? ? ";
            long pattern1Address = new Signature(pattern1).Scan();

            string[] pattern1Asm =
            {
                $"{_use32}",
                $"{_hooks.Utilities.GetAbsoluteCallMnemonics(pattern1Func, out pattern1ReverseWrap)}"
            };
            pattern1AsmHook = _hooks.CreateAsmHook(pattern1Asm, pattern1Address, AsmHookBehaviour.DoNotExecuteOriginal).Activate();
        }

        private void CodeToExecutePattern1(int currentUnits, int amountToAdd)
        {
            bool hasGcPlayerState = Api.Game.Instance?.Player != null && Api.Game.Instance.Player.HasGcPlayerState;

            // Player failed to initialize. Can't do hooking.
            if (Stat == null || !hasGcPlayerState)
            {
                logger.WriteLine($"Failed to gain {amountToAdd} units gained from scanning because the API failed to get the Player's address.", LogLevel.Error);
                return;
            }

            int newUnits = currentUnits + amountToAdd;
            amountChangedParam.value = newUnits;

            ModEventHook.Prefix.Invoke(amountChangedParam);
            Stat.Value = amountChangedParam;            
            ModEventHook.Postfix.Invoke(amountChangedParam);
        }
    }
}
