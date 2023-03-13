using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNGuiLayoutData : NMSTemplate
{
	public Single PositionX
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PositionY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Width
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean WidthPercentage
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single Height
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean HeightPercentage
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ConstrainProportions
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single ConstrainAspect
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean ForceAspect
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean Anchor
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AnchorPercent
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SameLine
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public TkNGuiAlignment Align
	{
		get => GetValue<TkNGuiAlignment>();
		set => TrySetValue<TkNGuiAlignment>(value);
	}

	public Boolean SlowCursorOnHover
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single MaxWidth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<GcVROverride_Layout> VROverrides
	{
		get => cache.GetOrAddValue(new VirtualList<GcVROverride_Layout>(address + GetOffset()));
		set => TrySetValue<GcVROverride_Layout>(value);
	}

	public VirtualList<GcAccessibleOverride_Layout> AccessibleOverrides
	{
		get => cache.GetOrAddValue(new VirtualList<GcAccessibleOverride_Layout>(address + GetOffset()));
		set => TrySetValue<GcAccessibleOverride_Layout>(value);
	}

	public GcNGuiLayoutData(long address) : base(address)
	{

	}
}
