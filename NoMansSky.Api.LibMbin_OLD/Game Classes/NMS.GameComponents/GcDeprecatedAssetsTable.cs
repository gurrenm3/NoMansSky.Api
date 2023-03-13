using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDeprecatedAssetsTable : NMSTemplate
{
	public VirtualList<NMSString0x80> Table
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x80>(address + GetOffset()));
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcDeprecatedAssetsTable(long address) : base(address)
	{

	}
}
