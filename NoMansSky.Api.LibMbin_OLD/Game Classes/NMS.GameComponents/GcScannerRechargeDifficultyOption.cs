using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcScannerRechargeDifficultyOption : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcScannerRechargeDifficultyOption.ScannerRechargeDifficultyEnum ScannerRechargeDifficulty
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcScannerRechargeDifficultyOption.ScannerRechargeDifficultyEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcScannerRechargeDifficultyOption.ScannerRechargeDifficultyEnum>(value);
	}

	public GcScannerRechargeDifficultyOption(long address) : base(address)
	{

	}
}
