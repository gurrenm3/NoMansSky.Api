using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBasePartAudioLocation : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcBasePartAudioLocation.BasePartAudioLocationEnum BasePartAudioLocation
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcBasePartAudioLocation.BasePartAudioLocationEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcBasePartAudioLocation.BasePartAudioLocationEnum>(value);
	}

	public GcBasePartAudioLocation(long address) : base(address)
	{

	}
}
