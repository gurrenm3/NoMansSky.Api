using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionGalacticPoint : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcMissionGalacticPoint.GalacticPointEnum GalacticPoint
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMissionGalacticPoint.GalacticPointEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMissionGalacticPoint.GalacticPointEnum>(value);
	}

	public GcMissionGalacticPoint(long address) : base(address)
	{

	}
}
