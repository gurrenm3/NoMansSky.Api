using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkAnimPoseExampleData : NMSTemplate
{
	public VirtualList<TkAnimPoseExampleElement> Elements
	{
		get => cache.GetOrAddValue(new VirtualList<TkAnimPoseExampleElement>(address + GetOffset()));
		set => TrySetValue<TkAnimPoseExampleElement>(value);
	}

	public TkAnimPoseExampleData(long address) : base(address)
	{

	}
}
