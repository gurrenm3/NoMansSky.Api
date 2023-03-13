using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDialogClearanceTable : NMSTemplate
{
	public VirtualList<GcDialogClearanceInfo> Table
	{
		get => cache.GetOrAddValue(new VirtualList<GcDialogClearanceInfo>(address + GetOffset()));
		set => TrySetValue<GcDialogClearanceInfo>(value);
	}

	public GcDialogClearanceTable(long address) : base(address)
	{

	}
}
