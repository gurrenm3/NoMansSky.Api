using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkMaterialMetaData : NMSTemplate
{
	public NMSString0x80 ExternalMaterial
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public libMBIN.NMS.Toolkit.TkMaterialMetaData.ShaderEnum Shader
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkMaterialMetaData.ShaderEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkMaterialMetaData.ShaderEnum>(value);
	}

	public Boolean Transparent
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 TransparencyLayerID
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean Additive
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean VertexColour
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DisableZTest
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean Unlit
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ReceiveShadow
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean CastShadow
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ShadowOnly
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UISurface
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single Roughness
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean RoughnessMask
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean Metallic
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean MetallicMask
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SubsurfaceMask
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x20 MaterialClass
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public NMSString0x80 ForceDiffuse
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 ForceNormal
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 ForceMask
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 ForceFeature
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 DetailDiffuse
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 DetailNormal
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Single DetailTiling
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MultiplyDetailTiling
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 DetailImages
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MultiplyDetailImages
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean AOMap
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean MultiplySecondUVSet
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean VertexDetailBlend
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single DetailHeightBlend
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NormalTiling
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean SpaceObject
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single Glow
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean GlowMask
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean BrightEdge
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean CameraRelative
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean Colourisable
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ColourMask
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean Multitexture
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean FeatureMap
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AlphaCutout
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DetailedAlphaCutout
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean Wind
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean EnvironmentalOverlay
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean MatchGroundColour
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single TerrainNormalFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SoftFadeStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean ScreenSpaceFade
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AcuteAngleFadeOut
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ClampAmbientLight
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DoubleSided
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DecalDiffuse
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DecalTerrainOnly
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public libMBIN.NMS.Toolkit.TkMaterialMetaData.DecalNormalEnum DecalNormal
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkMaterialMetaData.DecalNormalEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkMaterialMetaData.DecalNormalEnum>(value);
	}

	public Boolean Billboard
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean RotateAroundAt
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean MergedMeshBillboard
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single BillboardSphereFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean Imposter
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ScanEffect
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean WriteLogZ
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DisableAmbient
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DisablePostProcess
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean WarpedDiffuseLighting
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AnisotropicFilter
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single TessellationHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean Dissolve
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean InvertAlpha
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean BeforeUI
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DepthMaskUI
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AlwaysOnTopUI
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ScreenSpaceReflections
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ReflectionProbe
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DrawToBloom
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DrawToLensFlare
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DoubleBufferGeometry
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean CreateFur
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single ShellsHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FurNoiseScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FurNoiseThickness
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FurNoiseTurbulence
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FurTurbulenceScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean StretchyParticle
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UVScrolling
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single UVScrollX
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UVScrollY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UVScrollNormalX
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UVScrollNormalY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UVFrameTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean UVAnimation
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UVTileAlts
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single UVNumTilesX
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UVNumTilesY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Refraction
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RefractionIndex
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean RefractionMask
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single ParticleRefractionStrengthX
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ParticleRefractionStrengthY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ParticleRefractionBrightnessMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ParticleRefractionTint
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean ParallaxMapped
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single ParallaxDepth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 NumSteps
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean SelfShadow
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single ShadowFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean DisplacementWave
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DisplacementPositionOffset
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single WaveOneSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f WaveOneAmplitude
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f WaveOneFrequency
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f WaveOneFallOff
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single WaveTwoSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f WaveTwoAmplitude
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f WaveTwoFrequency
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f WaveTwoFallOff
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public TkMaterialShaderMillData ShaderMillData
	{
		get => GetValue<TkMaterialShaderMillData>();
		set => TrySetValue<TkMaterialShaderMillData>(value);
	}

	public TkMaterialMetaData(long address) : base(address)
	{

	}
}
