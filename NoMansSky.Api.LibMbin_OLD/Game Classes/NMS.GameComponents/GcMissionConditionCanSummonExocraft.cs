using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionCanSummonExocraft : NMSTemplate
{
	public Boolean SpecificExocraft
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcVehicleType SummonableExocraft
	{
		get => GetValue<GcVehicleType>();
		set => TrySetValue<GcVehicleType>(value);
	}

	public GcMissionConditionCanSummonExocraft(long address) : base(address)
	{

	}
}
