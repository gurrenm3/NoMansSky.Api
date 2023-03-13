using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Globals;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkGlobals : NMSTemplate
{
	public libMBIN.NMS.Globals.TkGlobals.AssertsLevelEnum AssertsLevel
	{
		get => GetValue<libMBIN.NMS.Globals.TkGlobals.AssertsLevelEnum>();
		set => TrySetValue<libMBIN.NMS.Globals.TkGlobals.AssertsLevelEnum>(value);
	}

	public Boolean DefaultSelectIgnoreAsserts
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public libMBIN.NMS.Globals.TkGlobals.EnabledChannelsEnum EnabledChannels
	{
		get => GetValue<libMBIN.NMS.Globals.TkGlobals.EnabledChannelsEnum>();
		set => TrySetValue<libMBIN.NMS.Globals.TkGlobals.EnabledChannelsEnum>(value);
	}

	public NMSString0x100 IncludeLogFilter
	{
		get => GetValue<NMSString0x100>();
		set => TrySetValue<NMSString0x100>(value);
	}

	public NMSString0x100 ExcludeLogFilter
	{
		get => GetValue<NMSString0x100>();
		set => TrySetValue<NMSString0x100>(value);
	}

	public Int32 LoadBalanceTimeoutMS
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 VRLoadBalanceTimeoutMS
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean LogInputSetup
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean LogInputChanges
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DisableResScaling
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single WwiseVibrationMultiplierPrimary
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WwiseVibrationMultiplierSecondary
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean DisableMultiplayer
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public TkGlobals(long address) : base(address)
	{

	}
}
