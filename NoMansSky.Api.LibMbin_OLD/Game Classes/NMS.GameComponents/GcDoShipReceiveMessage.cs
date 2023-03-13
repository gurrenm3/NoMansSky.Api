using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDoShipReceiveMessage : NMSTemplate
{
	public GcShipMessage ShipMessage
	{
		get => GetValue<GcShipMessage>();
		set => TrySetValue<GcShipMessage>(value);
	}

	public GcDoShipReceiveMessage(long address) : base(address)
	{

	}
}
