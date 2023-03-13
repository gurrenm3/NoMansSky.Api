using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCloudProperties : NMSTemplate
{
	public Single HorizonCoverageStart
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HorizonCoverageEnd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour CloudBaseColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour CloudTopColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single LightScalar
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AmbientScalar
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SunRayLength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ConeRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Density
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AmbientDensity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ForwardScatteringG
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BackwardScatteringG
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DarkOutlineScalar
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AnimationScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f WindOffset
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f StratosphereWindOffset
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single BaseScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SampleScalar
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SampleThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CloudBottomFade
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector4f CloudHeightGradient1
	{
		get => GetValue<Vector4f>();
		set => TrySetValue<Vector4f>(value);
	}

	public Vector4f CloudHeightGradient2
	{
		get => GetValue<Vector4f>();
		set => TrySetValue<Vector4f>(value);
	}

	public Vector4f CloudHeightGradient3
	{
		get => GetValue<Vector4f>();
		set => TrySetValue<Vector4f>(value);
	}

	public Single DetailScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ErosionEdgeSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CloudDistortion
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CloudDistortionScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxIterations
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RayMinimumY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LODDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HorizonFadeStartAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HorizonFadeScalar
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HorizonDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcCloudProperties(long address) : base(address)
	{

	}
}
