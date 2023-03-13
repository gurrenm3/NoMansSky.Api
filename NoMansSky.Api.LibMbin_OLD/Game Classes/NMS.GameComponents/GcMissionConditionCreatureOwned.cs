using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionCreatureOwned : NMSTemplate
{
	public Int32 Amount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public TkEqualityEnum Test
	{
		get => GetValue<TkEqualityEnum>();
		set => TrySetValue<TkEqualityEnum>(value);
	}

	public NMSString0x10 SpecificCreatureID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean AnyPredator
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcMissionConditionCreatureOwned(long address) : base(address)
	{

	}
}
