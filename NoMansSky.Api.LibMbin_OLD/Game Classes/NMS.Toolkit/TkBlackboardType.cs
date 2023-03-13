using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkBlackboardType : NMSTemplate
{
	public libMBIN.NMS.Toolkit.TkBlackboardType.BlackboardTypeEnum BlackboardType
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkBlackboardType.BlackboardTypeEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkBlackboardType.BlackboardTypeEnum>(value);
	}

	public TkBlackboardType(long address) : base(address)
	{

	}
}
