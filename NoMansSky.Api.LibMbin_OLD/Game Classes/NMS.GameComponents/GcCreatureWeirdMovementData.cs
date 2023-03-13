using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureWeirdMovementData : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcCreatureWeirdMovementData.MoveModeEnum MoveMode
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcCreatureWeirdMovementData.MoveModeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcCreatureWeirdMovementData.MoveModeEnum>(value);
	}

	public NMSString0x100 Node
	{
		get => GetValue<NMSString0x100>();
		set => TrySetValue<NMSString0x100>(value);
	}

	public Single BobSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BobAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpinSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single JumpAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<NMSString0x100> FeetNames
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x100>(address + GetOffset()));
		set => TrySetValue<NMSString0x100>(value);
	}

	public GcCreatureWeirdMovementData(long address) : base(address)
	{

	}
}
