using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcInventoryElement : NMSTemplate
{
	public GcInventoryType Type
	{
		get => GetValue<GcInventoryType>();
		set => TrySetValue<GcInventoryType>(value);
	}

	public NMSString0x10 Id
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 Amount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxAmount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single DamageFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean FullyInstalled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcInventoryIndex Index
	{
		get => GetValue<GcInventoryIndex>();
		set => TrySetValue<GcInventoryIndex>(value);
	}

	public GcInventoryElement(long address) : base(address)
	{

	}
}
