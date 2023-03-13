using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionAreDroneHivePartsDestroyed : NMSTemplate
{
	public NMSString0x20A ControllingScanEvent
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcMissionConditionAreDroneHivePartsDestroyed(long address) : base(address)
	{

	}
}
