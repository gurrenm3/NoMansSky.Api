using Reloaded.ModHelper;
using System;
using libMBIN;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionSchedulingData : NMSTemplate
{
	public NMSTemplate RecurrenceType
	{
		get => GetValue<NMSTemplate>();
		set => TrySetValue<NMSTemplate>(value);
	}

	public GcDate StartDate
	{
		get => GetValue<GcDate>();
		set => TrySetValue<GcDate>(value);
	}

	public GcDate EndDate
	{
		get => GetValue<GcDate>();
		set => TrySetValue<GcDate>(value);
	}

	public Boolean IndependentStart
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean HasEndDate
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public UInt64 EarlyEndOffset
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public VirtualList<NMSString0x10> MissionIDs
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcMissionSchedulingData(long address) : base(address)
	{

	}
}
