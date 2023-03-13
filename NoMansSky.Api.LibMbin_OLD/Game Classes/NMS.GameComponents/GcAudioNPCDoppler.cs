using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAudioNPCDoppler : NMSTemplate
{
	public VirtualArray<GcAudio3PointDopplerData> Config
	{
		get => cache.GetOrAddValue(new VirtualArray<GcAudio3PointDopplerData>(address + GetOffset(), 7));
		set => TrySetValue<GcAudio3PointDopplerData>(value);
	}

	public GcAudioNPCDoppler(long address) : base(address)
	{

	}
}
