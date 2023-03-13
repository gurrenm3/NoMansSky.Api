using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPetAccessoryTable : NMSTemplate
{
	public VirtualArray<GcPetAccessoryInfo> Accessories
	{
		get => cache.GetOrAddValue(new VirtualArray<GcPetAccessoryInfo>(address + GetOffset(), 27));
		set => TrySetValue<GcPetAccessoryInfo>(value);
	}

	public VirtualList<GcPetAccessoryGroup> AccessoryGroups
	{
		get => cache.GetOrAddValue(new VirtualList<GcPetAccessoryGroup>(address + GetOffset()));
		set => TrySetValue<GcPetAccessoryGroup>(value);
	}

	public GcPetAccessoryTable(long address) : base(address)
	{

	}
}
