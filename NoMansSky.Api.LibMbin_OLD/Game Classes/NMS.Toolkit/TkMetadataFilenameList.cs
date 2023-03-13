using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkMetadataFilenameList : NMSTemplate
{
	public VirtualList<NMSString0x80> Filenames
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x80>(address + GetOffset()));
		set => TrySetValue<NMSString0x80>(value);
	}

	public TkMetadataFilenameList(long address) : base(address)
	{

	}
}
