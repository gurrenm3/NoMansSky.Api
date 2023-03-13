using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcInteractionComponentData : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcInteractionComponentData.InteractionActionEnum InteractionAction
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcInteractionComponentData.InteractionActionEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcInteractionComponentData.InteractionActionEnum>(value);
	}

	public GcInteractionType InteractionType
	{
		get => GetValue<GcInteractionType>();
		set => TrySetValue<GcInteractionType>(value);
	}

	public Boolean UseIntermediateUI
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public TkModelRendererData Renderer
	{
		get => GetValue<TkModelRendererData>();
		set => TrySetValue<TkModelRendererData>(value);
	}

	public TkModelRendererData RendererAlt
	{
		get => GetValue<TkModelRendererData>();
		set => TrySetValue<TkModelRendererData>(value);
	}

	public GcAlienRace Race
	{
		get => GetValue<GcAlienRace>();
		set => TrySetValue<GcAlienRace>(value);
	}

	public Single AttractDistanceSq
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean SecondaryMeshAlwaysVisible
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean RepeatInteraction
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UseInteractCamera
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single BlendToCameraTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BlendFromCameraTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcInteractionActivationCost ActivationCost
	{
		get => GetValue<GcInteractionActivationCost>();
		set => TrySetValue<GcInteractionActivationCost>(value);
	}

	public NMSString0x10 TriggerAction
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 TriggerActionOnPrepare
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean BroadcastTriggerAction
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single InteractAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean InteractInvertFace
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcInteractionType SecondaryInteractionType
	{
		get => GetValue<GcInteractionType>();
		set => TrySetValue<GcInteractionType>(value);
	}

	public GcInteractionActivationCost SecondaryActivationCost
	{
		get => GetValue<GcInteractionActivationCost>();
		set => TrySetValue<GcInteractionActivationCost>(value);
	}

	public VirtualList<TkModelRendererData> EventRenderers
	{
		get => cache.GetOrAddValue(new VirtualList<TkModelRendererData>(address + GetOffset()));
		set => TrySetValue<TkModelRendererData>(value);
	}

	public VirtualList<TkModelRendererData> EventRenderersAlt
	{
		get => cache.GetOrAddValue(new VirtualList<TkModelRendererData>(address + GetOffset()));
		set => TrySetValue<TkModelRendererData>(value);
	}

	public Single SecondaryCameraTransitionTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcInteractionDof DepthOfField
	{
		get => GetValue<GcInteractionDof>();
		set => TrySetValue<GcInteractionDof>(value);
	}

	public VirtualList<GcAlienPuzzleMissionOverride> PuzzleMissionOverrideTable
	{
		get => cache.GetOrAddValue(new VirtualList<GcAlienPuzzleMissionOverride>(address + GetOffset()));
		set => TrySetValue<GcAlienPuzzleMissionOverride>(value);
	}

	public GcStoryUtilityOverride StoryUtilityOverrideData
	{
		get => GetValue<GcStoryUtilityOverride>();
		set => TrySetValue<GcStoryUtilityOverride>(value);
	}

	public libMBIN.NMS.GameComponents.GcInteractionComponentData.OverrideInteriorExteriorMarkerEnum OverrideInteriorExteriorMarker
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcInteractionComponentData.OverrideInteriorExteriorMarkerEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcInteractionComponentData.OverrideInteriorExteriorMarkerEnum>(value);
	}

	public Boolean ReseedAfterRewardSuccess
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UsePersonalPersistentBuffer
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single InWorldUIScaler
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x10 StartMissionOnUse
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean AllowMissionUnderwater
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcInteractionComponentData(long address) : base(address)
	{

	}
}
