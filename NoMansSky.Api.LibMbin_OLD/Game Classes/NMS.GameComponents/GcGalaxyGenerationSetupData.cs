using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcGalaxyGenerationSetupData : NMSTemplate
{
	public Single SpiralFormChance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f SpiralInclusion
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f SpiralFlex
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single SpiralTwistMult
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f SpiralPull
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector2f SpiralSizeScale
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single RareSunChance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f ConnectionAttractorMax
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f ConnectionAttractorMin
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f ConnectionDistortion
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single ConnectionDistortionTMult
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ConnectionDistanceLimit
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f BaseSize
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public VirtualArray<Vector2f> StarSize
	{
		get => cache.GetOrAddValue(new VirtualArray<Vector2f>(address + GetOffset(), 4));
		set => TrySetValue<Vector2f>(value);
	}

	public Single BaseTurbulenceScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BaseTurbulenceLac
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BaseTurbulenceGain
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BaseGenerationThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FieldGenerationThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StarGenerationThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector4f InnerFieldScales
	{
		get => GetValue<Vector4f>();
		set => TrySetValue<Vector4f>(value);
	}

	public Single SizeNoiseScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SizeNoisePower
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SizeField4Inf
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FieldAlphaBase
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FieldAlphaField1Inf
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FieldAlphaField2SqInf
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StarHighlightChance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f StarHighlightAlpha
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f StarHighlightSize
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single ColourBaseBlendOnSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Colour> InnerSectorColours
	{
		get => cache.GetOrAddValue(new VirtualArray<Colour>(address + GetOffset(), 10));
		set => TrySetValue<Colour>(value);
	}

	public GcGalaxyGenerationSetupData(long address) : base(address)
	{

	}
}
