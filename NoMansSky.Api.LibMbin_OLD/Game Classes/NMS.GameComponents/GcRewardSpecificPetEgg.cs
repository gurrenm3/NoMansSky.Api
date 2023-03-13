using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardSpecificPetEgg : NMSTemplate
{
	public Boolean ImmediatelyHatchable
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcPetData EggData
	{
		get => GetValue<GcPetData>();
		set => TrySetValue<GcPetData>(value);
	}

	public GcRewardSpecificPetEgg(long address) : base(address)
	{

	}
}
