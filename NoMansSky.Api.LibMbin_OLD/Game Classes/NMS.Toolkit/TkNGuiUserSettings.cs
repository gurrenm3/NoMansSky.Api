using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkNGuiUserSettings : NMSTemplate
{
	public NMSString0x100 LastLoadedModel
	{
		get => GetValue<NMSString0x100>();
		set => TrySetValue<NMSString0x100>(value);
	}

	public NMSString0x100 LastActiveLayout
	{
		get => GetValue<NMSString0x100>();
		set => TrySetValue<NMSString0x100>(value);
	}

	public VirtualArray<NMSString0x100> FileBrowserRecents
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x100>(address + GetOffset(), 10));
		set => TrySetValue<NMSString0x100>(value);
	}

	public TkNGuiUserSettings(long address) : base(address)
	{

	}
}
