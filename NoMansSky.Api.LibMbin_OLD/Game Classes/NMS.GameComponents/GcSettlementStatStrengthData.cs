using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSettlementStatStrengthData : NMSTemplate
{
	public VirtualArray<GcSettlementStatStrengthRanges> PerkStatStrengthValues
	{
		get => cache.GetOrAddValue(new VirtualArray<GcSettlementStatStrengthRanges>(address + GetOffset(), 7));
		set => TrySetValue<GcSettlementStatStrengthRanges>(value);
	}

	public GcSettlementStatStrengthData(long address) : base(address)
	{

	}
}
