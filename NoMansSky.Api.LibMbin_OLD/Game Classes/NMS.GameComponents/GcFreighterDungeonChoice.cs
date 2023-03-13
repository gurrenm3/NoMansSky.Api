using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcFreighterDungeonChoice : NMSTemplate
{
	public NMSString0x10 Name
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single Weighting
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcFreighterDungeonChoice(long address) : base(address)
	{

	}
}
