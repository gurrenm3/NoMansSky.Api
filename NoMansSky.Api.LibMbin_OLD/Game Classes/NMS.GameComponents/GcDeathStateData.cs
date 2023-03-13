using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDeathStateData : NMSTemplate
{
	public VirtualList<GcDeathQuote> Quotes
	{
		get => cache.GetOrAddValue(new VirtualList<GcDeathQuote>(address + GetOffset()));
		set => TrySetValue<GcDeathQuote>(value);
	}

	public GcTextPreset ReasonFont
	{
		get => GetValue<GcTextPreset>();
		set => TrySetValue<GcTextPreset>(value);
	}

	public GcTextPreset QuoteFont
	{
		get => GetValue<GcTextPreset>();
		set => TrySetValue<GcTextPreset>(value);
	}

	public GcTextPreset AuthorFont
	{
		get => GetValue<GcTextPreset>();
		set => TrySetValue<GcTextPreset>(value);
	}

	public GcDeathStateData(long address) : base(address)
	{

	}
}
