using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAlienPuzzleCategory : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcAlienPuzzleCategory.AlienPuzzleCategoryEnum AlienPuzzleCategory
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcAlienPuzzleCategory.AlienPuzzleCategoryEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcAlienPuzzleCategory.AlienPuzzleCategoryEnum>(value);
	}

	public GcAlienPuzzleCategory(long address) : base(address)
	{

	}
}
