using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCustomNotifyTimerOptions : NMSTemplate
{
	public Boolean HasCustomNotifyTimer
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single NotifyDisplayTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NotifyPauseTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcCustomNotifyTimerOptions(long address) : base(address)
	{

	}
}
