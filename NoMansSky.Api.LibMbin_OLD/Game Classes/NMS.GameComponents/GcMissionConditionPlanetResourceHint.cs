using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionPlanetResourceHint : NMSTemplate
{
	public NMSString0x10 ResourceHint
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcMissionConditionPlanetResourceHint(long address) : base(address)
	{

	}
}
