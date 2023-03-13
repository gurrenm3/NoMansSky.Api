using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcProceduralProductCategory : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcProceduralProductCategory.ProceduralProductCategoryEnum ProceduralProductCategory
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcProceduralProductCategory.ProceduralProductCategoryEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcProceduralProductCategory.ProceduralProductCategoryEnum>(value);
	}

	public GcProceduralProductCategory(long address) : base(address)
	{

	}
}
