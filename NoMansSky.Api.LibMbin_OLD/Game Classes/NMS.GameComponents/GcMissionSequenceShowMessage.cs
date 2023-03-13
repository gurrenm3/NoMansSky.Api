using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionSequenceShowMessage : NMSTemplate
{
	public GcMissionCategory Category
	{
		get => GetValue<GcMissionCategory>();
		set => TrySetValue<GcMissionCategory>(value);
	}

	public Single Time
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x80 Message
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcAudioWwiseEvents AudioEvent
	{
		get => GetValue<GcAudioWwiseEvents>();
		set => TrySetValue<GcAudioWwiseEvents>(value);
	}

	public Single OSDTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x80 OSDMessage
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 OSDMessageSubtitle
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Colour OSDMessageColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public libMBIN.NMS.GameComponents.GcMissionSequenceShowMessage.OSDMessageStyleEnum OSDMessageStyle
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMissionSequenceShowMessage.OSDMessageStyleEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMissionSequenceShowMessage.OSDMessageStyleEnum>(value);
	}

	public Boolean OSDUseMissionIcon
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DisableIcon
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DisableTitlePrefix
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualList<NMSTemplate> UseConditionsForTextFormatting
	{
		get => cache.GetOrAddValue(new VirtualList<NMSTemplate>(address + GetOffset()));
		set => TrySetValue<NMSTemplate>(value);
	}

	public NMSString0x80 DebugText
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcMissionSequenceShowMessage(long address) : base(address)
	{

	}
}
