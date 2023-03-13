using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAISpaceshipTypes : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcAISpaceshipTypes.ShipTypeEnum ShipType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcAISpaceshipTypes.ShipTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcAISpaceshipTypes.ShipTypeEnum>(value);
	}

	public GcAISpaceshipTypes(long address) : base(address)
	{

	}
}
