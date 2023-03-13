using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBaseBuildingMode : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcBaseBuildingMode.BaseBuildingModeEnum BaseBuildingMode
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcBaseBuildingMode.BaseBuildingModeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcBaseBuildingMode.BaseBuildingModeEnum>(value);
	}

	public GcBaseBuildingMode(long address) : base(address)
	{

	}
}
