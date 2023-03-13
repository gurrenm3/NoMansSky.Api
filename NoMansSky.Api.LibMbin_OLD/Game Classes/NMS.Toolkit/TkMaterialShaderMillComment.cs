using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkMaterialShaderMillComment : NMSTemplate
{
	public NMSString0x400 Text
	{
		get => GetValue<NMSString0x400>();
		set => TrySetValue<NMSString0x400>(value);
	}

	public Int32 PosMinX
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 PosMinY
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 PosMaxX
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 PosMaxY
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public TkMaterialShaderMillComment(long address) : base(address)
	{

	}
}
