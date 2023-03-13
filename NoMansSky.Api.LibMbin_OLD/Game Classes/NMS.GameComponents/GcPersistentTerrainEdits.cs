using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPersistentTerrainEdits : NMSTemplate
{
	public UInt64 GalacticAddress
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public VirtualList<Int32> BufferSizes
	{
		get => cache.GetOrAddValue(new VirtualList<Int32>(address + GetOffset()));
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<Vector3f> BufferAnchors
	{
		get => cache.GetOrAddValue(new VirtualList<Vector3f>(address + GetOffset()));
		set => TrySetValue<Vector3f>(value);
	}

	public VirtualList<GcTerrainEdit> Edits
	{
		get => cache.GetOrAddValue(new VirtualList<GcTerrainEdit>(address + GetOffset()));
		set => TrySetValue<GcTerrainEdit>(value);
	}

	public GcPersistentTerrainEdits(long address) : base(address)
	{

	}
}
