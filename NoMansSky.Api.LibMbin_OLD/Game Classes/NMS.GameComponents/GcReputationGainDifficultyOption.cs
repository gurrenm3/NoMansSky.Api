using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcReputationGainDifficultyOption : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcReputationGainDifficultyOption.ReputationGainDifficultyEnum ReputationGainDifficulty
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcReputationGainDifficultyOption.ReputationGainDifficultyEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcReputationGainDifficultyOption.ReputationGainDifficultyEnum>(value);
	}

	public GcReputationGainDifficultyOption(long address) : base(address)
	{

	}
}
