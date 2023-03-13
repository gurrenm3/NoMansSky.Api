using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcScreenFilters : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcScreenFilters.ScreenFilterEnum ScreenFilter
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcScreenFilters.ScreenFilterEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcScreenFilters.ScreenFilterEnum>(value);
	}

	public GcScreenFilters(long address) : base(address)
	{

	}
}
