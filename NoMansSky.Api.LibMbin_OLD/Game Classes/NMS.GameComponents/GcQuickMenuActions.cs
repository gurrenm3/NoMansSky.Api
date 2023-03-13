using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcQuickMenuActions : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcQuickMenuActions.QuickMenuActionsEnum QuickMenuActions
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcQuickMenuActions.QuickMenuActionsEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcQuickMenuActions.QuickMenuActionsEnum>(value);
	}

	public GcQuickMenuActions(long address) : base(address)
	{

	}
}
