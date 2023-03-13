using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureBaitComponentData : NMSTemplate
{
	public VirtualList<NMSString0x10> AttractList
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single BaitStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BaitRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean Debug
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean InducesRage
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcCreatureBaitComponentData(long address) : base(address)
	{

	}
}
