using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSettlementConstructionLevel : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcSettlementConstructionLevel.SettlementConstructionLevelEnum SettlementConstructionLevel
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcSettlementConstructionLevel.SettlementConstructionLevelEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcSettlementConstructionLevel.SettlementConstructionLevelEnum>(value);
	}

	public GcSettlementConstructionLevel(long address) : base(address)
	{

	}
}
