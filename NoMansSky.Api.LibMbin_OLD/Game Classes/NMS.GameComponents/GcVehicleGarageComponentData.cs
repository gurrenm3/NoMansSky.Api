using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcVehicleGarageComponentData : NMSTemplate
{
	public GcVehicleType Vehicle
	{
		get => GetValue<GcVehicleType>();
		set => TrySetValue<GcVehicleType>(value);
	}

	public GcVehicleGarageComponentData(long address) : base(address)
	{

	}
}
