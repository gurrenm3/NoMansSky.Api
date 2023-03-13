using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkIdArray : NMSTemplate
{
	public VirtualList<NMSString0x10> Array
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public TkIdArray(long address) : base(address)
	{

	}
}
