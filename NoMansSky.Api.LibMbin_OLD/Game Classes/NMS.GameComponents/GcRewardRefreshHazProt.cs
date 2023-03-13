using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardRefreshHazProt : NMSTemplate
{
	public Single Amount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean SetNotAdd
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean Silent
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcRewardRefreshHazProt(long address) : base(address)
	{

	}
}
