using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSmokeBotReport : NMSTemplate
{
	public UInt64 StartingUA
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public VirtualList<GcSmokeBotSystemReport> Systems
	{
		get => cache.GetOrAddValue(new VirtualList<GcSmokeBotSystemReport>(address + GetOffset()));
		set => TrySetValue<GcSmokeBotSystemReport>(value);
	}

	public GcSmokeBotReport(long address) : base(address)
	{

	}
}
