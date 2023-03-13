using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRegionHotspotSubstance : NMSTemplate
{
	public NMSString0x10 SubstanceId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 AmountCost
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 SubstanceYeild
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcRegionHotspotSubstance(long address) : base(address)
	{

	}
}
