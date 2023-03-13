using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcProceduralTechnologyCategory : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcProceduralTechnologyCategory.ProceduralTechnologyCategoryEnum ProceduralTechnologyCategory
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcProceduralTechnologyCategory.ProceduralTechnologyCategoryEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcProceduralTechnologyCategory.ProceduralTechnologyCategoryEnum>(value);
	}

	public GcProceduralTechnologyCategory(long address) : base(address)
	{

	}
}
