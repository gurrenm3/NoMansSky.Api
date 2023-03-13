using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionSeasonRewardsRecipe : NMSTemplate
{
	public NMSString0x10 RecipeID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcMissionConditionSeasonRewardsRecipe(long address) : base(address)
	{

	}
}
