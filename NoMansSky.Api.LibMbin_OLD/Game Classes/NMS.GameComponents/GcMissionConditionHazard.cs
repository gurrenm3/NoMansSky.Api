using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionHazard : NMSTemplate
{
	public GcPlayerHazardType Hazard
	{
		get => GetValue<GcPlayerHazardType>();
		set => TrySetValue<GcPlayerHazardType>(value);
	}

	public GcMissionConditionHazard(long address) : base(address)
	{

	}
}
