using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreaturePetTraitRange : NMSTemplate
{
	public Single Min
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Max
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcCreaturePetTraitRange(long address) : base(address)
	{

	}
}
