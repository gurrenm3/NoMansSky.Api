using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAlienPodAnimParams : NMSTemplate
{
	public Single Intensity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcAlienPodAnimParams(long address) : base(address)
	{

	}
}
