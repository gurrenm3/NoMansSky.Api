using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNGuiSpecialTextStyleData : NMSTemplate
{
	public NMSString0x10 Name
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSTemplate> StyleProperties
	{
		get => cache.GetOrAddValue(new VirtualList<NMSTemplate>(address + GetOffset()));
		set => TrySetValue<NMSTemplate>(value);
	}

	public GcNGuiStyleAnimationData Animation
	{
		get => GetValue<GcNGuiStyleAnimationData>();
		set => TrySetValue<GcNGuiStyleAnimationData>(value);
	}

	public GcNGuiSpecialTextStyleData(long address) : base(address)
	{

	}
}
