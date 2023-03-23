using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.X64;
using Reloaded.ModHelper;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace NoMansSky.Api.libMBIN;



public unsafe partial struct GcPlayerState
{
	[FunctionAddress("48 89 5C 24 08 48 89 6C 24 10 48 89 74 24 18 57 48 83 EC 40 44 8B 81 C0")]
    [Function(CallingConventions.Microsoft)]
    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
    public delegate uint awardNanites(GcPlayerState* self, int liChange);

	[FunctionAddress("48 89 5C 24 08 48 89 6C 24 10 48 89 74 24 18 57 48 83 EC 40 44 8B 81 BC")]
    [Function(CallingConventions.Microsoft)]
    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
    public delegate uint awardUnits(GcPlayerState* self, int liChange);


	public uint AwardNanites(GcPlayerState* self, int liChange)
	{
		HookDefinitions.TryCreateAwardNanitesFunc();
		return HookDefinitions.awardNanitesFuncDef.GetWrapper()(self, liChange);
	}

    public uint AwardUnits(int liChange)
    {
        return AwardUnits((GcPlayerState*)Unsafe.AsPointer(ref this), liChange);
    }

    public uint AwardUnits(GcPlayerState* self, int liChange)
	{
		HookDefinitions.TryCreateAwardUnitsFunc();
		return HookDefinitions.awardUnitsFuncDef.GetWrapper()(self, liChange);
	}

	public static IModEventHook<object[]?> GetOrAddHook<T>() where T : Delegate
	{
		if (typeof(T) == typeof(awardNanites))
		{
			HookDefinitions.TryCreateAwardNanitesHook();
			return HookDefinitions.awardNanitesEventHook;
		}
		else if (typeof(T) == typeof(awardUnits))
		{
            HookDefinitions.TryCreateAwardUnitsHook();
			return HookDefinitions.awardUnitsEventHook;
		}
		else
		{
			throw new ArgumentException($"Unable to get hook! GcPlayerState does not have the provided function!");
		}
	}



    public unsafe class HookDefinitions
    {
        public static IFunction<awardNanites> awardNanitesFuncDef = null!;
        public static IHook<awardNanites> awardNanitesHookDef = null!;
        public static IModEventHook<object[]?> awardNanitesEventHook = null!;
        internal static void TryCreateAwardNanitesFunc()
        {
            if (awardNanitesFuncDef != null)
                return;

            var functionPtr = HookDefinitionsUtils.GetAddressFromDelegate<awardNanites>();
            awardNanitesFuncDef = HookDefinitionsUtils.hooksInstance.CreateFunction<awardNanites>(functionPtr);
        }
        internal static void TryCreateAwardNanitesHook()
        {
            if (awardNanitesHookDef != null)
                return;

            if (awardNanitesFuncDef == null)
                TryCreateAwardNanitesFunc();

            awardNanitesEventHook = new SharedModEventHook<object[]?>();
            awardNanitesHookDef = awardNanitesFuncDef.Hook((self, liChange) =>
            {
                var args = new object[] { (long)self, liChange };
                awardNanitesEventHook.Before.Run(args);

                var arg1 = (GcPlayerState)args[0];
                var arg1Ptr = &arg1;

                var _functionReturnedValue = awardNanitesHookDef.OriginalFunction.Invoke(arg1Ptr, (int)args[1]);
                args = new object[] { (long)arg1Ptr, (int)args[1], _functionReturnedValue };
                awardNanitesEventHook.After.Run(args);
                return (uint)args[3];


                /*var args = new object[] { *self, liChange };
                awardNanitesEventHook.Before.Run(args);

                var arg1 = (GcPlayerState)args[0];
                var arg1Ptr = &arg1;

                var _functionReturnedValue = awardNanitesHookDef.OriginalFunction.Invoke(arg1Ptr, (int)args[1]);
                args = new object[] { *arg1Ptr, (int)args[1], _functionReturnedValue };
                awardNanitesEventHook.After.Run(args);
                return (uint)args[3];*/
            });
        }

        public static IFunction<awardUnits> awardUnitsFuncDef = null!;
        public static IHook<awardUnits> awardUnitsHookDef = null!;
        public static IModEventHook<object[]?> awardUnitsEventHook = null!;
        internal static void TryCreateAwardUnitsFunc()
        {
            if (awardUnitsFuncDef != null)
                return;

            var functionPtr = HookDefinitionsUtils.GetAddressFromDelegate<awardUnits>();
            awardUnitsFuncDef = HookDefinitionsUtils.hooksInstance.CreateFunction<awardUnits>(functionPtr);
        }

        internal static void TryCreateAwardUnitsHook()
        {
            if (awardUnitsHookDef != null)
                return;

            if (awardUnitsFuncDef == null)
                TryCreateAwardUnitsFunc();

            awardUnitsEventHook = new SharedModEventHook<object[]?>();
            awardUnitsHookDef = awardUnitsFuncDef.Hook((self, liChange) =>
            {
                var args = new object[] { (long)self, liChange };
                awardUnitsEventHook.Before.Run(args);

                var arg1Ptr = (GcPlayerState*)(long)args[0];

                var _functionReturnedValue = awardUnitsHookDef.OriginalFunction.Invoke(arg1Ptr, (int)args[1]);
                args = new object[] { (long)arg1Ptr, (int)args[1], _functionReturnedValue };
                awardUnitsEventHook.After.Run(args);
                return (uint)args[2];


                /*var args = new object[] { (long)self, liChange };
                awardUnitsEventHook.Before.Run(args);

                var arg1Ptr = (GcPlayerState*)(long)args[0];

                var _functionReturnedValue = awardUnitsHookDef.OriginalFunction.Invoke(arg1Ptr, (int)args[1]);
                args = new object[] { *arg1Ptr, (int)args[1], _functionReturnedValue };
                awardUnitsEventHook.After.Run(args);
                return (uint)args[2];*/
            }).Activate();
        }

        internal static void TryCreateAwardUnitsHookOld()
        {
            if (awardUnitsHookDef != null)
                return;

            if (awardUnitsFuncDef == null)
                TryCreateAwardUnitsFunc();

            awardUnitsEventHook = new SharedModEventHook<object[]?>();
            awardUnitsHookDef = awardUnitsFuncDef.Hook((self, liChange) =>
            {
                var args = new object[] { (long)self, liChange };
                awardUnitsEventHook.Before.Run(args);

                var arg1 = (GcPlayerState*)(long)args[0];
                //var arg1Ptr = &arg1;

                var _functionReturnedValue = awardUnitsHookDef.OriginalFunction.Invoke(arg1, (int)args[1]);
                args = new object[] { (long)arg1, (int)args[1], _functionReturnedValue };
                awardUnitsEventHook.After.Run(args);

                return (uint)args[2];
                //return _functionReturnedValue;
            }).Activate();
        }
    }
}