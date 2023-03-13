using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkMaterialUniform : NMSTemplate
{
	public NMSString0x20 Name
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public Vector4f Values
	{
		get => GetValue<Vector4f>();
		set => TrySetValue<Vector4f>(value);
	}

	public VirtualList<Vector4f> ExtendedValues
	{
		get => cache.GetOrAddValue(new VirtualList<Vector4f>(address + GetOffset()));
		set => TrySetValue<Vector4f>(value);
	}

	public TkMaterialUniform(long address) : base(address)
	{

	}
}
