using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRealitySubstanceCategory : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcRealitySubstanceCategory.SubstanceCategoryEnum SubstanceCategory
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcRealitySubstanceCategory.SubstanceCategoryEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcRealitySubstanceCategory.SubstanceCategoryEnum>(value);
	}

	public GcRealitySubstanceCategory(long address) : base(address)
	{

	}
}
