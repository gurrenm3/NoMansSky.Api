using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcTerrainEditsBuffer : NMSTemplate
{
	public VirtualArray<UInt64> GalacticAddresses
	{
		get => cache.GetOrAddValue(new VirtualArray<UInt64>(address + GetOffset(), 256));
		set => TrySetValue<UInt64>(value);
	}

	public VirtualArray<Int32> BufferSizes
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 256));
		set => TrySetValue<Int32>(value);
	}

	public VirtualArray<Byte> BufferAges
	{
		get => cache.GetOrAddValue(new VirtualArray<Byte>(address + GetOffset(), 256));
		set => TrySetValue<Byte>(value);
	}

	public VirtualArray<Vector3f> BufferAnchors
	{
		get => cache.GetOrAddValue(new VirtualArray<Vector3f>(address + GetOffset(), 256));
		set => TrySetValue<Vector3f>(value);
	}

	public VirtualArray<Boolean> BufferProtected
	{
		get => cache.GetOrAddValue(new VirtualArray<Boolean>(address + GetOffset(), 256));
		set => TrySetValue<Boolean>(value);
	}

	public VirtualArray<GcTerrainEdit> Edits
	{
		get => cache.GetOrAddValue(new VirtualArray<GcTerrainEdit>(address + GetOffset(), 30000));
		set => TrySetValue<GcTerrainEdit>(value);
	}

	public GcTerrainEditsBuffer(long address) : base(address)
	{

	}
}
