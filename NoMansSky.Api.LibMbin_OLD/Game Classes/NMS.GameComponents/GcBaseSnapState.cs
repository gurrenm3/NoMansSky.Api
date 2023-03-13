using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBaseSnapState : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcBaseSnapState.SnapStateEnum SnapState
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcBaseSnapState.SnapStateEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcBaseSnapState.SnapStateEnum>(value);
	}

	public GcBaseSnapState(long address) : base(address)
	{

	}
}
