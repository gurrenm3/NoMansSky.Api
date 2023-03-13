using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionDefaultItem : NMSTemplate
{
	public GcDefaultMissionProductEnum ProductType
	{
		get => GetValue<GcDefaultMissionProductEnum>();
		set => TrySetValue<GcDefaultMissionProductEnum>(value);
	}

	public GcDefaultMissionSubstanceEnum SubstanceType
	{
		get => GetValue<GcDefaultMissionSubstanceEnum>();
		set => TrySetValue<GcDefaultMissionSubstanceEnum>(value);
	}

	public NMSString0x10 ID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcMissionConditionDefaultItem(long address) : base(address)
	{

	}
}
