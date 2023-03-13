using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureAlertData : NMSTemplate
{
	public GcCreatureTypes AlertTarget
	{
		get => GetValue<GcCreatureTypes>();
		set => TrySetValue<GcCreatureTypes>(value);
	}

	public GcCreatureTypes AlertInitiator
	{
		get => GetValue<GcCreatureTypes>();
		set => TrySetValue<GcCreatureTypes>(value);
	}

	public Single HearingRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SightRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SightAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FleeRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcCreatureAlertData(long address) : base(address)
	{

	}
}
