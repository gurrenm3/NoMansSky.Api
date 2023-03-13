using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcVehicleRaceInviteComponentData : NMSTemplate
{
	public Single Radius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcVehicleRaceInviteComponentData(long address) : base(address)
	{

	}
}
