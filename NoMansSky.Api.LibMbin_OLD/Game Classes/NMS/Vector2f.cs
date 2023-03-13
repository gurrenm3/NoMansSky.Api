using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class Vector2f : NMSTemplate
{
	public Single x
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single y
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f(long address) : base(address)
	{

	}
}
