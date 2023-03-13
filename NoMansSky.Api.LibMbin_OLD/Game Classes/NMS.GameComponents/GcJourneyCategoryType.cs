using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcJourneyCategoryType : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcJourneyCategoryType.CategoryTypeEnum CategoryType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcJourneyCategoryType.CategoryTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcJourneyCategoryType.CategoryTypeEnum>(value);
	}

	public GcJourneyCategoryType(long address) : base(address)
	{

	}
}
