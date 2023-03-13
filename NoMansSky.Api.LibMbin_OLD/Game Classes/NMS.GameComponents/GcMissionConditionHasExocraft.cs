using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionHasExocraft : NMSTemplate
{
	public Boolean SpecificExocraft
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcVehicleType PrimaryExocraft
	{
		get => GetValue<GcVehicleType>();
		set => TrySetValue<GcVehicleType>(value);
	}

	public GcMissionConditionHasExocraft(long address) : base(address)
	{

	}
}
