using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSettlementPerkUsefulData : NMSTemplate
{
	public NMSString0x10 BaseID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public UInt64 SeedValue
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public Single ChangeStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcSettlementStatType Stat
	{
		get => GetValue<GcSettlementStatType>();
		set => TrySetValue<GcSettlementStatType>(value);
	}

	public Boolean IsNegative
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean IsProc
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcSettlementPerkUsefulData(long address) : base(address)
	{

	}
}
