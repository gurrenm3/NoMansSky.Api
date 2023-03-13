using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkInteractivityData : NMSTemplate
{
	public VirtualList<TkInteractiveSceneData> Scenes
	{
		get => cache.GetOrAddValue(new VirtualList<TkInteractiveSceneData>(address + GetOffset()));
		set => TrySetValue<TkInteractiveSceneData>(value);
	}

	public TkInteractivityData(long address) : base(address)
	{

	}
}
