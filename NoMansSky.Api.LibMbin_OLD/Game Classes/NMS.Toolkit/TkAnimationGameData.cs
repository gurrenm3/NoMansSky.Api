using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkAnimationGameData : NMSTemplate
{
	public Boolean RootMotionEnabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean BlockPlayerMovement
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public libMBIN.NMS.Toolkit.TkAnimationGameData.BlockPlayerWeaponEnum BlockPlayerWeapon
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkAnimationGameData.BlockPlayerWeaponEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkAnimationGameData.BlockPlayerWeaponEnum>(value);
	}

	public TkAnimationGameData(long address) : base(address)
	{

	}
}
