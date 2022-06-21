using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System;
using System.Runtime.InteropServices;

namespace NoMansSky.Api.Hooks.Mbin
{
    public unsafe class LoadMbinHook3 : IModHook
    {
        [Function(CallingConventions.Microsoft)]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate long HookDelegate(long a1, long a2, long a3);

        public static IHook<HookDelegate> Hook;
        public static IFunction<HookDelegate> Function { get; set; }
        public static string currentMbin;

        public string HookName => "Load MBIN 3";
        private IModLogger logger;

        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            logger = _logger;
            string pattern = "0F 10 05 ? ? ? ? 48 8B C2 F2 0F 10 0D ? ? ? ? 0F 11 02 F2 0F 11 4A ? C3";
            Function = _hooks.CreateFunction<HookDelegate>(new Signature(pattern).Scan());
            Hook = Function.Hook(CodeToExecute).Activate();
        }


        public static long a1;
        public static long a2;
        public static long a3;
        public static long result;
        private static bool hooked = false;

        public static void CallFunction()
        {
            var result = Function.GetWrapper()(a1, a2, a3);
            *(long*)LoadMbinHook3.result = *(long*)result;
        }

        private long CodeToExecute(long a1, long a2, long a3)
        {
            //logger.WriteLine("-- LoadMbin3 Prefix --");


            /*var a2Str = Strings.ToString(a2);
            if (!string.IsNullOrEmpty(a2Str))
            {
                logger.WriteLine($"a2: {a2Str}");
            }*/

            var a3Str = Strings.ToString(a3);
            /*if (!string.IsNullOrEmpty(a3Str))
            {
                logger.WriteLine($"a3: {a3Str}");
            }*/


            var result = Hook.OriginalFunction(a1, a2, a3);

            if (a3Str == "Globals/Player Globals" && !hooked)
            {
                //logger.WriteLine("Found player globals...");
                LoadMbinHook3.a1 = a1;
                LoadMbinHook3.a2 = a2;
                LoadMbinHook3.a3 = a3;
                LoadMbinHook3.result = result;
                hooked = true;
            }

            //logger.WriteLine("-- LoadMbin3 Postfix --");

            /*a2Str = Strings.ToString(a2);
            if (!string.IsNullOrEmpty(a2Str))
            {
                logger.WriteLine($"a2: {a2Str}");
            }

            a3Str = Strings.ToString(a3);
            if (!string.IsNullOrEmpty(a3Str))
            {
                logger.WriteLine($"a3: {a3Str}");
            }

            var resultStr = Strings.ToString(result);
            if (!string.IsNullOrEmpty(resultStr))
            {
                logger.WriteLine($"result: {resultStr}");
            }*/

            return result;
        }
    }
}
