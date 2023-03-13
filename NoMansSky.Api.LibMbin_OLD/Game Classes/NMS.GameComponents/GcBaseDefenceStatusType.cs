using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBaseDefenceStatusType : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcBaseDefenceStatusType.BaseDefenceStatusEnum BaseDefenceStatus
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcBaseDefenceStatusType.BaseDefenceStatusEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcBaseDefenceStatusType.BaseDefenceStatusEnum>(value);
	}

	public GcBaseDefenceStatusType(long address) : base(address)
	{

	}
}
