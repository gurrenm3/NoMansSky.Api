using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureVocalSoundData : NMSTemplate
{
	public NMSString0x10 Id
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public libMBIN.NMS.GameComponents.GcCreatureVocalSoundData.VocalEmoteEnum VocalEmote
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcCreatureVocalSoundData.VocalEmoteEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcCreatureVocalSoundData.VocalEmoteEnum>(value);
	}

	public Single PlayFrequency
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinCooldown
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxCooldown
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean PlayImmediately
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean PlayOnlyOnce
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcCreatureVocalSoundData(long address) : base(address)
	{

	}
}
