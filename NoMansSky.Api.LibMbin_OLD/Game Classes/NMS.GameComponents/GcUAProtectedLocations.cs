using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcUAProtectedLocations : NMSTemplate
{
	public UInt64 UA
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public VirtualList<GcProtectedLocation> ProtectedLocations
	{
		get => cache.GetOrAddValue(new VirtualList<GcProtectedLocation>(address + GetOffset()));
		set => TrySetValue<GcProtectedLocation>(value);
	}

	public GcUAProtectedLocations(long address) : base(address)
	{

	}
}
