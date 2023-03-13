using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionHasGalacticFeature : NMSTemplate
{
	public GcMissionGalacticFeature Type
	{
		get => GetValue<GcMissionGalacticFeature>();
		set => TrySetValue<GcMissionGalacticFeature>(value);
	}

	public GcMissionConditionHasGalacticFeature(long address) : base(address)
	{

	}
}
