using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcOutSnapSocketCondition : NMSTemplate
{
	public NMSString0x80 SnapPoint
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 OutSocket
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcBaseSnapState SnapState
	{
		get => GetValue<GcBaseSnapState>();
		set => TrySetValue<GcBaseSnapState>(value);
	}

	public NMSString0x10 ObjectId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 SnapPointIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 OutSocketIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcOutSnapSocketCondition(long address) : base(address)
	{

	}
}
