using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcTeleporterType : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcTeleporterType.TeleporterDestinationTypeEnum TeleporterDestinationType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcTeleporterType.TeleporterDestinationTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcTeleporterType.TeleporterDestinationTypeEnum>(value);
	}

	public GcTeleporterType(long address) : base(address)
	{

	}
}
