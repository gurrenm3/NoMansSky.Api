using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionDifficulty : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcMissionDifficulty.MissionDifficultyEnum MissionDifficulty
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMissionDifficulty.MissionDifficultyEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMissionDifficulty.MissionDifficultyEnum>(value);
	}

	public GcMissionDifficulty(long address) : base(address)
	{

	}
}
