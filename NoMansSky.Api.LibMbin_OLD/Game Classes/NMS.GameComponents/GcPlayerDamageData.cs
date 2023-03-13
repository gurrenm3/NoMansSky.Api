using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerDamageData : NMSTemplate
{
	public NMSString0x10 Id
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x20A DeathMessage
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x10 DeathStat
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public TkTextureResource HitIcon
	{
		get => GetValue<TkTextureResource>();
		set => TrySetValue<TkTextureResource>(value);
	}

	public NMSString0x20A HitChatMessage
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A HitMessage
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcAudioWwiseEvents HitMessageAudio
	{
		get => GetValue<GcAudioWwiseEvents>();
		set => TrySetValue<GcAudioWwiseEvents>(value);
	}

	public NMSString0x20A CriticalHitMessage
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcAudioWwiseEvents CriticalHitMessageAudio
	{
		get => GetValue<GcAudioWwiseEvents>();
		set => TrySetValue<GcAudioWwiseEvents>(value);
	}

	public Single Damage
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PushForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CameraTurn
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x10 CameraShakeShield
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 CameraShakeNoShield
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean ShowTrackIcon
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ForceDamageInInteraction
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AllowDeathInInteraction
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public libMBIN.NMS.GameComponents.GcPlayerDamageData.PlayerDamageTypeEnum PlayerDamageType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcPlayerDamageData.PlayerDamageTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcPlayerDamageData.PlayerDamageTypeEnum>(value);
	}

	public VirtualList<GcBreakTechByStatData> DamageTechWithStat
	{
		get => cache.GetOrAddValue(new VirtualList<GcBreakTechByStatData>(address + GetOffset()));
		set => TrySetValue<GcBreakTechByStatData>(value);
	}

	public Single TechDamageChance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcPlayerDamageData(long address) : base(address)
	{

	}
}
