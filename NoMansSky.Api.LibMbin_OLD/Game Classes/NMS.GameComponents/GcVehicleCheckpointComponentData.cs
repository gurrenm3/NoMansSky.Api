using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcVehicleCheckpointComponentData : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcVehicleCheckpointComponentData.CheckpointTypeEnum CheckpointType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcVehicleCheckpointComponentData.CheckpointTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcVehicleCheckpointComponentData.CheckpointTypeEnum>(value);
	}

	public libMBIN.NMS.GameComponents.GcVehicleCheckpointComponentData.RaceTypeEnum RaceType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcVehicleCheckpointComponentData.RaceTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcVehicleCheckpointComponentData.RaceTypeEnum>(value);
	}

	public Single Radius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcVehicleCheckpointComponentData(long address) : base(address)
	{

	}
}
