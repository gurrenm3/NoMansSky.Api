using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkLSystemRulesData : NMSTemplate
{
	public VirtualList<TkLSystemGlobalRestriction> GlobalRestriction
	{
		get => cache.GetOrAddValue(new VirtualList<TkLSystemGlobalRestriction>(address + GetOffset()));
		set => TrySetValue<TkLSystemGlobalRestriction>(value);
	}

	public VirtualList<TkLSystemGlobalVariation> GlobalVariation
	{
		get => cache.GetOrAddValue(new VirtualList<TkLSystemGlobalVariation>(address + GetOffset()));
		set => TrySetValue<TkLSystemGlobalVariation>(value);
	}

	public VirtualList<TkLSystemRule> Rules
	{
		get => cache.GetOrAddValue(new VirtualList<TkLSystemRule>(address + GetOffset()));
		set => TrySetValue<TkLSystemRule>(value);
	}

	public VirtualList<TkLSystemRuleTemplate> Templates
	{
		get => cache.GetOrAddValue(new VirtualList<TkLSystemRuleTemplate>(address + GetOffset()));
		set => TrySetValue<TkLSystemRuleTemplate>(value);
	}

	public TkLSystemRulesData(long address) : base(address)
	{

	}
}
