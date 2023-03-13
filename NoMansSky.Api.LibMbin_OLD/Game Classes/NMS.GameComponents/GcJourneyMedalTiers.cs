using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcJourneyMedalTiers : NMSTemplate
{
	public Int32 None
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 Bronze
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 Silver
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 Gold
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcJourneyMedalTiers(long address) : base(address)
	{

	}
}
