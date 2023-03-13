using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBaseLinkGridConnectionData : NMSTemplate
{
	public GcLinkNetworkTypes Network
	{
		get => GetValue<GcLinkNetworkTypes>();
		set => TrySetValue<GcLinkNetworkTypes>(value);
	}

	public Int32 NetworkSubGroup
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 NetworkMask
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single ConnectionDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean UseMinDistance
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualList<Vector3f> LinkSocketPositions
	{
		get => cache.GetOrAddValue(new VirtualList<Vector3f>(address + GetOffset()));
		set => TrySetValue<Vector3f>(value);
	}

	public VirtualList<Int32> LinkSocketSubGroups
	{
		get => cache.GetOrAddValue(new VirtualList<Int32>(address + GetOffset()));
		set => TrySetValue<Int32>(value);
	}

	public GcBaseLinkGridConnectionData(long address) : base(address)
	{

	}
}
