using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class Vector4f : NMSTemplate
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

	public Single z
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single t
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector4f(long address) : base(address)
	{

	}
}
