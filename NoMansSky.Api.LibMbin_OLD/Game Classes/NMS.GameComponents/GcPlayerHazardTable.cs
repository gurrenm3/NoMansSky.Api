using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerHazardTable : NMSTemplate
{
	public VirtualArray<GcPlayerHazardData> Table
	{
		get => cache.GetOrAddValue(new VirtualArray<GcPlayerHazardData>(address + GetOffset(), 6));
		set => TrySetValue<GcPlayerHazardData>(value);
	}

	public GcPlayerHazardTable(long address) : base(address)
	{

	}
}
