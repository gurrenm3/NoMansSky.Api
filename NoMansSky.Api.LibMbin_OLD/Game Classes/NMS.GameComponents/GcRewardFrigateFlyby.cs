using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardFrigateFlyby : NMSTemplate
{
	public GcFrigateFlybyType FlybyType
	{
		get => GetValue<GcFrigateFlybyType>();
		set => TrySetValue<GcFrigateFlybyType>(value);
	}

	public Single AppearanceDelay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x20A CommunicatorOSDLocId
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcPlayerCommunicatorMessage CommunicatorMessage
	{
		get => GetValue<GcPlayerCommunicatorMessage>();
		set => TrySetValue<GcPlayerCommunicatorMessage>(value);
	}

	public TkTextureResource MarkerIcon
	{
		get => GetValue<TkTextureResource>();
		set => TrySetValue<TkTextureResource>(value);
	}

	public GcAudioWwiseEvents PulseAudio
	{
		get => GetValue<GcAudioWwiseEvents>();
		set => TrySetValue<GcAudioWwiseEvents>(value);
	}

	public GcAudioWwiseEvents AudioSting
	{
		get => GetValue<GcAudioWwiseEvents>();
		set => TrySetValue<GcAudioWwiseEvents>(value);
	}

	public NMSString0x10 CameraShake
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcRewardFrigateFlyby(long address) : base(address)
	{

	}
}
