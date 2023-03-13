using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionBasePartBuilt : NMSTemplate
{
	public NMSString0x10 PartID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 Count
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcBuildingPartSearchType Type
	{
		get => GetValue<GcBuildingPartSearchType>();
		set => TrySetValue<GcBuildingPartSearchType>(value);
	}

	public libMBIN.NMS.GameComponents.GcMissionConditionBasePartBuilt.PartInCurrentBaseEnum PartInCurrentBase
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMissionConditionBasePartBuilt.PartInCurrentBaseEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMissionConditionBasePartBuilt.PartInCurrentBaseEnum>(value);
	}

	public GcMissionConditionBasePartBuilt(long address) : base(address)
	{

	}
}
