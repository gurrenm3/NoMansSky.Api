using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkMaterialData : NMSTemplate
{
	public NMSString0x80 Name
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x100 Metamaterial
	{
		get => GetValue<NMSString0x100>();
		set => TrySetValue<NMSString0x100>(value);
	}

	public NMSString0x20 Class
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public Int32 TransparencyLayerID
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean CastShadow
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DisableZTest
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean CreateFur
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x80 Link
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 Shader
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public VirtualList<TkMaterialFlags> Flags
	{
		get => cache.GetOrAddValue(new VirtualList<TkMaterialFlags>(address + GetOffset()));
		set => TrySetValue<TkMaterialFlags>(value);
	}

	public VirtualList<TkMaterialUniform> Uniforms
	{
		get => cache.GetOrAddValue(new VirtualList<TkMaterialUniform>(address + GetOffset()));
		set => TrySetValue<TkMaterialUniform>(value);
	}

	public VirtualList<TkMaterialSampler> Samplers
	{
		get => cache.GetOrAddValue(new VirtualList<TkMaterialSampler>(address + GetOffset()));
		set => TrySetValue<TkMaterialSampler>(value);
	}

	public Int64 ShaderMillDataHash
	{
		get => GetValue<Int64>();
		set => TrySetValue<Int64>(value);
	}

	public TkMaterialData(long address) : base(address)
	{

	}
}
