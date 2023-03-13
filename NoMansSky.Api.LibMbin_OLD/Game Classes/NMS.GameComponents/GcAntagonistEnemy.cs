using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAntagonistEnemy : NMSTemplate
{
	public Single HatredFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GrudgeFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<NMSString0x10> Perceptions
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcAntagonistEnemy(long address) : base(address)
	{

	}
}
