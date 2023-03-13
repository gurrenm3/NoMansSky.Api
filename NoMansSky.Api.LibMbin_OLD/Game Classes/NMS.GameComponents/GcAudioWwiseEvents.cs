using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAudioWwiseEvents : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcAudioWwiseEvents.AkEventEnum AkEvent
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcAudioWwiseEvents.AkEventEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcAudioWwiseEvents.AkEventEnum>(value);
	}

	public GcAudioWwiseEvents(long address) : base(address)
	{

	}
}
