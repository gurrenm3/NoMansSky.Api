using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcGalaxyRenderSetupData : NMSTemplate
{
	public Colour SunCoreColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single SunCoreSmaller
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SunCoreLarger
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SunCoreBGContrib
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SunCoreFGContrib
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BGCellTraceScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BGCellMoveScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BGCellHorizonInfluence
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BGColourStage1
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BGColourStage2
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BGColourStage3
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BGColourStage4
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BGColourCellBlend
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BGColourPow
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StarFieldBlendAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LensFlareBase
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour LensFlareColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Vector4f LensFlareSpread
	{
		get => GetValue<Vector4f>();
		set => TrySetValue<Vector4f>(value);
	}

	public Single NebulaeAlphaPow
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NebulaeTraceValueMult
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NebulaeTraceScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NebulaeTraceDensity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NebulaeTraceDensityCutoff
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f NebulaeTraceStepRange
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector4f CompositionControlB_S_C_G
	{
		get => GetValue<Vector4f>();
		set => TrySetValue<Vector4f>(value);
	}

	public Single CompositionSaturationIncreaseError
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CompositionSaturationIncreaseFilter
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CompositionSaturationIncreaseSelected
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VignetteSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VignetteBase
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VignetteSizeIncreaseError
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VignetteSizeIncreaseFilter
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VignetteSizeIncreaseSelected
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f LensFlareExpandTowards
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public VirtualArray<Colour> MapLargeAreaPrimaryDefaultColours
	{
		get => cache.GetOrAddValue(new VirtualArray<Colour>(address + GetOffset(), 10));
		set => TrySetValue<Colour>(value);
	}

	public VirtualArray<Colour> MapLargeAreaPrimaryHighContrastColours
	{
		get => cache.GetOrAddValue(new VirtualArray<Colour>(address + GetOffset(), 10));
		set => TrySetValue<Colour>(value);
	}

	public VirtualArray<Colour> MapLargeAreaSecondaryDefaultColours
	{
		get => cache.GetOrAddValue(new VirtualArray<Colour>(address + GetOffset(), 10));
		set => TrySetValue<Colour>(value);
	}

	public VirtualArray<Colour> MapLargeAreaSecondaryHighContrastColours
	{
		get => cache.GetOrAddValue(new VirtualArray<Colour>(address + GetOffset(), 10));
		set => TrySetValue<Colour>(value);
	}

	public GcGalaxyRenderSetupData(long address) : base(address)
	{

	}
}
