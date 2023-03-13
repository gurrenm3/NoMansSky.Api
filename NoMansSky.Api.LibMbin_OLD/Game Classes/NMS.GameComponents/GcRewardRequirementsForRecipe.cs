using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardRequirementsForRecipe : NMSTemplate
{
	public NMSString0x10 RecipeID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean RewardInCreative
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcRewardRequirementsForRecipe(long address) : base(address)
	{

	}
}
