using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcByteBeatLibraryData : NMSTemplate
{
	public VirtualArray<GcByteBeatSong> MySongs
	{
		get => cache.GetOrAddValue(new VirtualArray<GcByteBeatSong>(address + GetOffset(), 8));
		set => TrySetValue<GcByteBeatSong>(value);
	}

	public VirtualArray<NMSString0x10> Playlist
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x10>(address + GetOffset(), 16));
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean Shuffle
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AutoplayOnFoot
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AutoplayInShip
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AutoplayInVehicle
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcByteBeatLibraryData(long address) : base(address)
	{

	}
}
