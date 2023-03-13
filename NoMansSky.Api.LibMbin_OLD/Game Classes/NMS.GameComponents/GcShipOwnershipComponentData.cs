using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcShipOwnershipComponentData : NMSTemplate
{
	public GcSpaceshipComponentData Data
	{
		get => GetValue<GcSpaceshipComponentData>();
		set => TrySetValue<GcSpaceshipComponentData>(value);
	}

	public GcShipOwnershipComponentData(long address) : base(address)
	{

	}
}
