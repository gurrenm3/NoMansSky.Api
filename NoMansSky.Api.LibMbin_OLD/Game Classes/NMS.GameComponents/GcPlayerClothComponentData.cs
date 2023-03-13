using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerClothComponentData : NMSTemplate
{
	public Boolean Enabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 NumConstraintSolvingIterations
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<GcClothPiece> ClothPieces
	{
		get => cache.GetOrAddValue(new VirtualList<GcClothPiece>(address + GetOffset()));
		set => TrySetValue<GcClothPiece>(value);
	}

	public Single ClothScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CollisionScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttachmentScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcPlayerClothComponentData(long address) : base(address)
	{

	}
}
