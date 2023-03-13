using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkAnim2dBlendNode : NMSTemplate
{
	public NMSString0x10 NodeId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x40 PositionIn
	{
		get => GetValue<NMSString0x40>();
		set => TrySetValue<NMSString0x40>(value);
	}

	public Single PositionRangeBegin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PositionRangeEnd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PositionSpringTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType PositionCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public libMBIN.NMS.Toolkit.TkAnim2dBlendNode.CoordinatesEnum Coordinates
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkAnim2dBlendNode.CoordinatesEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkAnim2dBlendNode.CoordinatesEnum>(value);
	}

	public libMBIN.NMS.Toolkit.TkAnim2dBlendNode.BlendOpEnum BlendOp
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkAnim2dBlendNode.BlendOpEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkAnim2dBlendNode.BlendOpEnum>(value);
	}

	public VirtualList<TkAnim2dBlendNodeData> BlendChildren
	{
		get => cache.GetOrAddValue(new VirtualList<TkAnim2dBlendNodeData>(address + GetOffset()));
		set => TrySetValue<TkAnim2dBlendNodeData>(value);
	}

	public TkAnim2dBlendNode(long address) : base(address)
	{

	}
}
