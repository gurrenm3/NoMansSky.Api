using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureCrystalMovementDataParams : NMSTemplate
{
	public VirtualList<GcBiomeSubType> ValidBiomes
	{
		get => cache.GetOrAddValue(new VirtualList<GcBiomeSubType>(address + GetOffset()));
		set => TrySetValue<GcBiomeSubType>(value);
	}

	public VirtualList<NMSString0x20A> ValidDescriptors
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x20A>(address + GetOffset()));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Int32 NumShards
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean UseTerrainAngle
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ScaleOnAppear
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcAudioWwiseEvents CreationAudio
	{
		get => GetValue<GcAudioWwiseEvents>();
		set => TrySetValue<GcAudioWwiseEvents>(value);
	}

	public Single SpawnDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DespawnDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxOffsetZ
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxTilt
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OffsetTilt
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinAppearTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxAppearTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AppearOvershoot
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinDisappearTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxDisappearTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShowOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HideOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinShowTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean CustomHideCurve
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public TkCurveType HideCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single IdleSpeedModifier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WalkSpeedModifier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RunSpeedModifier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ParticleScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x10 DustEffect
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcAudioWwiseEvents Audio
	{
		get => GetValue<GcAudioWwiseEvents>();
		set => TrySetValue<GcAudioWwiseEvents>(value);
	}

	public GcAudioWwiseEvents RetractAudio
	{
		get => GetValue<GcAudioWwiseEvents>();
		set => TrySetValue<GcAudioWwiseEvents>(value);
	}

	public GcAudioWwiseEvents MoveStartAudio
	{
		get => GetValue<GcAudioWwiseEvents>();
		set => TrySetValue<GcAudioWwiseEvents>(value);
	}

	public GcAudioWwiseEvents MoveStopAudio
	{
		get => GetValue<GcAudioWwiseEvents>();
		set => TrySetValue<GcAudioWwiseEvents>(value);
	}

	public Single DeathFadeStart
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DeathFadeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public libMBIN.NMS.GameComponents.GcCreatureCrystalMovementDataParams.DeathTypeEnum DeathType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcCreatureCrystalMovementDataParams.DeathTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcCreatureCrystalMovementDataParams.DeathTypeEnum>(value);
	}

	public libMBIN.NMS.GameComponents.GcCreatureCrystalMovementDataParams.SubTypeEnum SubType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcCreatureCrystalMovementDataParams.SubTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcCreatureCrystalMovementDataParams.SubTypeEnum>(value);
	}

	public NMSString0x20 TentacleStartJoint
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public NMSString0x20 TentacleEndJoint
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public Single TentacleSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TentacleChurnSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TentacleIdleLookChance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TentacleStretchMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TentacleStretchMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TentacleMoveSwingAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TentacleWalkSwingSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TentacleRunSwingSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TentacleRotationApplyBase
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TentacleRotationApplyTip
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TentacleMoveTimeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TentacleMoveTimeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TentaclePitchRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TentacleYawRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TentacleRollRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcCreatureCrystalMovementDataParams(long address) : base(address)
	{

	}
}
