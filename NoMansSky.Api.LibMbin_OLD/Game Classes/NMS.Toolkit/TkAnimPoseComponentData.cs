using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkAnimPoseComponentData : NMSTemplate
{
	public VirtualList<TkAnimPoseData> PoseAnims
	{
		get => cache.GetOrAddValue(new VirtualList<TkAnimPoseData>(address + GetOffset()));
		set => TrySetValue<TkAnimPoseData>(value);
	}

	public NMSString0x80 Filename
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public VirtualList<TkAnimPoseCorrelationData> Correlations
	{
		get => cache.GetOrAddValue(new VirtualList<TkAnimPoseCorrelationData>(address + GetOffset()));
		set => TrySetValue<TkAnimPoseCorrelationData>(value);
	}

	public VirtualList<TkAnimPoseExampleData> Examples
	{
		get => cache.GetOrAddValue(new VirtualList<TkAnimPoseExampleData>(address + GetOffset()));
		set => TrySetValue<TkAnimPoseExampleData>(value);
	}

	public VirtualList<Single> CorrelationMat
	{
		get => cache.GetOrAddValue(new VirtualList<Single>(address + GetOffset()));
		set => TrySetValue<Single>(value);
	}

	public Single AdultCorrelationValue
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<TkAnimPoseBabyModifier> BabyModifiers
	{
		get => cache.GetOrAddValue(new VirtualList<TkAnimPoseBabyModifier>(address + GetOffset()));
		set => TrySetValue<TkAnimPoseBabyModifier>(value);
	}

	public Boolean ShouldRandomise
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public TkAnimPoseComponentData(long address) : base(address)
	{

	}
}
