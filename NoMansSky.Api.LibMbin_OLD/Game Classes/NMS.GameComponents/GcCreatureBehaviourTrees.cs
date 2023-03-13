using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureBehaviourTrees : NMSTemplate
{
	public VirtualList<GcCreatureBehaviourTreeData> BehaviourTree
	{
		get => cache.GetOrAddValue(new VirtualList<GcCreatureBehaviourTreeData>(address + GetOffset()));
		set => TrySetValue<GcCreatureBehaviourTreeData>(value);
	}

	public GcCreatureBehaviourTrees(long address) : base(address)
	{

	}
}
