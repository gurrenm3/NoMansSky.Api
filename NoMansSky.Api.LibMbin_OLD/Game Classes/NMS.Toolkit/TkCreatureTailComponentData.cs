using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkCreatureTailComponentData : NMSTemplate
{
	public GcPrimaryAxis LengthAxis
	{
		get => GetValue<GcPrimaryAxis>();
		set => TrySetValue<GcPrimaryAxis>(value);
	}

	public Boolean CanUseDefaultParams
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public TkCreatureTailParams DefaultParams
	{
		get => GetValue<TkCreatureTailParams>();
		set => TrySetValue<TkCreatureTailParams>(value);
	}

	public VirtualList<TkCreatureTailParams> ParamVariations
	{
		get => cache.GetOrAddValue(new VirtualList<TkCreatureTailParams>(address + GetOffset()));
		set => TrySetValue<TkCreatureTailParams>(value);
	}

	public TkCreatureTailComponentData(long address) : base(address)
	{

	}
}
