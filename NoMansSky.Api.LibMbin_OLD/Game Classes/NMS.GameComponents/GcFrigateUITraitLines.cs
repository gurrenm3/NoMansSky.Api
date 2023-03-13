using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcFrigateUITraitLines : NMSTemplate
{
	public Single Line0
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Line1
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Line2
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Line3
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Line4
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcFrigateUITraitLines(long address) : base(address)
	{

	}
}
