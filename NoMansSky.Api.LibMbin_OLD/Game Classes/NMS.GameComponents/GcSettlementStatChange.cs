using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSettlementStatChange : NMSTemplate
{
	public GcSettlementStatType Stat
	{
		get => GetValue<GcSettlementStatType>();
		set => TrySetValue<GcSettlementStatType>(value);
	}

	public GcSettlementStatStrength Strength
	{
		get => GetValue<GcSettlementStatStrength>();
		set => TrySetValue<GcSettlementStatStrength>(value);
	}

	public GcSettlementStatChange(long address) : base(address)
	{

	}
}
