using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBaseBuildingObjectDecorationTypes : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcBaseBuildingObjectDecorationTypes.BaseBuildingDecorationTypeEnum BaseBuildingDecorationType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcBaseBuildingObjectDecorationTypes.BaseBuildingDecorationTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcBaseBuildingObjectDecorationTypes.BaseBuildingDecorationTypeEnum>(value);
	}

	public GcBaseBuildingObjectDecorationTypes(long address) : base(address)
	{

	}
}
