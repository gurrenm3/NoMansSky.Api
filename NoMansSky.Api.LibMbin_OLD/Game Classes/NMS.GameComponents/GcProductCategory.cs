using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcProductCategory : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcProductCategory.ProductCategoryEnum ProductCategory
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcProductCategory.ProductCategoryEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcProductCategory.ProductCategoryEnum>(value);
	}

	public GcProductCategory(long address) : base(address)
	{

	}
}
