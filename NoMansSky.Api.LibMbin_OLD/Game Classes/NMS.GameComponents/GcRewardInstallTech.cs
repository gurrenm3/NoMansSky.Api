using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardInstallTech : NMSTemplate
{
	public NMSString0x10 TechId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public libMBIN.NMS.GameComponents.GcRewardInstallTech.InventoryToInstallInEnum InventoryToInstallIn
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcRewardInstallTech.InventoryToInstallInEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcRewardInstallTech.InventoryToInstallInEnum>(value);
	}

	public Boolean Silent
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean InstallBroken
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcRewardInstallTech(long address) : base(address)
	{

	}
}
