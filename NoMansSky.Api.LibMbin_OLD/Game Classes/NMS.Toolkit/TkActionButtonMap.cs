using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkActionButtonMap : NMSTemplate
{
	public NMSString0x10 ActionId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean ScaleToFitFont
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public TkInputEnum PadButtonId
	{
		get => GetValue<TkInputEnum>();
		set => TrySetValue<TkInputEnum>(value);
	}

	public VirtualList<TkPlatformButtonPair> Platforms
	{
		get => cache.GetOrAddValue(new VirtualList<TkPlatformButtonPair>(address + GetOffset()));
		set => TrySetValue<TkPlatformButtonPair>(value);
	}

	public TkActionButtonMap(long address) : base(address)
	{

	}
}
