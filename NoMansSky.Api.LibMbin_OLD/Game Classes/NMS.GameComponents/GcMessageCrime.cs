using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMessageCrime : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcMessageCrime.CrimeEnum Crime
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMessageCrime.CrimeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMessageCrime.CrimeEnum>(value);
	}

	public Vector3f Position
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public GcNodeID Criminal
	{
		get => GetValue<GcNodeID>();
		set => TrySetValue<GcNodeID>(value);
	}

	public GcNodeID Victim
	{
		get => GetValue<GcNodeID>();
		set => TrySetValue<GcNodeID>(value);
	}

	public Int32 Value
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcMessageCrime(long address) : base(address)
	{

	}
}
