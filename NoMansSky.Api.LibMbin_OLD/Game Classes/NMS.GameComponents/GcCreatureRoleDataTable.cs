using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureRoleDataTable : NMSTemplate
{
	public VirtualList<GcCreatureRoleData> AvailableRoles
	{
		get => cache.GetOrAddValue(new VirtualList<GcCreatureRoleData>(address + GetOffset()));
		set => TrySetValue<GcCreatureRoleData>(value);
	}

	public Single MaxProportionFlying
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean HasSandWorms
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single SandWormFrequency
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcCreatureRoleDataTable(long address) : base(address)
	{

	}
}
