using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkCreatureTailParams : NMSTemplate
{
	public NMSString0x20A PartName
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualList<TkCreatureTailJoints> Joints
	{
		get => cache.GetOrAddValue(new VirtualList<TkCreatureTailJoints>(address + GetOffset()));
		set => TrySetValue<TkCreatureTailJoints>(value);
	}

	public Single AnimationMix
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SwimSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SwimReps
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxTurnForSwim
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SwimBlendInTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SwimBlendOutTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SwimMagnitude
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SwimRollMagnitude
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SwimFallOffBegin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SwimFallOffEnd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinSwimStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean HorizontalStrokes
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualList<Single> PerBoneSwimStrength
	{
		get => cache.GetOrAddValue(new VirtualList<Single>(address + GetOffset()));
		set => TrySetValue<Single>(value);
	}

	public TkCreatureTailParams(long address) : base(address)
	{

	}
}
