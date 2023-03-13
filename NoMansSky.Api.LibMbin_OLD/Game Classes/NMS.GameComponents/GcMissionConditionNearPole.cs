using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionNearPole : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcMissionConditionNearPole.PoleConditionEnum PoleCondition
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMissionConditionNearPole.PoleConditionEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMissionConditionNearPole.PoleConditionEnum>(value);
	}

	public Single Distance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcMissionConditionNearPole(long address) : base(address)
	{

	}
}
