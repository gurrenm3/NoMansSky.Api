using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDefaultMissionItemsTable : NMSTemplate
{
	public VirtualList<GcDefaultMissionSubstance> PrimarySubstances
	{
		get => cache.GetOrAddValue(new VirtualList<GcDefaultMissionSubstance>(address + GetOffset()));
		set => TrySetValue<GcDefaultMissionSubstance>(value);
	}

	public VirtualList<GcDefaultMissionSubstance> SecondarySubstances
	{
		get => cache.GetOrAddValue(new VirtualList<GcDefaultMissionSubstance>(address + GetOffset()));
		set => TrySetValue<GcDefaultMissionSubstance>(value);
	}

	public VirtualList<GcDefaultMissionProduct> PrimaryProducts
	{
		get => cache.GetOrAddValue(new VirtualList<GcDefaultMissionProduct>(address + GetOffset()));
		set => TrySetValue<GcDefaultMissionProduct>(value);
	}

	public VirtualList<GcDefaultMissionProduct> SecondaryProducts
	{
		get => cache.GetOrAddValue(new VirtualList<GcDefaultMissionProduct>(address + GetOffset()));
		set => TrySetValue<GcDefaultMissionProduct>(value);
	}

	public GcDefaultMissionItemsTable(long address) : base(address)
	{

	}
}
