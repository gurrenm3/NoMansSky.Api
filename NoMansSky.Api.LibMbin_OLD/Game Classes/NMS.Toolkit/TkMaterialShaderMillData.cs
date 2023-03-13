using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkMaterialShaderMillData : NMSTemplate
{
	public VirtualList<TkMaterialShaderMillNode> ShaderMillNodes
	{
		get => cache.GetOrAddValue(new VirtualList<TkMaterialShaderMillNode>(address + GetOffset()));
		set => TrySetValue<TkMaterialShaderMillNode>(value);
	}

	public VirtualList<TkMaterialShaderMillLink> ShaderMillLinks
	{
		get => cache.GetOrAddValue(new VirtualList<TkMaterialShaderMillLink>(address + GetOffset()));
		set => TrySetValue<TkMaterialShaderMillLink>(value);
	}

	public VirtualList<TkMaterialShaderMillFlag> ShaderMillFlags
	{
		get => cache.GetOrAddValue(new VirtualList<TkMaterialShaderMillFlag>(address + GetOffset()));
		set => TrySetValue<TkMaterialShaderMillFlag>(value);
	}

	public VirtualList<TkMaterialShaderMillComment> ShaderMillCmts
	{
		get => cache.GetOrAddValue(new VirtualList<TkMaterialShaderMillComment>(address + GetOffset()));
		set => TrySetValue<TkMaterialShaderMillComment>(value);
	}

	public Single ScrollX
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScrollY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Zoom
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 OutputX
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 OutputY
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public TkMaterialShaderMillData(long address) : base(address)
	{

	}
}
