using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcGeneratorUnitComponentData : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcGeneratorUnitComponentData.GeneratorUnitTypeEnum GeneratorUnitType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcGeneratorUnitComponentData.GeneratorUnitTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcGeneratorUnitComponentData.GeneratorUnitTypeEnum>(value);
	}

	public Int32 ResourceMaintenanceSlotOverride
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public VirtualArray<NMSString0x10> BiomeGasRewards
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x10>(address + GetOffset(), 16));
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcMaintenanceComponentData MaintenanceData
	{
		get => GetValue<GcMaintenanceComponentData>();
		set => TrySetValue<GcMaintenanceComponentData>(value);
	}

	public GcGeneratorUnitComponentData(long address) : base(address)
	{

	}
}
