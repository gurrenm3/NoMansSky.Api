using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcTechnologyCategory : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcTechnologyCategory.TechnologyCategoryEnum TechnologyCategory
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcTechnologyCategory.TechnologyCategoryEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcTechnologyCategory.TechnologyCategoryEnum>(value);
	}

	public GcTechnologyCategory(long address) : base(address)
	{

	}
}
