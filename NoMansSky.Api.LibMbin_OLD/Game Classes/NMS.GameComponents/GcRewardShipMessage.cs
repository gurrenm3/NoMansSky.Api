using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardShipMessage : NMSTemplate
{
	public GcShipMessage ShipMessage
	{
		get => GetValue<GcShipMessage>();
		set => TrySetValue<GcShipMessage>(value);
	}

	public GcRewardShipMessage(long address) : base(address)
	{

	}
}
