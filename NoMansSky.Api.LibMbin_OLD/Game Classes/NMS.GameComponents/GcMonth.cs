using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMonth : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcMonth.MonthEnum Month
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMonth.MonthEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMonth.MonthEnum>(value);
	}

	public GcMonth(long address) : base(address)
	{

	}
}
