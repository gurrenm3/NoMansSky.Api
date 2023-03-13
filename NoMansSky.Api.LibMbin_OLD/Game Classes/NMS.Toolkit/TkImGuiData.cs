using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkImGuiData : NMSTemplate
{
	public TkImGuiWindowData MainWindow
	{
		get => GetValue<TkImGuiWindowData>();
		set => TrySetValue<TkImGuiWindowData>(value);
	}

	public Boolean Maximised
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 DimensionX
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 DimensionY
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public VirtualArray<NMSString0x80> RecentToolbox
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x80>(address + GetOffset(), 10));
		set => TrySetValue<NMSString0x80>(value);
	}

	public VirtualArray<TkImGuiWindowData> WindowTable
	{
		get => cache.GetOrAddValue(new VirtualArray<TkImGuiWindowData>(address + GetOffset(), 128));
		set => TrySetValue<TkImGuiWindowData>(value);
	}

	public Int32 WindowCount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public TkImGuiData(long address) : base(address)
	{

	}
}
