using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDefaultMissionSubstance : NMSTemplate
{
	public NMSString0x10 Substance
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcDefaultMissionSubstance(long address) : base(address)
	{

	}
}
