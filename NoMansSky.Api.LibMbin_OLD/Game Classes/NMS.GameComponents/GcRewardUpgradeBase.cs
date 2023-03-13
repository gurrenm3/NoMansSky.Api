using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardUpgradeBase : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcRewardUpgradeBase.UpgradeBaseTypeEnum UpgradeBaseType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcRewardUpgradeBase.UpgradeBaseTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcRewardUpgradeBase.UpgradeBaseTypeEnum>(value);
	}

	public VirtualList<GcPersistentBaseTypes> MatchingBaseTypes
	{
		get => cache.GetOrAddValue(new VirtualList<GcPersistentBaseTypes>(address + GetOffset()));
		set => TrySetValue<GcPersistentBaseTypes>(value);
	}

	public GcRewardUpgradeBase(long address) : base(address)
	{

	}
}
