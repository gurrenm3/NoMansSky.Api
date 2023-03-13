using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAudio3PointDopplerData : NMSTemplate
{
	public Single Front
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Mid
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Rear
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcAudio3PointDopplerData(long address) : base(address)
	{

	}
}
