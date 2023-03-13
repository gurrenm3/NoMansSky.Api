using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSentinelWaveGroup : NMSTemplate
{
	public VirtualList<NMSString0x10> Waves
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x10> ExtremeWaves
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcSentinelWaveGroup(long address) : base(address)
	{

	}
}
