using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionIsSurveying : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcMissionConditionIsSurveying.ForHotspotTypeEnum ForHotspotType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMissionConditionIsSurveying.ForHotspotTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMissionConditionIsSurveying.ForHotspotTypeEnum>(value);
	}

	public Boolean RequireAlreadyAnalysed
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcMissionConditionIsSurveying(long address) : base(address)
	{

	}
}
