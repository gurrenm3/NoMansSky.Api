using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSubstanceCollectionDifficultyOption : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcSubstanceCollectionDifficultyOption.SubstanceCollectionDifficultyEnum SubstanceCollectionDifficulty
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcSubstanceCollectionDifficultyOption.SubstanceCollectionDifficultyEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcSubstanceCollectionDifficultyOption.SubstanceCollectionDifficultyEnum>(value);
	}

	public GcSubstanceCollectionDifficultyOption(long address) : base(address)
	{

	}
}
