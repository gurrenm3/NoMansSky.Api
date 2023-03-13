using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDoShipFlybyMineAsteroids : NMSTemplate
{
	public Single Time
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcDoShipFlybyMineAsteroids(long address) : base(address)
	{

	}
}
