using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcScreenFilterTable : NMSTemplate
{
	public VirtualArray<GcScreenFilterData> Filters
	{
		get => cache.GetOrAddValue(new VirtualArray<GcScreenFilterData>(address + GetOffset(), 82));
		set => TrySetValue<GcScreenFilterData>(value);
	}

	public GcScreenFilterTable(long address) : base(address)
	{

	}
}
