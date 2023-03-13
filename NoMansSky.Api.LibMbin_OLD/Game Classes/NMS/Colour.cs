using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class Colour : NMSTemplate
{
	public Single R
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single G
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single B
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single A
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour(long address) : base(address)
	{

	}
}
