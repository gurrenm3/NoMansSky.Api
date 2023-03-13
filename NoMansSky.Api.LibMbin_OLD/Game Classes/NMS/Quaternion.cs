using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class Quaternion : NMSTemplate
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

	public Single w
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Quaternion(long address) : base(address)
	{

	}
}
