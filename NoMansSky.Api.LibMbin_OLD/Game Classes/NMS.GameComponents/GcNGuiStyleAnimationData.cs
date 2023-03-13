using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNGuiStyleAnimationData : NMSTemplate
{
	public Single Length
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean Loop
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AnimateByDefault
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualList<GcNGuiStyleAnimationKeyframeData> KeyFrames
	{
		get => cache.GetOrAddValue(new VirtualList<GcNGuiStyleAnimationKeyframeData>(address + GetOffset()));
		set => TrySetValue<GcNGuiStyleAnimationKeyframeData>(value);
	}

	public GcNGuiStyleAnimationData(long address) : base(address)
	{

	}
}
