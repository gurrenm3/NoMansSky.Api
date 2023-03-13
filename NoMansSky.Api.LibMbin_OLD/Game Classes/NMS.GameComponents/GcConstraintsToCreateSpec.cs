using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcConstraintsToCreateSpec : NMSTemplate
{
	public Boolean Horizontal_1x0
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single PushingStrength_Horizontal_1x0
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean Vertical_1x0
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single PushingStrength_Vertical_1x0
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean Diagonal_1x1_0011
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single PushingStrength_Diagonal_1x1_0011
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean Diagonal_1x1_0110
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single PushingStrength_Diagonal_1x1_0110
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean Horizontal_2x0
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single PushingStrength_Horizontal_2x0
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean Vertical_2x0
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single PushingStrength_Vertical_2x0
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean SkewedDiagonal_2x1_0021
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single PushingStrength_SkewedDiagonal_2x1_0021
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean SkewedDiagonal_2x1_2001
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single PushingStrength_SkewedDiagonal_2x1_2001
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean SkewedDiagonal_2x1_1002
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single PushingStrength_SkewedDiagonal_2x1_1002
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean SkewedDiagonal_2x1_0012
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single PushingStrength_SkewedDiagonal_2x1_0012
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcConstraintsToCreateSpec(long address) : base(address)
	{

	}
}
