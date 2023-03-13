using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcInventoryTableEntry : NMSTemplate
{
	public NMSString0x10 Id
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 MinSize
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxSize
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcInventoryLayoutSizeType LayoutSizeType
	{
		get => GetValue<GcInventoryLayoutSizeType>();
		set => TrySetValue<GcInventoryLayoutSizeType>(value);
	}

	public GcInventoryTableEntry(long address) : base(address)
	{

	}
}
