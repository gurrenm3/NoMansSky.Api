using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcFontTypesEnum : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcFontTypesEnum.FontEnum Font
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcFontTypesEnum.FontEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcFontTypesEnum.FontEnum>(value);
	}

	public GcFontTypesEnum(long address) : base(address)
	{

	}
}
