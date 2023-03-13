using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSettlementJobDetails : NMSTemplate
{
	public NMSString0x20A PerkTitle
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A InTextTitle
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcSettlementStatType Stat
	{
		get => GetValue<GcSettlementStatType>();
		set => TrySetValue<GcSettlementStatType>(value);
	}

	public GcSettlementJobDetails(long address) : base(address)
	{

	}
}
