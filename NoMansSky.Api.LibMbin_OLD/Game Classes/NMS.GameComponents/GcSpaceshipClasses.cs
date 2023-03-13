using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSpaceshipClasses : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcSpaceshipClasses.ShipClassEnum ShipClass
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcSpaceshipClasses.ShipClassEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcSpaceshipClasses.ShipClassEnum>(value);
	}

	public GcSpaceshipClasses(long address) : base(address)
	{

	}
}
