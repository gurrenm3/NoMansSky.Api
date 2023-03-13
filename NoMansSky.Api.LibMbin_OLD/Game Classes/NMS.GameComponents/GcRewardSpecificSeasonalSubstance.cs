using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardSpecificSeasonalSubstance : NMSTemplate
{
	public NMSString0x10 ID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 AmountMin
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 AmountMax
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single ChanceToUse
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 SeasonNumber
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcRewardSpecificSeasonalSubstance(long address) : base(address)
	{

	}
}
