using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureRoleDescription : NMSTemplate
{
	public GcCreatureRoles Role
	{
		get => GetValue<GcCreatureRoles>();
		set => TrySetValue<GcCreatureRoles>(value);
	}

	public GcCreatureTypes ForceType
	{
		get => GetValue<GcCreatureTypes>();
		set => TrySetValue<GcCreatureTypes>(value);
	}

	public NMSString0x10 ForceID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 RequireTag
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcCreatureSizeClasses MinSize
	{
		get => GetValue<GcCreatureSizeClasses>();
		set => TrySetValue<GcCreatureSizeClasses>(value);
	}

	public GcCreatureSizeClasses MaxSize
	{
		get => GetValue<GcCreatureSizeClasses>();
		set => TrySetValue<GcCreatureSizeClasses>(value);
	}

	public Int32 MinGroupSize
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxGroupSize
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcCreatureGenerationDensity Density
	{
		get => GetValue<GcCreatureGenerationDensity>();
		set => TrySetValue<GcCreatureGenerationDensity>(value);
	}

	public GcCreatureActiveTime ActiveTime
	{
		get => GetValue<GcCreatureActiveTime>();
		set => TrySetValue<GcCreatureActiveTime>(value);
	}

	public Single ProbabilityOfBeingEnabled
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single IncreasedSpawnDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x20A Filter
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcCreatureRoleDescription(long address) : base(address)
	{

	}
}
