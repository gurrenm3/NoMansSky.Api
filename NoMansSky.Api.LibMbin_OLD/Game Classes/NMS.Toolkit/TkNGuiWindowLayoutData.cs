using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkNGuiWindowLayoutData : NMSTemplate
{
	public NMSString0x80 Name
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Single PositionX
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PositionY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SizeX
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SizeY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Separator
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public libMBIN.NMS.Toolkit.TkNGuiWindowLayoutData.WindowStateEnum WindowState
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkNGuiWindowLayoutData.WindowStateEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkNGuiWindowLayoutData.WindowStateEnum>(value);
	}

	public VirtualArray<NMSString0x80> Tabs
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x80>(address + GetOffset(), 32));
		set => TrySetValue<NMSString0x80>(value);
	}

	public Int32 ActiveTabIdx
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
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

	public TkNGuiWindowLayoutData(long address) : base(address)
	{

	}
}
