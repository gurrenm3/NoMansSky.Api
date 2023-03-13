using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkCreatureTailJoints : NMSTemplate
{
	public NMSString0x20 StartJoint
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public NMSString0x20 EndJoint
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public Single InterpSpeedHead
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InterpSpeedTail
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PullSpeedMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PullSpeedMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StrengthX
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StrengthY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StrengthZ
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SwimPhaseOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCreatureTailJoints(long address) : base(address)
	{

	}
}
