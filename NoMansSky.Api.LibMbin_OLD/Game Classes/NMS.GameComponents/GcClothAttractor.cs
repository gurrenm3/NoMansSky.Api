using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcClothAttractor : NMSTemplate
{
	public Single AttractionStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean UseInitialShapeAsAttractorShape
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single AttractionRadiusAtTop
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttractionRadiusAtBottom
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcCapeLikeInitialShape CapeLikeAttractorShape
	{
		get => GetValue<GcCapeLikeInitialShape>();
		set => TrySetValue<GcCapeLikeInitialShape>(value);
	}

	public GcClothAttractor(long address) : base(address)
	{

	}
}
