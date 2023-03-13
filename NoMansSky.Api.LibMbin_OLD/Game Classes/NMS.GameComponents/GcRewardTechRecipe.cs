using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardTechRecipe : NMSTemplate
{
	public GcTechnologyCategory Category
	{
		get => GetValue<GcTechnologyCategory>();
		set => TrySetValue<GcTechnologyCategory>(value);
	}

	public NMSString0x10 RewardGroup
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcRewardTechRecipe(long address) : base(address)
	{

	}
}
