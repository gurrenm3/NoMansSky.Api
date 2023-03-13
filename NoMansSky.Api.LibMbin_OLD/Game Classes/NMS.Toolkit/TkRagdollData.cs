using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkRagdollData : NMSTemplate
{
	public Single Density
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Gravity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<NMSString0x20> ChainEnds
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x20>(address + GetOffset()));
		set => TrySetValue<NMSString0x20>(value);
	}

	public VirtualList<NMSString0x20> ExcludeJoints
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x20>(address + GetOffset()));
		set => TrySetValue<NMSString0x20>(value);
	}

	public TkRagdollData(long address) : base(address)
	{

	}
}
