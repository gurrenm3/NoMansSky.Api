using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardDiscoverRune : NMSTemplate
{
	public Boolean AllRunes
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcRewardDiscoverRune(long address) : base(address)
	{

	}
}
