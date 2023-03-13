using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDate : NMSTemplate
{
	public Int32 Minute
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 Hour
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 Day
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcMonth Month
	{
		get => GetValue<GcMonth>();
		set => TrySetValue<GcMonth>(value);
	}

	public Int32 Year
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcDate(long address) : base(address)
	{

	}
}
