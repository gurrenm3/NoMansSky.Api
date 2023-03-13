using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDifficultyFuelUseTechOverride : NMSTemplate
{
	public NMSString0x10 TechID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single Multiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcDifficultyFuelUseTechOverride(long address) : base(address)
	{

	}
}
