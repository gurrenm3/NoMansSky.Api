using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCostSubstance : NMSTemplate
{
	public GcDefaultMissionSubstanceEnum Default
	{
		get => GetValue<GcDefaultMissionSubstanceEnum>();
		set => TrySetValue<GcDefaultMissionSubstanceEnum>(value);
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

	public GcCostSubstance(long address) : base(address)
	{

	}
}
