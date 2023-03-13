using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBaseDefenceStatusAction : NMSTemplate
{
	public GcBaseDefenceStatusType TryState
	{
		get => GetValue<GcBaseDefenceStatusType>();
		set => TrySetValue<GcBaseDefenceStatusType>(value);
	}

	public GcBaseDefenceStatusAction(long address) : base(address)
	{

	}
}
