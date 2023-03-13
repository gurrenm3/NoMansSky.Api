using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkGeometryData : NMSTemplate
{
	public Int32 VertexCount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 IndexCount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 Indices16Bit
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 CollisionIndexCount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<TkJointBindingData> JointBindings
	{
		get => cache.GetOrAddValue(new VirtualList<TkJointBindingData>(address + GetOffset()));
		set => TrySetValue<TkJointBindingData>(value);
	}

	public VirtualList<TkJointExtentData> JointExtents
	{
		get => cache.GetOrAddValue(new VirtualList<TkJointExtentData>(address + GetOffset()));
		set => TrySetValue<TkJointExtentData>(value);
	}

	public VirtualList<Int32> JointMirrorPairs
	{
		get => cache.GetOrAddValue(new VirtualList<Int32>(address + GetOffset()));
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<TkJointMirrorAxis> JointMirrorAxes
	{
		get => cache.GetOrAddValue(new VirtualList<TkJointMirrorAxis>(address + GetOffset()));
		set => TrySetValue<TkJointMirrorAxis>(value);
	}

	public VirtualList<Int32> SkinMatrixLayout
	{
		get => cache.GetOrAddValue(new VirtualList<Int32>(address + GetOffset()));
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<Int32> MeshVertRStart
	{
		get => cache.GetOrAddValue(new VirtualList<Int32>(address + GetOffset()));
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<Int32> MeshVertREnd
	{
		get => cache.GetOrAddValue(new VirtualList<Int32>(address + GetOffset()));
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<Int32> BoundHullVertSt
	{
		get => cache.GetOrAddValue(new VirtualList<Int32>(address + GetOffset()));
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<Int32> BoundHullVertEd
	{
		get => cache.GetOrAddValue(new VirtualList<Int32>(address + GetOffset()));
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<Int32> MeshBaseSkinMat
	{
		get => cache.GetOrAddValue(new VirtualList<Int32>(address + GetOffset()));
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<Vector4f> MeshAABBMin
	{
		get => cache.GetOrAddValue(new VirtualList<Vector4f>(address + GetOffset()));
		set => TrySetValue<Vector4f>(value);
	}

	public VirtualList<Vector4f> MeshAABBMax
	{
		get => cache.GetOrAddValue(new VirtualList<Vector4f>(address + GetOffset()));
		set => TrySetValue<Vector4f>(value);
	}

	public VirtualList<Vector4f> BoundHullVerts
	{
		get => cache.GetOrAddValue(new VirtualList<Vector4f>(address + GetOffset()));
		set => TrySetValue<Vector4f>(value);
	}

	public TkVertexLayout VertexLayout
	{
		get => GetValue<TkVertexLayout>();
		set => TrySetValue<TkVertexLayout>(value);
	}

	public TkVertexLayout SmallVertexLayout
	{
		get => GetValue<TkVertexLayout>();
		set => TrySetValue<TkVertexLayout>(value);
	}

	public VirtualList<Int32> IndexBuffer
	{
		get => cache.GetOrAddValue(new VirtualList<Int32>(address + GetOffset()));
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<TkMeshMetaData> StreamMetaDataArray
	{
		get => cache.GetOrAddValue(new VirtualList<TkMeshMetaData>(address + GetOffset()));
		set => TrySetValue<TkMeshMetaData>(value);
	}

	public TkGeometryData(long address) : base(address)
	{

	}
}
