using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcByteBeatSong : NMSTemplate
{
	public NMSString0x10 Id
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 RequiredSpecialId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x20 Name
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public NMSString0x20A LocID
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x40 AuthorOnlineID
	{
		get => GetValue<NMSString0x40>();
		set => TrySetValue<NMSString0x40>(value);
	}

	public NMSString0x40 AuthorUsername
	{
		get => GetValue<NMSString0x40>();
		set => TrySetValue<NMSString0x40>(value);
	}

	public NMSString0x40 AuthorPlatform
	{
		get => GetValue<NMSString0x40>();
		set => TrySetValue<NMSString0x40>(value);
	}

	public VirtualArray<NMSString0x40> Data
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x40>(address + GetOffset(), 8));
		set => TrySetValue<NMSString0x40>(value);
	}

	public GcByteBeatSong(long address) : base(address)
	{

	}
}
