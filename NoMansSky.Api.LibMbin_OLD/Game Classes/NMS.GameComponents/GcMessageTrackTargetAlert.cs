using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMessageTrackTargetAlert : NMSTemplate
{
	public Int32 Attacker
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 Victim
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Vector3f AlertPos
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Boolean Primary
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcMessageTrackTargetAlert(long address) : base(address)
	{

	}
}
