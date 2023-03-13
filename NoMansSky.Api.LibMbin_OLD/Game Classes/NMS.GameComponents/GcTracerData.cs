using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcTracerData : NMSTemplate
{
	public Single Length
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Speed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DamageMinDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DamageMaxDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DamageMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DamageMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcTracerData(long address) : base(address)
	{

	}
}
