using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.Memory.Sigscan;
using Reloaded.Memory.Sigscan.Definitions.Structs;
using Reloaded.Memory.Sigscan.Structs;
using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;

namespace NoMansSky.Api.Hooks.Mbin
{
    internal unsafe class LoadMetadata1 : IModHook
    {
        #region Hook Stuff

        [Function(CallingConventions.Microsoft)]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate long HookDelegate(long a1, char* mbinName, long a3);

        public static List<IFunction<HookDelegate>> Functions = new List<IFunction<HookDelegate>>();
        public static List<IHook<HookDelegate>> Hooks = new List<IHook<HookDelegate>>();

        #endregion


        public string HookName => "LoadMetadata1";
        private IModLogger Logger;

        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            Logger = _logger;
            string sigPattern = "48 8B C4 56 57 41 54 41 56 41 57 48 81 EC ? ? ? ? 48 C7 44 24 ? ? ? ? ? 48 89 58 18 48 89 68 20 45 0F B6 F8 48 8B FA 48 8B E9 40 32 F6 40 88 74 24 ? 45 33 F6 48 85 D2 74 62 44 38 32 74 5D 41 8B F6 48";



            var patternResults = FindAllPatterns(new Signature(sigPattern).sigPattern);
            var gameProc = Process.GetCurrentProcess();

            int i = 0;
            foreach (var result in patternResults)
            {
                long functionAddress = (long)gameProc.MainModule.BaseAddress + result;
                var function = _hooks.CreateFunction<HookDelegate>(functionAddress);


                IHook<HookDelegate> hook = null;
                hook = function.Hook((a1, mbinName, a3) =>
                {
                    var mbinAddress = hook.OriginalFunction(a1, mbinName, a3);
                    string name = Strings.ToString(mbinName);


                    MBin mBin = new MBin(name, mbinAddress);
                    IGame.Instance.MBinManager.RegisterMBin(mBin);

                    return mbinAddress;

                }).Activate();

                Functions.Add(function);
                Hooks.Add(hook);
                
            }
        }



        private static unsafe List<int> FindAllPatterns(string pattern)
        {
            var gameProc = Process.GetCurrentProcess();
            var scanner = new Scanner(gameProc, gameProc.MainModule);

            var results = new List<int>();

            var lastOffset = -1;
            while (true)
            {
                lastOffset = scanner.FindPattern(pattern, lastOffset + 1).Offset;
                if (lastOffset == -1)
                    break;

                results.Add(lastOffset);
            }

            return results;
        }
    }
}
