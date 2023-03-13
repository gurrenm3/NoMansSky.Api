using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkAnimationData : NMSTemplate
{
	public NMSString0x10 Anim
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x80 Filename
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public libMBIN.NMS.Toolkit.TkAnimationData.AnimTypeEnum AnimType
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkAnimationData.AnimTypeEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkAnimationData.AnimTypeEnum>(value);
	}

	public Int32 FrameStart
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 FrameEnd
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public NMSString0x40 StartNode
	{
		get => GetValue<NMSString0x40>();
		set => TrySetValue<NMSString0x40>(value);
	}

	public VirtualList<NMSString0x40> ExtraStartNodes
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x40>(address + GetOffset()));
		set => TrySetValue<NMSString0x40>(value);
	}

	public Int32 Priority
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single OffsetMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OffsetMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Delay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Speed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ActionStartFrame
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ActionFrame
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public libMBIN.NMS.Toolkit.TkAnimationData.CreatureSizeEnum CreatureSize
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkAnimationData.CreatureSizeEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkAnimationData.CreatureSizeEnum>(value);
	}

	public Boolean Additive
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean Mirrored
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean Active
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x10 AdditiveBaseAnim
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single AdditiveBaseFrame
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkAnimationGameData GameData
	{
		get => GetValue<TkAnimationGameData>();
		set => TrySetValue<TkAnimationGameData>(value);
	}

	public TkAnimationData(long address) : base(address)
	{

	}
}
