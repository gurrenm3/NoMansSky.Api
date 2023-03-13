using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkAnimNodeData : NMSTemplate
{
	public NMSString0x40 Node
	{
		get => GetValue<NMSString0x40>();
		set => TrySetValue<NMSString0x40>(value);
	}

	public Boolean CanCompress
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 RotIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 TransIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 ScaleIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public TkAnimNodeData(long address) : base(address)
	{

	}
}
