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
    internal unsafe class LoadMetadata2 : IModHook
    {
        #region Hook Stuff

        [Function(CallingConventions.Microsoft)]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate long HookDelegate(void* mbinName, int* a2, char a3);

        public static List<IFunction<HookDelegate>> Functions = new List<IFunction<HookDelegate>>();
        public static List<IHook<HookDelegate>> Hooks = new List<IHook<HookDelegate>>();

        #endregion


        public string HookName => "LoadMetadata2";
        private IModLogger Logger;

        public void InitHook(IModLogger _logger, IReloadedHooks _hooks)
        {
            Logger = _logger;
            string sigPattern = "40 53 55 41 56 48 81 EC ? ? ? ? 48 8D 84 24 ? ? ? ? C6 44 24 ? ? C6";



            var patternResults = FindAllPatterns(new Signature(sigPattern).sigPattern);
            var gameProc = Process.GetCurrentProcess();

            int i = 0;
            foreach (var result in patternResults)
            {
                long functionAddress = (long)gameProc.MainModule.BaseAddress + result;
                var function = _hooks.CreateFunction<HookDelegate>(functionAddress);


                IHook<HookDelegate> hook = null;
                hook = function.Hook((mbinName, a2, a3) =>
                {
                    var mbinAddress = hook.OriginalFunction(mbinName, a2, a3);
                    string name = Strings.ToString(mbinName);

                    // failed to load mbin
                    if (mbinAddress == 0)
                        return mbinAddress;

                    MBin mBin = new MBin(name, mbinAddress);

                    //Logger.WriteLine($"Registered: {mBin}");

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
