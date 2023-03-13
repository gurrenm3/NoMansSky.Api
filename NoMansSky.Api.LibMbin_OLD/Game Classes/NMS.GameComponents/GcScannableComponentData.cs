using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcScannableComponentData : NMSTemplate
{
	public Single ScanRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x20 ScanName
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public Single ScanTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CompassRangeMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AlwaysShowRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean CanTagIcon
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ClearTagOnArrival
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DisableIfBuildingPart
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DisableIfInBase
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UseModelNode
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcScannerIconTypes Icon
	{
		get => GetValue<GcScannerIconTypes>();
		set => TrySetValue<GcScannerIconTypes>(value);
	}

	public libMBIN.NMS.GameComponents.GcScannableComponentData.ScannableTypeEnum ScannableType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcScannableComponentData.ScannableTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcScannableComponentData.ScannableTypeEnum>(value);
	}

	public Boolean IsPlacedMarker
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ShowInFreighterBranchRoom
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean TellPlayerIfFreighterObjectUsed
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x20A FreighterObjectAlreadyUsedLocID
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Boolean AllowedToMerge
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean MarkerActiveWithNodeInactive
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x10 MissionSurveyId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single MinDisplayDistanceOverride
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcScannableComponentData(long address) : base(address)
	{

	}
}
