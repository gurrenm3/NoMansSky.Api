using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionSequenceTeleport : NMSTemplate
{
	public NMSString0x80 Message
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 DebugText
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcTeleporterType TeleporterType
	{
		get => GetValue<GcTeleporterType>();
		set => TrySetValue<GcTeleporterType>(value);
	}

	public Boolean DoCameraShake
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DoWhiteout
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single SequenceTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EffectTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcMissionSequenceTeleport(long address) : base(address)
	{

	}
}
