using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPulseEncounterSpawnFrigateFlyby : NMSTemplate
{
	public GcFrigateFlybyType FlybyType
	{
		get => GetValue<GcFrigateFlybyType>();
		set => TrySetValue<GcFrigateFlybyType>(value);
	}

	public NMSString0x20A CommunicatorOSDLocId
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcPlayerCommunicatorMessage CommunicatorMessage
	{
		get => GetValue<GcPlayerCommunicatorMessage>();
		set => TrySetValue<GcPlayerCommunicatorMessage>(value);
	}

	public GcPulseEncounterSpawnFrigateFlyby(long address) : base(address)
	{

	}
}
