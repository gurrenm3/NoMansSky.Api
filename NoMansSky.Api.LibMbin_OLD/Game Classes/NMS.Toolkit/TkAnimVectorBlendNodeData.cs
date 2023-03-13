using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;
using libMBIN;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkAnimVectorBlendNodeData : NMSTemplate
{
	public NMSString0x10 NodeId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x40 WeightIn
	{
		get => GetValue<NMSString0x40>();
		set => TrySetValue<NMSString0x40>(value);
	}

	public Single WeightRangeBegin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WeightRangeEnd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WeightSpringTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType WeightCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single InitialWeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSTemplate BlendChild
	{
		get => GetValue<NMSTemplate>();
		set => TrySetValue<NMSTemplate>(value);
	}

	public TkAnimVectorBlendNodeData(long address) : base(address)
	{

	}
}
