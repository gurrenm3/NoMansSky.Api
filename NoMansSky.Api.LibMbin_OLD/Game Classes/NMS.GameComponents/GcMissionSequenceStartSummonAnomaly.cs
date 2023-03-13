using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionSequenceStartSummonAnomaly : NMSTemplate
{
	public GcGalaxyStarAnomaly Anomaly
	{
		get => GetValue<GcGalaxyStarAnomaly>();
		set => TrySetValue<GcGalaxyStarAnomaly>(value);
	}

	public Single SummonInFrontDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x80 DebugText
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcMissionSequenceStartSummonAnomaly(long address) : base(address)
	{

	}
}
