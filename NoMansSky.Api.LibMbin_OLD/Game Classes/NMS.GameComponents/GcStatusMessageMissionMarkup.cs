using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcStatusMessageMissionMarkup : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcStatusMessageMissionMarkup.MissionMarkupEnum MissionMarkup
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcStatusMessageMissionMarkup.MissionMarkupEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcStatusMessageMissionMarkup.MissionMarkupEnum>(value);
	}

	public GcStatusMessageMissionMarkup(long address) : base(address)
	{

	}
}
