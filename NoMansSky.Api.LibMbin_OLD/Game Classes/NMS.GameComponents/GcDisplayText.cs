using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDisplayText : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcDisplayText.HUDTextDisplayTypeEnum HUDTextDisplayType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcDisplayText.HUDTextDisplayTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcDisplayText.HUDTextDisplayTypeEnum>(value);
	}

	public NMSString0x100 Title
	{
		get => GetValue<NMSString0x100>();
		set => TrySetValue<NMSString0x100>(value);
	}

	public NMSString0x100 Subtitle1
	{
		get => GetValue<NMSString0x100>();
		set => TrySetValue<NMSString0x100>(value);
	}

	public NMSString0x100 Subtitle2
	{
		get => GetValue<NMSString0x100>();
		set => TrySetValue<NMSString0x100>(value);
	}

	public GcAlienRace UseAlienLanguage
	{
		get => GetValue<GcAlienRace>();
		set => TrySetValue<GcAlienRace>(value);
	}

	public VirtualList<NMSString0x20A> ChooseRandomTextOptions
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x20A>(address + GetOffset()));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcDisplayText(long address) : base(address)
	{

	}
}
