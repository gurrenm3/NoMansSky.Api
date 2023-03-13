using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcHUDComponent : NMSTemplate
{
	public NMSString0x10 ID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 PosX
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 PosY
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 Width
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 Height
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public libMBIN.NMS.GameComponents.GcHUDComponent.AlignEnum Align
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcHUDComponent.AlignEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcHUDComponent.AlignEnum>(value);
	}

	public GcHUDComponent(long address) : base(address)
	{

	}
}
