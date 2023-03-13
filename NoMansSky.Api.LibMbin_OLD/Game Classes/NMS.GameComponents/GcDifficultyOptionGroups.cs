using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDifficultyOptionGroups : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcDifficultyOptionGroups.DifficultyOptionGroupEnum DifficultyOptionGroup
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcDifficultyOptionGroups.DifficultyOptionGroupEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcDifficultyOptionGroups.DifficultyOptionGroupEnum>(value);
	}

	public GcDifficultyOptionGroups(long address) : base(address)
	{

	}
}
