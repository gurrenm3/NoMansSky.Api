using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCombatEffectData : NMSTemplate
{
	public NMSString0x10 DamageId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 ParticlesId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcAudioWwiseEvents StartAudio
	{
		get => GetValue<GcAudioWwiseEvents>();
		set => TrySetValue<GcAudioWwiseEvents>(value);
	}

	public GcAudioWwiseEvents EndAudio
	{
		get => GetValue<GcAudioWwiseEvents>();
		set => TrySetValue<GcAudioWwiseEvents>(value);
	}

	public GcStatsTypes Stat
	{
		get => GetValue<GcStatsTypes>();
		set => TrySetValue<GcStatsTypes>(value);
	}

	public Boolean OverrideDamageNumberData
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single DamageMergeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DamageTimeBetweenNumbers
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DamageMinDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcCombatEffectData(long address) : base(address)
	{

	}
}
