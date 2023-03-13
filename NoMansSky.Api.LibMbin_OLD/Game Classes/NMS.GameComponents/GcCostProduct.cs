using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCostProduct : NMSTemplate
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

	public GcCostProduct(long address) : base(address)
	{

	}
}
