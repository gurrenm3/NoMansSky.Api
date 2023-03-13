using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardDeath : NMSTemplate
{
	public NMSString0x10 PlayerDamage
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single FadeDuration
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour InitialFadeColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public TkCurveType FadeCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single BlackScreenBeforeQuote
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TimeToSpendDead
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x20A DeathQuote
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A DeathAuthor
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcAudioWwiseEvents AudioEvent
	{
		get => GetValue<GcAudioWwiseEvents>();
		set => TrySetValue<GcAudioWwiseEvents>(value);
	}

	public GcSeasonSaveStateOnDeath SetSeasonSaveState
	{
		get => GetValue<GcSeasonSaveStateOnDeath>();
		set => TrySetValue<GcSeasonSaveStateOnDeath>(value);
	}

	public Boolean OverrideShipSpin
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Vector2f DeathSpinRoll
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f DeathSpinPitch
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public NMSString0x10 CameraShake
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcRewardDeath(long address) : base(address)
	{

	}
}
