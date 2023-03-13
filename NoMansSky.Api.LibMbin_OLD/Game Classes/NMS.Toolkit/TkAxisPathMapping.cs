using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkAxisPathMapping : NMSTemplate
{
	public TkInputAxisEnum Id
	{
		get => GetValue<TkInputAxisEnum>();
		set => TrySetValue<TkInputAxisEnum>(value);
	}

	public NMSString0x20A Name
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x80 SolidIcon
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 OverlayIcon
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 SpecialIcon
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public TkInputHandEnum Hand
	{
		get => GetValue<TkInputHandEnum>();
		set => TrySetValue<TkInputHandEnum>(value);
	}

	public NMSString0x20 OpenVROriginNames
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public TkAxisPathMapping(long address) : base(address)
	{

	}
}
