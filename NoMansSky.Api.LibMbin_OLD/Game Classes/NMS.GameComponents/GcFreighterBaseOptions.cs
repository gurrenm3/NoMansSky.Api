using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcFreighterBaseOptions : NMSTemplate
{
	public VirtualList<GcFreighterBaseOption> FreighterBases
	{
		get => cache.GetOrAddValue(new VirtualList<GcFreighterBaseOption>(address + GetOffset()));
		set => TrySetValue<GcFreighterBaseOption>(value);
	}

	public GcFreighterBaseOptions(long address) : base(address)
	{

	}
}
