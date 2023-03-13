using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBoidData : NMSTemplate
{
	public Single Coherence
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Alignment
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Separation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Spacing
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Follow
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DirectionBrake
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InitTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InitOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InitFacingOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LeadTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcBoidData(long address) : base(address)
	{

	}
}
