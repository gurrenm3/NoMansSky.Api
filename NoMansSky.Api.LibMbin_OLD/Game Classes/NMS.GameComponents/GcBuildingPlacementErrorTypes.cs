using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBuildingPlacementErrorTypes : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcBuildingPlacementErrorTypes.InvalidPlacementReasonEnum InvalidPlacementReason
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcBuildingPlacementErrorTypes.InvalidPlacementReasonEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcBuildingPlacementErrorTypes.InvalidPlacementReasonEnum>(value);
	}

	public GcBuildingPlacementErrorTypes(long address) : base(address)
	{

	}
}
