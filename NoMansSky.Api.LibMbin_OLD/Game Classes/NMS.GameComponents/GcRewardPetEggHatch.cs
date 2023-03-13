using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardPetEggHatch : NMSTemplate
{
	public Int32 EggIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcRewardPetEggHatch(long address) : base(address)
	{

	}
}
