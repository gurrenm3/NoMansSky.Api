using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkAnimDetailSettingsData : NMSTemplate
{
	public Single Distance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean DisableAnim
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 NumCulledFrames
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public TkAnimDetailSettingsData(long address) : base(address)
	{

	}
}
