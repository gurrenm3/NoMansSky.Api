using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcYearlyRecurrence : NMSTemplate
{
	public Int32 RecurrenceMinute
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 RecurrenceHour
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 RecurrenceDay
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcMonth RecurrenceMonth
	{
		get => GetValue<GcMonth>();
		set => TrySetValue<GcMonth>(value);
	}

	public NMSString0x80 DebugText
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcYearlyRecurrence(long address) : base(address)
	{

	}
}
