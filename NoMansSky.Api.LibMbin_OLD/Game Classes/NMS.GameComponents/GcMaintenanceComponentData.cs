using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMaintenanceComponentData : NMSTemplate
{
	public VirtualList<GcMaintenanceElement> PreInstalledTech
	{
		get => cache.GetOrAddValue(new VirtualList<GcMaintenanceElement>(address + GetOffset()));
		set => TrySetValue<GcMaintenanceElement>(value);
	}

	public Int32 VisibleMaintenanceSlots
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean AllowRepair
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AllowCharge
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AllowDismantle
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AllowInstallTech
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AllowCraftProduct
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AllowTransfer
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AllowMoveAndStack
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AllowTransferIn
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AutoCompleteOnStart
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UseModelResourceRenderer
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UseBoundsForIconCentre
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public libMBIN.NMS.GameComponents.GcMaintenanceComponentData.InteractableEnum Interactable
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMaintenanceComponentData.InteractableEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMaintenanceComponentData.InteractableEnum>(value);
	}

	public Boolean ForceNoninteraction
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single CompletedTransitionDelay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean ShareInteractionModelRender
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public TkModelRendererData ModelRenderData
	{
		get => GetValue<TkModelRendererData>();
		set => TrySetValue<TkModelRendererData>(value);
	}

	public TkModelRendererData ModelRenderDataAlt
	{
		get => GetValue<TkModelRendererData>();
		set => TrySetValue<TkModelRendererData>(value);
	}

	public libMBIN.NMS.GameComponents.GcMaintenanceComponentData.ModelRendererResourceEnum ModelRendererResource
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMaintenanceComponentData.ModelRendererResourceEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMaintenanceComponentData.ModelRendererResourceEnum>(value);
	}

	public GcBroadcastLevel BroadcastLevel
	{
		get => GetValue<GcBroadcastLevel>();
		set => TrySetValue<GcBroadcastLevel>(value);
	}

	public NMSString0x20A Title
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A Description
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A ActionButtonOverride
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A ActionDescriptionOverride
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A TransferButtonOverride
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A TransferDescriptionOverride
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A DiscardButtonOverride
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A DiscardDescriptionOverride
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A ActionWarningOverride
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Single InWorldUIScaler
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean InteractionRequiresPower
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x10 StartMissionOnUse
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcMaintenanceComponentData(long address) : base(address)
	{

	}
}
