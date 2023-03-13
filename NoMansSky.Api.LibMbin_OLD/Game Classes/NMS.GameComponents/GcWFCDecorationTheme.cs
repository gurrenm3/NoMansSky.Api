using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcWFCDecorationTheme : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcWFCDecorationTheme.WFCDecorationThemeEnum WFCDecorationTheme
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcWFCDecorationTheme.WFCDecorationThemeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcWFCDecorationTheme.WFCDecorationThemeEnum>(value);
	}

	public GcWFCDecorationTheme(long address) : base(address)
	{

	}
}
