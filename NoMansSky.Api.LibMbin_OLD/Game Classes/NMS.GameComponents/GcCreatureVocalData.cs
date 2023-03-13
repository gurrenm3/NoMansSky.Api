using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureVocalData : NMSTemplate
{
	public Single ScaleBias
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcCreatureVocalSoundData IdleVocal
	{
		get => GetValue<GcCreatureVocalSoundData>();
		set => TrySetValue<GcCreatureVocalSoundData>(value);
	}

	public GcCreatureVocalSoundData FleeVocal
	{
		get => GetValue<GcCreatureVocalSoundData>();
		set => TrySetValue<GcCreatureVocalSoundData>(value);
	}

	public GcCreatureVocalSoundData DeathVocal
	{
		get => GetValue<GcCreatureVocalSoundData>();
		set => TrySetValue<GcCreatureVocalSoundData>(value);
	}

	public GcCreatureVocalSoundData AttackVocal
	{
		get => GetValue<GcCreatureVocalSoundData>();
		set => TrySetValue<GcCreatureVocalSoundData>(value);
	}

	public GcCreatureVocalData(long address) : base(address)
	{

	}
}
