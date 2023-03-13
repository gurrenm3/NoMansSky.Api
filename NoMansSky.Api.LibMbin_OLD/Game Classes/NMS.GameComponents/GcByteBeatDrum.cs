using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcByteBeatDrum : NMSTemplate
{
	public NMSString0x40 Tree
	{
		get => GetValue<NMSString0x40>();
		set => TrySetValue<NMSString0x40>(value);
	}

	public Single Volume
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Duration
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OctaveShift
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcByteBeatEnvelope AttackEnvelope
	{
		get => GetValue<GcByteBeatEnvelope>();
		set => TrySetValue<GcByteBeatEnvelope>(value);
	}

	public GcByteBeatEnvelope DecayEnvelope
	{
		get => GetValue<GcByteBeatEnvelope>();
		set => TrySetValue<GcByteBeatEnvelope>(value);
	}

	public GcByteBeatWave WaveType
	{
		get => GetValue<GcByteBeatWave>();
		set => TrySetValue<GcByteBeatWave>(value);
	}

	public Single AugmentVolume
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AugmentOverdrive
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AugmentSineNoiseMix
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AugmentPitch
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AugmentPitchFalloff
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AugmentPitchFalloffPower
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public libMBIN.NMS.GameComponents.GcByteBeatDrum.AugmentModeEnum AugmentMode
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcByteBeatDrum.AugmentModeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcByteBeatDrum.AugmentModeEnum>(value);
	}

	public GcByteBeatDrum(long address) : base(address)
	{

	}
}
