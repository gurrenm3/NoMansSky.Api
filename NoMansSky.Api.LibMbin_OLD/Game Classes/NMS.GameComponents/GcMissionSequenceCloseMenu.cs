using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionSequenceCloseMenu : NMSTemplate
{
	public Single Delay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public libMBIN.NMS.GameComponents.GcMissionSequenceCloseMenu.MenuToCloseEnum MenuToClose
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMissionSequenceCloseMenu.MenuToCloseEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMissionSequenceCloseMenu.MenuToCloseEnum>(value);
	}

	public NMSString0x80 DebugText
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcMissionSequenceCloseMenu(long address) : base(address)
	{

	}
}
