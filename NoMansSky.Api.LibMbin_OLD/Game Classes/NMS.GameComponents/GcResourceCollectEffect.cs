using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcResourceCollectEffect : NMSTemplate
{
	public Single PlayerOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SizeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SizeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RotateMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RotateMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StartOffsetMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StartOffsetMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TimeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TimeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StartSpeedMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StartSpeedMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OffsetMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OffsetMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcResourceCollectEffect(long address) : base(address)
	{

	}
}
