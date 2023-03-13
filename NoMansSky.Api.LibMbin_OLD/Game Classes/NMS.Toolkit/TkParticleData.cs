using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkParticleData : NMSTemplate
{
	public UInt32 AudioEvent
	{
		get => GetValue<UInt32>();
		set => TrySetValue<UInt32>(value);
	}

	public Boolean StartEnabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean Oneshot
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 MaxCount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public TkParticleBurstData BurstData
	{
		get => GetValue<TkParticleBurstData>();
		set => TrySetValue<TkParticleBurstData>(value);
	}

	public TkEmitterFloatProperty EmissionRate
	{
		get => GetValue<TkEmitterFloatProperty>();
		set => TrySetValue<TkEmitterFloatProperty>(value);
	}

	public Single Delay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkEmitFromParticleInfo EmitFromParticleInfo
	{
		get => GetValue<TkEmitFromParticleInfo>();
		set => TrySetValue<TkEmitFromParticleInfo>(value);
	}

	public TkEmitterFloatProperty ParticleLife
	{
		get => GetValue<TkEmitterFloatProperty>();
		set => TrySetValue<TkEmitterFloatProperty>(value);
	}

	public TkEmitterFloatProperty EmitterLife
	{
		get => GetValue<TkEmitterFloatProperty>();
		set => TrySetValue<TkEmitterFloatProperty>(value);
	}

	public Single EmitterMidLifeRatio
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType EmitterLifeCurve1
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public TkCurveType EmitterLifeCurve2
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single EmitterSpreadAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EmitterSpreadAngleMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f EmitterDirection
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public TkEmitterFloatProperty ParticleSpeedMultiplier
	{
		get => GetValue<TkEmitterFloatProperty>();
		set => TrySetValue<TkEmitterFloatProperty>(value);
	}

	public TkEmitterFloatProperty ParticleGravity
	{
		get => GetValue<TkEmitterFloatProperty>();
		set => TrySetValue<TkEmitterFloatProperty>(value);
	}

	public TkEmitterFloatProperty ParticleDamping
	{
		get => GetValue<TkEmitterFloatProperty>();
		set => TrySetValue<TkEmitterFloatProperty>(value);
	}

	public TkEmitterFloatProperty ParticleDrag
	{
		get => GetValue<TkEmitterFloatProperty>();
		set => TrySetValue<TkEmitterFloatProperty>(value);
	}

	public libMBIN.NMS.Toolkit.TkParticleData.DragTypeEnum DragType
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkParticleData.DragTypeEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkParticleData.DragTypeEnum>(value);
	}

	public Single Variation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StartOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public libMBIN.NMS.Toolkit.TkParticleData.SpawnOffsetTypeEnum SpawnOffsetType
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkParticleData.SpawnOffsetTypeEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkParticleData.SpawnOffsetTypeEnum>(value);
	}

	public Vector3f SpawnOffsetParams
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public TkEmitterFloatProperty ParticleSize
	{
		get => GetValue<TkEmitterFloatProperty>();
		set => TrySetValue<TkEmitterFloatProperty>(value);
	}

	public TkEmitterFloatProperty ParticleSizeY
	{
		get => GetValue<TkEmitterFloatProperty>();
		set => TrySetValue<TkEmitterFloatProperty>(value);
	}

	public Single StartRotationVariation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkEmitterFloatProperty Rotation
	{
		get => GetValue<TkEmitterFloatProperty>();
		set => TrySetValue<TkEmitterFloatProperty>(value);
	}

	public libMBIN.NMS.Toolkit.TkParticleData.AlignmentEnum Alignment
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkParticleData.AlignmentEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkParticleData.AlignmentEnum>(value);
	}

	public libMBIN.NMS.Toolkit.TkParticleData.BillboardAlignmentEnum BillboardAlignment
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkParticleData.BillboardAlignmentEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkParticleData.BillboardAlignmentEnum>(value);
	}

	public Vector3f RotationPivot
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public TkCoordinateOrientation UCoordinate
	{
		get => GetValue<TkCoordinateOrientation>();
		set => TrySetValue<TkCoordinateOrientation>(value);
	}

	public TkCoordinateOrientation VCoordinate
	{
		get => GetValue<TkCoordinateOrientation>();
		set => TrySetValue<TkCoordinateOrientation>(value);
	}

	public Single VelocityInheritance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TrackEmitterPosition
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RotateAroundEmitter
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f RotateAroundEmitterAxis
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public libMBIN.NMS.Toolkit.TkParticleData.FlipbookPlaybackRateEnum FlipbookPlaybackRate
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkParticleData.FlipbookPlaybackRateEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkParticleData.FlipbookPlaybackRateEnum>(value);
	}

	public Single HueVariance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SaturationVariance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LightnessVariance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AlphaVariance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour ColourStart
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour ColourMiddle
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour ColourEnd
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public TkEmitterFloatProperty AlphaThreshold
	{
		get => GetValue<TkEmitterFloatProperty>();
		set => TrySetValue<TkEmitterFloatProperty>(value);
	}

	public libMBIN.NMS.Toolkit.TkParticleData.OnRefractionsDisabledEnum OnRefractionsDisabled
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkParticleData.OnRefractionsDisabledEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkParticleData.OnRefractionsDisabledEnum>(value);
	}

	public Boolean FadeRefractionsAtScreenEdge
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x10 UserColour
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single MaxRenderDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxSpawnDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SoftFadeStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkFloatRange CameraDistanceFade
	{
		get => GetValue<TkFloatRange>();
		set => TrySetValue<TkFloatRange>(value);
	}

	public TkParticleData(long address) : base(address)
	{

	}
}
