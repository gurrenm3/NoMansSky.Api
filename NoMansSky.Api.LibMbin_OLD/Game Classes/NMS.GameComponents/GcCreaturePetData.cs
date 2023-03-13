using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreaturePetData : NMSTemplate
{
	public VirtualList<GcCreaturePetAccessory> AccessorySlots
	{
		get => cache.GetOrAddValue(new VirtualList<GcCreaturePetAccessory>(address + GetOffset()));
		set => TrySetValue<GcCreaturePetAccessory>(value);
	}

	public GcCreaturePetData(long address) : base(address)
	{

	}
}
