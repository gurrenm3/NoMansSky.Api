using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSettlementStatType : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcSettlementStatType.SettlementStatTypeEnum SettlementStatType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcSettlementStatType.SettlementStatTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcSettlementStatType.SettlementStatTypeEnum>(value);
	}

	public GcSettlementStatType(long address) : base(address)
	{

	}
}
