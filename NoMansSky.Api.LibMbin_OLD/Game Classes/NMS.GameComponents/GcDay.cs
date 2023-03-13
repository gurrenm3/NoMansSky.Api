using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDay : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcDay.DayEnum Day
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcDay.DayEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcDay.DayEnum>(value);
	}

	public GcDay(long address) : base(address)
	{

	}
}
