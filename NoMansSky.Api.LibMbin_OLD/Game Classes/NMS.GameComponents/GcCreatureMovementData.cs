using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureMovementData : NMSTemplate
{
	public VirtualList<GcCreatureMoveAnimData> Anims
	{
		get => cache.GetOrAddValue(new VirtualList<GcCreatureMoveAnimData>(address + GetOffset()));
		set => TrySetValue<GcCreatureMoveAnimData>(value);
	}

	public Single MoveRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MoveSpeedScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TurnRadiusScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HeightMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HeightMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HeightTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean Herd
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcCreatureMovementData(long address) : base(address)
	{

	}
}
