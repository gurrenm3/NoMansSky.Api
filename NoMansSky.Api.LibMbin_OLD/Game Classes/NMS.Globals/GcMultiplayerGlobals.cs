using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMultiplayerGlobals : NMSTemplate
{
	public Vector2f FullSimHandUpdateDistance
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f FullSimHandUpdateInterval
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single DistanceBetweenTeleportMovementEffects
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FullSimHandUpdateDisabledDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FullSimUpdateInterval
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single JoinInteractionTimeout
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InviteInteractionTimeout
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 MaxDownloadableBases
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single BlobHeightOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 TransactionTimeout
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MessageQueueSize
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MessageQueueSizeDropUnreliable
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single PlayerMarkerDisplayDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean VoiceChatEnabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single DisconnectionDisplayTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UpdatePeriod
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UpdatePeriodSteam
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VoiceUpdatePeriod
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VoiceUpdatePeriodSteam
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UpdateSlerpModifier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipDirectionLerpModifier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CharacterDirectionLerpModifier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipSyncConvervengeMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipLandShakeMaxDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleStickLerpModifier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleThrottleLerpModifier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PlayerMarkerScreenOffsetY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PlayerMarkerSmallIconSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PlayerMarkerLargeIconDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PlayerMarkerLargeIconFarSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PlayerMarkerLargeIconCloseSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PlayerMarkerMinShowDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean PlayerMarkerCenteredName
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single PlayerInteractCooldown
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public UInt64 AbandonedEntityWaitPeriod
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public Single HostOnConnectedTimeout
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 MaxSyncResponsesPerHash
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single MinScore
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HostBiasScore
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UsefulSyncResponseScore
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UselessSyncResponseScore
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ConstantScoreDepletionRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FactorScoreDepletionRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HashCheckMessageInterval
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SyncMessageInterval
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EditMessageInterval
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NewBlockMessageInterval
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EditMessageSentSyncBackOffTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EditMessageReceivedSyncBackOffTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NewBlockMessageOverdueDistanceDivisor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HashCheckMessageOverdueDistanceDivisor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 NewBlockMessageSentCooldown
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 HashReceivedCooldown
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 HashMessageSentCooldown
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 UsefulSyncResponseCooldown
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 UselessSyncResponseCooldown
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 NewerHashReceivedCooldown
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single BaseHeaderBroadcastInterval
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PlaceholderBroadcastInterval
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StatSyncRadiusPlanet
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StatSyncRadiusSpace
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCInteractionTimeout
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCReplicateStartDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCReplicateEndDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 MissionRecurrenceTime
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single MissionWaitOnceAllPlayersReadyTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ChanceMissionEpic
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RemoveDuplicateChatMessageTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x10 StandardMissionSecondReward
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 QuicksilverMissionSecondReward
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 EpicMissionSecondReward
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 WeekendMissionSecondReward
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 EpicMissionRewardOverride
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 NexusMissionStandardReward
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public TkTextureResource EpicMissionIcon
	{
		get => GetValue<TkTextureResource>();
		set => TrySetValue<TkTextureResource>(value);
	}

	public TkTextureResource EpicMissionIconSelected
	{
		get => GetValue<TkTextureResource>();
		set => TrySetValue<TkTextureResource>(value);
	}

	public TkTextureResource EpicMissionIconNotSelected
	{
		get => GetValue<TkTextureResource>();
		set => TrySetValue<TkTextureResource>(value);
	}

	public Single PlanetLocalEnitityInterestStart
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PlanetLocalEnitityInterestEnd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EntityUpdateMaxRateDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EntityUpdateMinRateDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcMultiplayerGlobals(long address) : base(address)
	{

	}
}
