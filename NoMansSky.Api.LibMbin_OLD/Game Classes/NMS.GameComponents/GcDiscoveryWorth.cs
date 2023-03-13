using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDiscoveryWorth : NMSTemplate
{
	public VirtualArray<Int32> Record
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 3));
		set => TrySetValue<Int32>(value);
	}

	public VirtualArray<Int32> OnScan
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 3));
		set => TrySetValue<Int32>(value);
	}

	public Int32 Mission
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcDiscoveryWorth(long address) : base(address)
	{

	}
}
