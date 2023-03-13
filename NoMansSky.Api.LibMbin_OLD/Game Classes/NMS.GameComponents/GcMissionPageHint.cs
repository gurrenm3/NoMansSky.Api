using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionPageHint : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcMissionPageHint.MissionPageHintEnum MissionPageHint
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMissionPageHint.MissionPageHintEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMissionPageHint.MissionPageHintEnum>(value);
	}

	public GcMissionPageHint(long address) : base(address)
	{

	}
}
