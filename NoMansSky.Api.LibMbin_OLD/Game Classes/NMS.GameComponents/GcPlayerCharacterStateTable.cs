using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerCharacterStateTable : NMSTemplate
{
	public VirtualArray<GcPlayerCharacterStateData> CharacterStates
	{
		get => cache.GetOrAddValue(new VirtualArray<GcPlayerCharacterStateData>(address + GetOffset(), 18));
		set => TrySetValue<GcPlayerCharacterStateData>(value);
	}

	public GcPlayerCharacterStateTable(long address) : base(address)
	{

	}
}
