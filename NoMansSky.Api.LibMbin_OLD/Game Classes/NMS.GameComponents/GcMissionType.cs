using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionType : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcMissionType.MissionTypeEnum MissionType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMissionType.MissionTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMissionType.MissionTypeEnum>(value);
	}

	public GcMissionType(long address) : base(address)
	{

	}
}
