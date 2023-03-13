using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayAudioAction : NMSTemplate
{
	public NMSString0x80 Sound
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Boolean UseOcclusion
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single OcclusionRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcPlayAudioAction(long address) : base(address)
	{

	}
}
