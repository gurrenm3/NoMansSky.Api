using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcInputBindingSet : NMSTemplate
{
	public GcActionSetType Type
	{
		get => GetValue<GcActionSetType>();
		set => TrySetValue<GcActionSetType>(value);
	}

	public VirtualList<GcInputBinding> InputBindings
	{
		get => cache.GetOrAddValue(new VirtualList<GcInputBinding>(address + GetOffset()));
		set => TrySetValue<GcInputBinding>(value);
	}

	public GcInputBindingSet(long address) : base(address)
	{

	}
}
