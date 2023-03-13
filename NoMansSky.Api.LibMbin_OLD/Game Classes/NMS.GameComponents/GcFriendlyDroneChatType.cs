using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcFriendlyDroneChatType : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcFriendlyDroneChatType.FriendlyDroneChatTypeEnum FriendlyDroneChatType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcFriendlyDroneChatType.FriendlyDroneChatTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcFriendlyDroneChatType.FriendlyDroneChatTypeEnum>(value);
	}

	public GcFriendlyDroneChatType(long address) : base(address)
	{

	}
}
