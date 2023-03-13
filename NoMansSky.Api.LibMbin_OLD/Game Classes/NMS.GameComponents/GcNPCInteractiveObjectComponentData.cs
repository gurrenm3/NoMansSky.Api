using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNPCInteractiveObjectComponentData : NMSTemplate
{
	public GcNPCInteractiveObjectType InteractiveObjectType
	{
		get => GetValue<GcNPCInteractiveObjectType>();
		set => TrySetValue<GcNPCInteractiveObjectType>(value);
	}

	public Int32 MaxCapacity
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single DurationMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DurationMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<GcNPCInteractiveObjectState> States
	{
		get => cache.GetOrAddValue(new VirtualList<GcNPCInteractiveObjectState>(address + GetOffset()));
		set => TrySetValue<GcNPCInteractiveObjectState>(value);
	}

	public GcNPCInteractiveObjectComponentData(long address) : base(address)
	{

	}
}
