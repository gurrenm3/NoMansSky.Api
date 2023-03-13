using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcFiendCrimeAction : NMSTemplate
{
	public GcFiendCrime FiendCrimeType
	{
		get => GetValue<GcFiendCrime>();
		set => TrySetValue<GcFiendCrime>(value);
	}

	public Single FiendCrimeModifier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcFiendCrimeAction(long address) : base(address)
	{

	}
}
