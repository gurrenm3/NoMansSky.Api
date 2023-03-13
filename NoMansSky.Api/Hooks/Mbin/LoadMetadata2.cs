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

            var addresses = new Signature(sigPattern).ScanAll();
            var gameProc = Process.GetCurrentProcess();

            int i = 0;
            foreach (var address in addresses)
            {
                var function = _hooks.CreateFunction<HookDelegate>(address);

                IHook<HookDelegate> hook = null;
                hook = function.Hook((mbinName, a2, a3) =>
                {
                    var mbinAddress = hook.OriginalFunction(mbinName, a2, a3);
                    string name = StringUtils.ToString(mbinName);

                    // failed to load mbin
                    if (mbinAddress == 0)
                        return mbinAddress;

                    MBin mBin = new MBin(name, mbinAddress);
                    IGame.Instance.MBinManager.RegisterMBin(mBin);

                    return mbinAddress;

                }).Activate();

                Functions.Add(function);
                Hooks.Add(hook);
            }
        }
    }
}
