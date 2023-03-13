using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionSequenceDetailMessage : NMSTemplate
{
	public NMSString0x20A Title
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A Description
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A Image
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcAudioWwiseEvents AudioEvent
	{
		get => GetValue<GcAudioWwiseEvents>();
		set => TrySetValue<GcAudioWwiseEvents>(value);
	}

	public VirtualList<GcMissionSequenceDetailMessagePoint> Points
	{
		get => cache.GetOrAddValue(new VirtualList<GcMissionSequenceDetailMessagePoint>(address + GetOffset()));
		set => TrySetValue<GcMissionSequenceDetailMessagePoint>(value);
	}

	public NMSString0x80 DebugText
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcMissionSequenceDetailMessage(long address) : base(address)
	{

	}
}
