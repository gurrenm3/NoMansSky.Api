using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureGenerationDomainTable : NMSTemplate
{
	public NMSString0x10 Id
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<GcCreatureGenerationDomainEntry> Tables
	{
		get => cache.GetOrAddValue(new VirtualList<GcCreatureGenerationDomainEntry>(address + GetOffset()));
		set => TrySetValue<GcCreatureGenerationDomainEntry>(value);
	}

	public Single ChanceOfHemisphereLimit
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 MaxToHemisphereLimit
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcCreatureGenerationDomainTable(long address) : base(address)
	{

	}
}
