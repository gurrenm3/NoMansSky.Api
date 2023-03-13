using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBiomeFileListOptions : NMSTemplate
{
	public VirtualList<GcBiomeFileListOption> FileOptions
	{
		get => cache.GetOrAddValue(new VirtualList<GcBiomeFileListOption>(address + GetOffset()));
		set => TrySetValue<GcBiomeFileListOption>(value);
	}

	public GcBiomeFileListOptions(long address) : base(address)
	{

	}
}
