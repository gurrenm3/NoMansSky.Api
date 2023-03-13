using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcExpeditionDurationValues : NMSTemplate
{
	public VirtualArray<Int32> Duration
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 5));
		set => TrySetValue<Int32>(value);
	}

	public GcExpeditionDurationValues(long address) : base(address)
	{

	}
}
