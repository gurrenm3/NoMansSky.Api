using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkLSystemInnerRule : NMSTemplate
{
	public NMSString0x20 LocatorType
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public libMBIN.NMS.Toolkit.TkLSystemInnerRule.MergeProbabilityOptionsEnum MergeProbabilityOptions
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkLSystemInnerRule.MergeProbabilityOptionsEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkLSystemInnerRule.MergeProbabilityOptionsEnum>(value);
	}

	public VirtualList<TkLSystemLocatorEntry> Entries
	{
		get => cache.GetOrAddValue(new VirtualList<TkLSystemLocatorEntry>(address + GetOffset()));
		set => TrySetValue<TkLSystemLocatorEntry>(value);
	}

	public TkLSystemInnerRule(long address) : base(address)
	{

	}
}
