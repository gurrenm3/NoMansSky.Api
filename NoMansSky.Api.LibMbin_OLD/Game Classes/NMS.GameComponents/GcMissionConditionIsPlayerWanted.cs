using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionIsPlayerWanted : NMSTemplate
{
	public Int32 Level
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public TkEqualityEnum Test
	{
		get => GetValue<TkEqualityEnum>();
		set => TrySetValue<TkEqualityEnum>(value);
	}

	public GcMissionConditionIsPlayerWanted(long address) : base(address)
	{

	}
}
