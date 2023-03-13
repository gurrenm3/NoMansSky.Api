using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSettlementStatStrength : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcSettlementStatStrength.SettlementStatStrengthEnum SettlementStatStrength
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcSettlementStatStrength.SettlementStatStrengthEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcSettlementStatStrength.SettlementStatStrengthEnum>(value);
	}

	public GcSettlementStatStrength(long address) : base(address)
	{

	}
}
