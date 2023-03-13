using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureRoleFilenameTable : NMSTemplate
{
	public VirtualArray<GcCreatureRoleFilenameList> BiomeFiles
	{
		get => cache.GetOrAddValue(new VirtualArray<GcCreatureRoleFilenameList>(address + GetOffset(), 16));
		set => TrySetValue<GcCreatureRoleFilenameList>(value);
	}

	public GcCreatureRoleFilenameList UnderwaterFiles
	{
		get => GetValue<GcCreatureRoleFilenameList>();
		set => TrySetValue<GcCreatureRoleFilenameList>(value);
	}

	public GcCreatureRoleFilenameList UnderwaterFilesExtra
	{
		get => GetValue<GcCreatureRoleFilenameList>();
		set => TrySetValue<GcCreatureRoleFilenameList>(value);
	}

	public GcCreatureRoleFilenameList CaveFiles
	{
		get => GetValue<GcCreatureRoleFilenameList>();
		set => TrySetValue<GcCreatureRoleFilenameList>(value);
	}

	public GcCreatureRoleFilenameList AirFiles
	{
		get => GetValue<GcCreatureRoleFilenameList>();
		set => TrySetValue<GcCreatureRoleFilenameList>(value);
	}

	public GcCreatureRoleFilenameList RobotFiles
	{
		get => GetValue<GcCreatureRoleFilenameList>();
		set => TrySetValue<GcCreatureRoleFilenameList>(value);
	}

	public VirtualArray<GcCreatureRoleFilenameList> WeirdBiomeFiles
	{
		get => cache.GetOrAddValue(new VirtualArray<GcCreatureRoleFilenameList>(address + GetOffset(), 27));
		set => TrySetValue<GcCreatureRoleFilenameList>(value);
	}

	public VirtualArray<Single> LifeChance
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 4));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> RoleFrequencyModifiers
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 4));
		set => TrySetValue<Single>(value);
	}

	public GcCreatureRoleFilenameTable(long address) : base(address)
	{

	}
}
