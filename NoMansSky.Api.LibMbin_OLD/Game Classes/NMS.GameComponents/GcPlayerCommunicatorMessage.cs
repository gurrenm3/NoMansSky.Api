using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerCommunicatorMessage : NMSTemplate
{
	public NMSString0x20A Dialog
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Boolean ShowHologram
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public libMBIN.NMS.GameComponents.GcPlayerCommunicatorMessage.CommunicatorTypeEnum CommunicatorType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcPlayerCommunicatorMessage.CommunicatorTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcPlayerCommunicatorMessage.CommunicatorTypeEnum>(value);
	}

	public GcAlienRace RaceOverride
	{
		get => GetValue<GcAlienRace>();
		set => TrySetValue<GcAlienRace>(value);
	}

	public NMSString0x20A ShipHUDOverride
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcPlayerCommunicatorMessage(long address) : base(address)
	{

	}
}
