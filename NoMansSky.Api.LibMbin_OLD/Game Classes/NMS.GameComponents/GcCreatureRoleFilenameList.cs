using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureRoleFilenameList : NMSTemplate
{
	public VirtualList<GcCreatureRoleFilename> Options
	{
		get => cache.GetOrAddValue(new VirtualList<GcCreatureRoleFilename>(address + GetOffset()));
		set => TrySetValue<GcCreatureRoleFilename>(value);
	}

	public GcCreatureRoleFilenameList(long address) : base(address)
	{

	}
}
