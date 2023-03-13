using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardShowBlackHoles : NMSTemplate
{
	public Boolean Dummy
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcRewardShowBlackHoles(long address) : base(address)
	{

	}
}
