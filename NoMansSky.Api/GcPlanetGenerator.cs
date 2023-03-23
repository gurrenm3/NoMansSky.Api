using Reloaded.Hooks.Definitions;
using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.libMBIN;

public unsafe partial struct GcPlanetGenerator
{
	[FunctionAddress("48 89 5C 24 10 48 89 6C 24 18 56 57 41 56 48 83 EC 40 8B")]
	public delegate void generateSkyColourPalettes(GcPlanetGenerator* self, GcPlanetData* lPlanetData);


	public void GenerateSkyColourPalettes(GcPlanetGenerator* self, GcPlanetData* lPlanetData)
	{
		HookDefinitions.TryCreateGenerateSkyColourPalettesFunc();
		HookDefinitions.generateSkyColourPalettesFuncDef.GetWrapper()(self, lPlanetData);
	}


	public static IModEventHook<object[]?> GetOrAddHook<T>() where T : Delegate
	{
		if (typeof(T) == typeof(generateSkyColourPalettes))
		{
			HookDefinitions.TryCreateGenerateSkyColourPalettesHook();
			return HookDefinitions.generateSkyColourPalettesEventHook;
		}
		else
		{
			throw new ArgumentException($"Unable to get hook! GcPlanetGenerator does not have the provided function!");
		}
	}

	public static class HookDefinitions
	{
		public static IFunction<generateSkyColourPalettes> generateSkyColourPalettesFuncDef = null!;
		public static IHook<generateSkyColourPalettes> generateSkyColourPalettesHookDef = null!;
		public static IModEventHook<object[]?> generateSkyColourPalettesEventHook = null!;
		internal static void TryCreateGenerateSkyColourPalettesFunc()
		{
			if (generateSkyColourPalettesFuncDef != null)
				return;

			var functionPtr = HookDefinitionsUtils.GetAddressFromDelegate<generateSkyColourPalettes>();
			generateSkyColourPalettesFuncDef = HookDefinitionsUtils.hooksInstance.CreateFunction<generateSkyColourPalettes>(functionPtr);
		}
		internal static void TryCreateGenerateSkyColourPalettesHook()
		{
			if (generateSkyColourPalettesHookDef != null)
				return;

			if (generateSkyColourPalettesFuncDef == null)
				TryCreateGenerateSkyColourPalettesFunc();

			generateSkyColourPalettesEventHook = new SharedModEventHook<object[]?>();
			generateSkyColourPalettesHookDef = generateSkyColourPalettesFuncDef.Hook((self, lPlanetData) =>
			{
				var args = new object[] { (long)self, (long)lPlanetData };
				generateSkyColourPalettesEventHook.Before.Run(args);

				var arg1Ptr = (GcPlanetGenerator*)(long)args[0];
				var arg2Ptr = (GcPlanetData*)(long)args[1];

				generateSkyColourPalettesHookDef.OriginalFunction.Invoke(arg1Ptr, arg2Ptr);
				args = new object[] { *arg1Ptr, *arg2Ptr };
				generateSkyColourPalettesEventHook.After.Run(args);
			}).Activate();
		}
	}
}
