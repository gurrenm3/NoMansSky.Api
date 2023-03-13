using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAudioWwiseRTPCs : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcAudioWwiseRTPCs.AkRTPCEnum AkRTPC
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcAudioWwiseRTPCs.AkRTPCEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcAudioWwiseRTPCs.AkRTPCEnum>(value);
	}

	public GcAudioWwiseRTPCs(long address) : base(address)
	{

	}
}
