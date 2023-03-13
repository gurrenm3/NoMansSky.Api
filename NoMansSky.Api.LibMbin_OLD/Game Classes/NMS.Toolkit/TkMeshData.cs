using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkMeshData : NMSTemplate
{
	public string IdString
	{
		get => GetValue<String>();
		set => TrySetValue<String>(value);
	}

	public UInt64 Hash
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public Int32 VertexDataSize
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 IndexDataSize
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public VirtualArray<Byte> MeshDataStream
	{
		get => cache.GetOrAddValue(new VirtualArray<Byte>(address + GetOffset(), 1));
		set => TrySetValue<Byte>(value);
	}

	public TkMeshData(long address) : base(address)
	{

	}
}
