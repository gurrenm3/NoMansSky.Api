using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcFiendCrime : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcFiendCrime.FiendCrimeEnum FiendCrime
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcFiendCrime.FiendCrimeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcFiendCrime.FiendCrimeEnum>(value);
	}

	public GcFiendCrime(long address) : base(address)
	{

	}
}
