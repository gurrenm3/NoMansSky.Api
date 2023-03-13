using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNGuiSpecialTextStyles : NMSTemplate
{
	public VirtualList<GcNGuiSpecialTextStyleData> SpecialStyles
	{
		get => cache.GetOrAddValue(new VirtualList<GcNGuiSpecialTextStyleData>(address + GetOffset()));
		set => TrySetValue<GcNGuiSpecialTextStyleData>(value);
	}

	public GcNGuiSpecialTextStyles(long address) : base(address)
	{

	}
}
