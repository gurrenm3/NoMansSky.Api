using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBuildingClusterLayout : NMSTemplate
{
	public NMSString0x10 ID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single RelativeProbability
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<GcBuildingClusterLayoutEntry> ClusterBuildings
	{
		get => cache.GetOrAddValue(new VirtualList<GcBuildingClusterLayoutEntry>(address + GetOffset()));
		set => TrySetValue<GcBuildingClusterLayoutEntry>(value);
	}

	public Int32 AlignmentSteps
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single AlignmentJitter
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcBuildingClusterLayout(long address) : base(address)
	{

	}
}
