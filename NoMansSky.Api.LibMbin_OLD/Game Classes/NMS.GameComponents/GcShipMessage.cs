using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcShipMessage : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcShipMessage.MessageTypeEnum MessageType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcShipMessage.MessageTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcShipMessage.MessageTypeEnum>(value);
	}

	public GcShipMessage(long address) : base(address)
	{

	}
}
