using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcUnlockableTreeCostType : NMSTemplate
{
	public NMSString0x10 CostTypeID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public libMBIN.NMS.GameComponents.GcUnlockableTreeCostType.TypeOfCostEnum TypeOfCost
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcUnlockableTreeCostType.TypeOfCostEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcUnlockableTreeCostType.TypeOfCostEnum>(value);
	}

	public GcCurrency CurrencyType
	{
		get => GetValue<GcCurrency>();
		set => TrySetValue<GcCurrency>(value);
	}

	public NMSString0x10 TypeID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x20A CantAffordString
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcUnlockableTreeCostType(long address) : base(address)
	{

	}
}
