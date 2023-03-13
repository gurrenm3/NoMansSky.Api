using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionIsScanEventLocalOrNear : NMSTemplate
{
	public GcMissionConditionIsScanEventLocal Local
	{
		get => GetValue<GcMissionConditionIsScanEventLocal>();
		set => TrySetValue<GcMissionConditionIsScanEventLocal>(value);
	}

	public Single MaxDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcMissionConditionIsScanEventLocalOrNear(long address) : base(address)
	{

	}
}
