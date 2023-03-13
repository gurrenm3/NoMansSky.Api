using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardTeleport : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcRewardTeleport.TeleportRewardTypeEnum TeleportRewardType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcRewardTeleport.TeleportRewardTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcRewardTeleport.TeleportRewardTypeEnum>(value);
	}

	public GcRewardTeleport(long address) : base(address)
	{

	}
}
