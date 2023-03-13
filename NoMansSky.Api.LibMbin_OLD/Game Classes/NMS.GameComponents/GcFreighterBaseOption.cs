using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcFreighterBaseOption : NMSTemplate
{
	public NMSString0x80 BaseDataFile
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Single ProbabilityWeighting
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcFreighterBaseOption(long address) : base(address)
	{

	}
}
