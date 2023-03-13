using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerStickData : NMSTemplate
{
	public Single AcceleratorStickPoint
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AcceleratorMinTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Accelerate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AccelerateAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Turn
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TurnFast
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StickyFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcPlayerStickData(long address) : base(address)
	{

	}
}
