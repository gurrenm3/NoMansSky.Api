using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNGuiSpecialTextImages : NMSTemplate
{
	public VirtualList<GcNGuiSpecialTextImageData> SpecialImages
	{
		get => cache.GetOrAddValue(new VirtualList<GcNGuiSpecialTextImageData>(address + GetOffset()));
		set => TrySetValue<GcNGuiSpecialTextImageData>(value);
	}

	public GcNGuiSpecialTextImages(long address) : base(address)
	{

	}
}
