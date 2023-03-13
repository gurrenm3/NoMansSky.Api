using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureHoverMovementDataParams : NMSTemplate
{
	public VirtualList<NMSString0x20A> ValidDescriptors
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x20A>(address + GetOffset()));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Single NavOffsetY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NavOffsetZ
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroundHeightOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x100 GroundEffect
	{
		get => GetValue<NMSString0x100>();
		set => TrySetValue<NMSString0x100>(value);
	}

	public Single GroundEffectHeightForMaxAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroundEffectHeightForMinAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RayCastUp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RayCastDown
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean GroundAlign
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single HeightForMaxGroundAlign
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HeightForMinGroundAlign
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroundAlignTimeModifier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean GroundAvoid
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single HeightForMaxGroundAvoid
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HeightForMinGroundAvoid
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroundAvoidTimeModifier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean CanJump
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualList<GcCreatureHoverTintableEffect> TintableEffects
	{
		get => cache.GetOrAddValue(new VirtualList<GcCreatureHoverTintableEffect>(address + GetOffset()));
		set => TrySetValue<GcCreatureHoverTintableEffect>(value);
	}

	public GcCreatureHoverMovementDataParams(long address) : base(address)
	{

	}
}
