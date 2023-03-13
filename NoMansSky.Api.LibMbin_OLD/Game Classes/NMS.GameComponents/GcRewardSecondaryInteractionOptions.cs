using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardSecondaryInteractionOptions : NMSTemplate
{
	public VirtualList<GcAlienPuzzleOption> Options
	{
		get => cache.GetOrAddValue(new VirtualList<GcAlienPuzzleOption>(address + GetOffset()));
		set => TrySetValue<GcAlienPuzzleOption>(value);
	}

	public GcRewardSecondaryInteractionOptions(long address) : base(address)
	{

	}
}
