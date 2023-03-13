using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSeasonalRingData : NMSTemplate
{
	public Single RingSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RingOpacity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CoreOpacity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcSeasonalRingData(long address) : base(address)
	{

	}
}
