using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNPCWordReactionCategory : NMSTemplate
{
	public VirtualArray<GcNPCWordReactionList> Categories
	{
		get => cache.GetOrAddValue(new VirtualArray<GcNPCWordReactionList>(address + GetOffset(), 7));
		set => TrySetValue<GcNPCWordReactionList>(value);
	}

	public GcNPCWordReactionList Fallback
	{
		get => GetValue<GcNPCWordReactionList>();
		set => TrySetValue<GcNPCWordReactionList>(value);
	}

	public GcNPCWordReactionCategory(long address) : base(address)
	{

	}
}
