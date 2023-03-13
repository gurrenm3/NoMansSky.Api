using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcStatusMessageDefinition : NMSTemplate
{
	public NMSString0x10 Id
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x20A Message
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Boolean AddPlayerNamePrefix
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AddPetNamePrefix
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AddFriendlyDronePrefix
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean IncludePlayerName
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public libMBIN.NMS.GameComponents.GcStatusMessageDefinition.ReplicateToEnum ReplicateTo
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcStatusMessageDefinition.ReplicateToEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcStatusMessageDefinition.ReplicateToEnum>(value);
	}

	public Boolean PostLocally
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single Distance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DisplayDurationMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean OnlyInMultiplayer
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean OnlyOnFireteam
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcStatusMessageMissionMarkup MissionMarkup
	{
		get => GetValue<GcStatusMessageMissionMarkup>();
		set => TrySetValue<GcStatusMessageMissionMarkup>(value);
	}

	public GcStatusMessageDefinition(long address) : base(address)
	{

	}
}
