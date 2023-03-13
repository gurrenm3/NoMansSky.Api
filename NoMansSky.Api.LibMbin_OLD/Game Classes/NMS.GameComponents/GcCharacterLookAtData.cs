using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCharacterLookAtData : NMSTemplate
{
	public Single InteractionLookAtRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureLookAtRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceshipLookAtRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LookAtRunGlanceMinTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LookAtRunGlanceMaxTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LookAtRunMinTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LookAtRunMaxTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LookAtTargetGlanceMinTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LookAtTargetGlanceMaxTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LookAtTargetWaitMinTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LookAtTargetWaitMaxTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LookAtMaxYaw
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LookAtMaxPitch
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcCharacterLookAtData(long address) : base(address)
	{

	}
}
