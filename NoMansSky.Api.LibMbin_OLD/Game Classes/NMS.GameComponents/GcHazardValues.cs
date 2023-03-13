using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcHazardValues : NMSTemplate
{
	public Single Normal
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Extreme
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcHazardValues(long address) : base(address)
	{

	}
}
