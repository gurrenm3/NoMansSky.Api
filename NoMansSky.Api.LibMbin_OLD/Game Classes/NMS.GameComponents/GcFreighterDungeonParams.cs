using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcFreighterDungeonParams : NMSTemplate
{
	public NMSString0x10 Name
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcDungeonGenerationParams DungeonParams
	{
		get => GetValue<GcDungeonGenerationParams>();
		set => TrySetValue<GcDungeonGenerationParams>(value);
	}

	public GcFreighterDungeonParams(long address) : base(address)
	{

	}
}
