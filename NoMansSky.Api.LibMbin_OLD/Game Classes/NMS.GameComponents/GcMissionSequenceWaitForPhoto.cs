using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionSequenceWaitForPhoto : NMSTemplate
{
	public NMSString0x80 Message
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 MessageSecondary
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 MessageSuccess
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public VirtualList<GcBiomeType> Biomes
	{
		get => cache.GetOrAddValue(new VirtualList<GcBiomeType>(address + GetOffset()));
		set => TrySetValue<GcBiomeType>(value);
	}

	public VirtualList<GcPhotoFauna> Fauna
	{
		get => cache.GetOrAddValue(new VirtualList<GcPhotoFauna>(address + GetOffset()));
		set => TrySetValue<GcPhotoFauna>(value);
	}

	public VirtualList<GcPhotoFlora> Flora
	{
		get => cache.GetOrAddValue(new VirtualList<GcPhotoFlora>(address + GetOffset()));
		set => TrySetValue<GcPhotoFlora>(value);
	}

	public VirtualList<GcPhotoBuildings> Buildings
	{
		get => cache.GetOrAddValue(new VirtualList<GcPhotoBuildings>(address + GetOffset()));
		set => TrySetValue<GcPhotoBuildings>(value);
	}

	public Boolean TakeAmountFromSeasonData
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x80 DebugText
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcMissionSequenceWaitForPhoto(long address) : base(address)
	{

	}
}
