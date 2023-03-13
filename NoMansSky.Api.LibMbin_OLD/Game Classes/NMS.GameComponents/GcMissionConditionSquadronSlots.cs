using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionSquadronSlots : NMSTemplate
{
	public Int32 PilotSlots
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean OnlyCountFreeSlots
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public TkEqualityEnum Test
	{
		get => GetValue<TkEqualityEnum>();
		set => TrySetValue<TkEqualityEnum>(value);
	}

	public Boolean TakeNumberFromSeasonData
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcMissionConditionSquadronSlots(long address) : base(address)
	{

	}
}
