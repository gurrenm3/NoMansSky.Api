using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkTrailData : NMSTemplate
{
	public Single Width
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 Points
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxPointsPerFrame
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single DistanceThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PointLife
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 FrontPoints
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single FrontUvEnd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkTrailData(long address) : base(address)
	{

	}
}
