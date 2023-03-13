using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcWorldUISettings : NMSTemplate
{
	public Single UIWorldQuadOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UIWorldQuadOffsetBuildMenu
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UIWorldQuadSideOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UIWorldQuadShipAddOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UIWorldQuadScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UIWorldQuadShipScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDWorldQuadOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDWorldQuadShipAddOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDWorldQuadScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDWorldQuadShipScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDInterpSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDThresholdVert
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDThresholdHorz
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcWorldUISettings(long address) : base(address)
	{

	}
}
