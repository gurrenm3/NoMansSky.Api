using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConsequenceRemoveCommunicatorMessage : NMSTemplate
{
	public NMSString0x20A Comms
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcMissionConsequenceRemoveCommunicatorMessage(long address) : base(address)
	{

	}
}
