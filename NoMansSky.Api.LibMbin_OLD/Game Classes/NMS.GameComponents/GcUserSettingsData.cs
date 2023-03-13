using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcUserSettingsData : NMSTemplate
{
	public Boolean InvertLookControls
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean InvertFlightControls
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean InvertVRInWorldFlightControls
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean HUDHidden
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean Vibration
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 ScreenBrightness
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MusicVolume
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 SfxVolume
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 LookSensitivityMode1
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 LookSensitivityMode2
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 FlightSensitivityMode1
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 FlightSensitivityMode2
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 CursorSensitivityMode1
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 CursorSensitivityMode2
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MouseSpringSmoothing
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcBlockListPersistence BlockList
	{
		get => GetValue<GcBlockListPersistence>();
		set => TrySetValue<GcBlockListPersistence>(value);
	}

	public Int32 MotionBlurAmount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 Filter
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean DamageNumbers
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public libMBIN.NMS.GameComponents.GcUserSettingsData.PS4FixedFPSEnum PS4FixedFPS
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcUserSettingsData.PS4FixedFPSEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcUserSettingsData.PS4FixedFPSEnum>(value);
	}

	public Single PS4FOVFoot
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PS4FOVShip
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean XboxOneXHighResolutionMode
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean PS4VignetteAndScanlines
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public libMBIN.NMS.GameComponents.GcUserSettingsData.BaseSharingModeEnum BaseSharingMode
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcUserSettingsData.BaseSharingModeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcUserSettingsData.BaseSharingModeEnum>(value);
	}

	public VirtualList<NMSString0x10> SeenSubstances
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x10> SeenTechnologies
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x10> SeenProducts
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x10> MostValuableProcProdsSeen
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x20A> SeenWikiTopics
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x20A>(address + GetOffset()));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualList<NMSString0x20A> UnlockedWikiTopics
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x20A>(address + GetOffset()));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualList<NMSString0x10> UnlockedTitles
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x10> UnlockedSpecials
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x10> UnlockedSeasonRewards
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x10> UnlockedTwitchRewards
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x10> UnlockedPlatformRewards
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean VoiceChat
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean Multiplayer
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean InstantUIInputs
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SpeechToText
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean Translate
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean CrossPlatform
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public libMBIN.NMS.GameComponents.GcUserSettingsData.TemperatureUnitEnum TemperatureUnit
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcUserSettingsData.TemperatureUnitEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcUserSettingsData.TemperatureUnitEnum>(value);
	}

	public Boolean UseOldMouseFlight
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 LastSeenCommunityMission
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 LastSeenCommunityMissionTier
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public libMBIN.NMS.GameComponents.GcUserSettingsData.MovementModeEnum MovementMode
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcUserSettingsData.MovementModeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcUserSettingsData.MovementModeEnum>(value);
	}

	public GcMovementDirection MovementDirectionPad
	{
		get => GetValue<GcMovementDirection>();
		set => TrySetValue<GcMovementDirection>(value);
	}

	public GcMovementDirection MovementDirectionHands
	{
		get => GetValue<GcMovementDirection>();
		set => TrySetValue<GcMovementDirection>(value);
	}

	public libMBIN.NMS.GameComponents.GcUserSettingsData.TurnModeEnum TurnMode
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcUserSettingsData.TurnModeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcUserSettingsData.TurnModeEnum>(value);
	}

	public Boolean UseVrVignette
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UseShipAutoControlVignette
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single HUDZoom
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FrontendZoom
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean UseAutoTorch
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public libMBIN.NMS.GameComponents.GcUserSettingsData.UIColourSchemeEnum UIColourScheme
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcUserSettingsData.UIColourSchemeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcUserSettingsData.UIColourSchemeEnum>(value);
	}

	public Boolean EnableModdingConsole
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean HeadBob
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean VRHeadBob
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean VRShowBody
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UseCharacterHeightForCamera
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean BaseComplexityLimitsEnabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean EnableLargeLobbies
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 FireteamSessionCount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 VibrationStrength
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 CamerShakeStrength
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 TriggerFeedbackStrength
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public libMBIN.NMS.GameComponents.GcUserSettingsData.SpaceCombatFollowModeEnum SpaceCombatFollowMode
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcUserSettingsData.SpaceCombatFollowModeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcUserSettingsData.SpaceCombatFollowModeEnum>(value);
	}

	public VirtualList<NMSString0x80> UpgradedUsers
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x80>(address + GetOffset()));
		set => TrySetValue<NMSString0x80>(value);
	}

	public Boolean AllowWhiteScreenTransitions
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AccessibleText
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean HoldToScanDiscoveries
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SprintScanSwap
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean PlaceJumpSwap
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcUserSettingsData(long address) : base(address)
	{

	}
}
