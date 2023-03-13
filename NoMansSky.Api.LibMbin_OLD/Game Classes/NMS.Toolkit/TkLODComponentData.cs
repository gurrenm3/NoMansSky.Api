using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkLODComponentData : NMSTemplate
{
	public VirtualList<TkLODModelResource> LODModels
	{
		get => cache.GetOrAddValue(new VirtualList<TkLODModelResource>(address + GetOffset()));
		set => TrySetValue<TkLODModelResource>(value);
	}

	public Single CrossFadeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CrossFadeOverlap
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkLODComponentData(long address) : base(address)
	{

	}
}
