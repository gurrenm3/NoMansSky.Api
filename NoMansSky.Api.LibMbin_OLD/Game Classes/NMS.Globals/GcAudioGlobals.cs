using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAudioGlobals : NMSTemplate
{
	public GcAudioNPCDoppler NPCEngines
	{
		get => GetValue<GcAudioNPCDoppler>();
		set => TrySetValue<GcAudioNPCDoppler>(value);
	}

	public GcAudio3PointDopplerData DroneDoppler
	{
		get => GetValue<GcAudio3PointDopplerData>();
		set => TrySetValue<GcAudio3PointDopplerData>(value);
	}

	public Single AuxSendCaveRampDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AuxSendOutdoorsRampDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LadderStepDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShorelineSenseStartUp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShorelineSenseProbeDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShorelineSenseBlend
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShorelineSenseBaseU
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f ShorelineSenseUJitter
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f ShorelineSenseVJitter
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f ShorelineSenseRadius
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single ShorelineValidityRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShorelineRTPCSmoothRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShorelineObstructionSmoothRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShorelineObstructionMul
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneDopplerExtentsFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DistanceReportMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DistanceReportMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DistanceSquishScaleToListener
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DistanceSquishMaxTravel
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 ByteBeatMaxGeneratingAudio
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single ByteBeatCrossfadeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ByteBeatVisualisationTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 ByteBeatVisualisationMode
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 ByteBeatVisualisationPixelStep
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 ByteBeatVisualisationMiniPixelStep
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 ByteBeatNonSilentAttempts
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single ByteBeatNonSilentTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ByteBeatNonSilentAvgInterpSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ByteBeatNonSilentSDCutoff
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ByteBeatBeginAtTonicProbability
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ByteBeatChangeNoteProbability
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ByteBeatSkipNoteProbability
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<Single> ByteBeatScaleDegreeProbability
	{
		get => cache.GetOrAddValue(new VirtualList<Single>(address + GetOffset()));
		set => TrySetValue<Single>(value);
	}

	public Single ByteBeatSpeakerVolumeInterSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f ByteBeatSpeakerMaxAmplitude
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f ByteBeatSpeakerMinFrequency
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f ByteBeatSpeakerMaxFrequency
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Int32 ByteBeatPlayerNumLoops
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single ByteBeatPlayerFadeOut
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ByteBeatDrumMixLow
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ByteBeatDrumMixHigh
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ByteBeatSynthMixLow
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ByteBeatSynthMixHigh
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AtlasStationActiveDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MiniStationActiveDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PlayerDepthUnderwaterMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PlayerLowerOffsetEmitterMul
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean ObstructionEnabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single ObstructionSmoothTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ObstructionValueMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ObstructionAuxControlWhenVisible
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ObstructionAuxControlWhenHidden
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean PulseMusicEnabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean LockListenerMatrix
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean EnableVRSpecificAudio
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single ArmFoleySpeedMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ArmWhooshFoleyValueTrigger
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinSecondsBetweenArmWhooshes
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f CommsChatterFalloffFreighers
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f CommsChatterFalloffShips
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public GcAudioGlobals(long address) : base(address)
	{

	}
}
