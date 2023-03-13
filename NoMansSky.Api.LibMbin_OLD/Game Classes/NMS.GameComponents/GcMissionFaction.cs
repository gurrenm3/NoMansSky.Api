using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionFaction : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcMissionFaction.MissionFactionEnum MissionFaction
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMissionFaction.MissionFactionEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMissionFaction.MissionFactionEnum>(value);
	}

	public GcMissionFaction(long address) : base(address)
	{

	}
}
