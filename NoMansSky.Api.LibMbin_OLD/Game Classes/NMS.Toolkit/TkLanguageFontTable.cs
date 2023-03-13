using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkLanguageFontTable : NMSTemplate
{
	public VirtualList<TkLanguageFontTableEntry> Table
	{
		get => cache.GetOrAddValue(new VirtualList<TkLanguageFontTableEntry>(address + GetOffset()));
		set => TrySetValue<TkLanguageFontTableEntry>(value);
	}

	public TkLanguageFontTable(long address) : base(address)
	{

	}
}
