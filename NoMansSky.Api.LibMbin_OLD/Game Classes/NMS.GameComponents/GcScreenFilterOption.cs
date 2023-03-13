using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcScreenFilterOption : NMSTemplate
{
	public GcScreenFilters Filter
	{
		get => GetValue<GcScreenFilters>();
		set => TrySetValue<GcScreenFilters>(value);
	}

	public Single Weight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcScreenFilterOption(long address) : base(address)
	{

	}
}
