using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionIsScanEventActive : NMSTemplate
{
	public NMSString0x20A Event
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Boolean MustMatchThisMissionSeed
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcMissionConditionIsScanEventActive(long address) : base(address)
	{

	}
}
