using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCostProductOnlyTakeIfCanAfford : NMSTemplate
{
	public GcDefaultMissionProductEnum Default
	{
		get => GetValue<GcDefaultMissionProductEnum>();
		set => TrySetValue<GcDefaultMissionProductEnum>(value);
	}

	public NMSString0x10 Id
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 Amount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public NMSString0x20A AltCostLocID
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcCostProductOnlyTakeIfCanAfford(long address) : base(address)
	{

	}
}
