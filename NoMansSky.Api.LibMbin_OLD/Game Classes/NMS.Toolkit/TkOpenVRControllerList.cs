using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkOpenVRControllerList : NMSTemplate
{
	public VirtualList<TkOpenVRControllerLookup> Devices
	{
		get => cache.GetOrAddValue(new VirtualList<TkOpenVRControllerLookup>(address + GetOffset()));
		set => TrySetValue<TkOpenVRControllerLookup>(value);
	}

	public TkOpenVRControllerList(long address) : base(address)
	{

	}
}
