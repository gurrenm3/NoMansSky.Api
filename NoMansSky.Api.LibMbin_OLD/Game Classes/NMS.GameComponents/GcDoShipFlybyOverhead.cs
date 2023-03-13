using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDoShipFlybyOverhead : NMSTemplate
{
	public Single Length
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Offset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcDoShipFlybyOverhead(long address) : base(address)
	{

	}
}
