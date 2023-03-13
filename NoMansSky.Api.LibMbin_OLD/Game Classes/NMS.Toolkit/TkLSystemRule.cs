using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkLSystemRule : NMSTemplate
{
	public NMSString0x20 Name
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public NMSString0x80 Model
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public VirtualList<TkLSystemInnerRule> Rules
	{
		get => cache.GetOrAddValue(new VirtualList<TkLSystemInnerRule>(address + GetOffset()));
		set => TrySetValue<TkLSystemInnerRule>(value);
	}

	public libMBIN.NMS.Toolkit.TkLSystemRule.RuleTypeEnum RuleType
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkLSystemRule.RuleTypeEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkLSystemRule.RuleTypeEnum>(value);
	}

	public TkLSystemRule(long address) : base(address)
	{

	}
}
