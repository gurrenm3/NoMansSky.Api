using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNPCWordReactionTable : NMSTemplate
{
	public VirtualArray<GcNPCWordReactionCategory> Races
	{
		get => cache.GetOrAddValue(new VirtualArray<GcNPCWordReactionCategory>(address + GetOffset(), 8));
		set => TrySetValue<GcNPCWordReactionCategory>(value);
	}

	public GcNPCWordReactionTable(long address) : base(address)
	{

	}
}
