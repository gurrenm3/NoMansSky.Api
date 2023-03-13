using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionGalacticFeature : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcMissionGalacticFeature.GalacticFeatureEnum GalacticFeature
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMissionGalacticFeature.GalacticFeatureEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMissionGalacticFeature.GalacticFeatureEnum>(value);
	}

	public GcMissionGalacticFeature(long address) : base(address)
	{

	}
}
