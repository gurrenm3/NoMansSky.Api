using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionAIShipCount : NMSTemplate
{
	public GcRealityCommonFactions Type
	{
		get => GetValue<GcRealityCommonFactions>();
		set => TrySetValue<GcRealityCommonFactions>(value);
	}

	public Int32 Count
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public TkEqualityEnum Test
	{
		get => GetValue<TkEqualityEnum>();
		set => TrySetValue<TkEqualityEnum>(value);
	}

	public GcMissionConditionAIShipCount(long address) : base(address)
	{

	}
}
