using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkMaterialShaderMillNode : NMSTemplate
{
	public Int32 Id
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public NMSString0x20 Type
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public NMSString0x20 Value
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public Int32 IValue
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 IValue2
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single FValue
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FValue2
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<TkMaterialShaderMillConnect> Inputs
	{
		get => cache.GetOrAddValue(new VirtualList<TkMaterialShaderMillConnect>(address + GetOffset()));
		set => TrySetValue<TkMaterialShaderMillConnect>(value);
	}

	public VirtualList<TkMaterialShaderMillConnect> Outputs
	{
		get => cache.GetOrAddValue(new VirtualList<TkMaterialShaderMillConnect>(address + GetOffset()));
		set => TrySetValue<TkMaterialShaderMillConnect>(value);
	}

	public Int32 WindowX
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 WindowY
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public TkMaterialShaderMillNode(long address) : base(address)
	{

	}
}
