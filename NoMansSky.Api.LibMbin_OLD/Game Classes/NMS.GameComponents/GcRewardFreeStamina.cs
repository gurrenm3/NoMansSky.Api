using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardFreeStamina : NMSTemplate
{
	public Single Duration
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcRewardFreeStamina(long address) : base(address)
	{

	}
}
