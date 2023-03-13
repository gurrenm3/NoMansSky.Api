using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRichPresenceGlobals : NMSTemplate
{
	public Boolean ShowOnScreen
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single IdleThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EvaluationPeriod
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PublishPeriod
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 PlanetLocationPriority
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 SpaceLocationPriority
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 StormLocationPriority
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 SpaceCombatPriority
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 GameModePriority
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcRichPresenceGlobals(long address) : base(address)
	{

	}
}
