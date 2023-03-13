using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPulseEncounterSpawnTrader : NMSTemplate
{
	public GcResourceElement CustomShipResource
	{
		get => GetValue<GcResourceElement>();
		set => TrySetValue<GcResourceElement>(value);
	}

	public Boolean UseCustomMessage
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x20A CustomHailOSD
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcPlayerCommunicatorMessage HailingMessage
	{
		get => GetValue<GcPlayerCommunicatorMessage>();
		set => TrySetValue<GcPlayerCommunicatorMessage>(value);
	}

	public GcPulseEncounterSpawnTrader(long address) : base(address)
	{

	}
}
