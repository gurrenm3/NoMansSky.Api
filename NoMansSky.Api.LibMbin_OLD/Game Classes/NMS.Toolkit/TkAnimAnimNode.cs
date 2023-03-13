using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkAnimAnimNode : NMSTemplate
{
	public NMSString0x10 NodeId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 AnimId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x40 PhaseIn
	{
		get => GetValue<NMSString0x40>();
		set => TrySetValue<NMSString0x40>(value);
	}

	public TkCurveType PhaseCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single PhaseRangeBegin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PhaseRangeEnd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkAnimAnimNode(long address) : base(address)
	{

	}
}
