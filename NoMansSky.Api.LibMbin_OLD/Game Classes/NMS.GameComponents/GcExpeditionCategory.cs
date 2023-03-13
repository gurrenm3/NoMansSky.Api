using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcExpeditionCategory : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcExpeditionCategory.ExpeditionCategoryEnum ExpeditionCategory
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcExpeditionCategory.ExpeditionCategoryEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcExpeditionCategory.ExpeditionCategoryEnum>(value);
	}

	public GcExpeditionCategory(long address) : base(address)
	{

	}
}
