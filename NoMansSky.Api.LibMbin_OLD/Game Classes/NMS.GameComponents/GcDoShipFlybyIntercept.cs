using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDoShipFlybyIntercept : NMSTemplate
{
	public Single Speed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Time
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcDoShipFlybyIntercept(long address) : base(address)
	{

	}
}
