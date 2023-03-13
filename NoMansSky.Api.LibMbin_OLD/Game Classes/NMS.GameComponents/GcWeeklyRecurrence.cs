using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcWeeklyRecurrence : NMSTemplate
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

	public GcDay RecurrenceDay
	{
		get => GetValue<GcDay>();
		set => TrySetValue<GcDay>(value);
	}

	public NMSString0x80 DebugText
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcWeeklyRecurrence(long address) : base(address)
	{

	}
}
