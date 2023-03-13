using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAntagonistComponentData : NMSTemplate
{
	public GcAntagonistGroup Group
	{
		get => GetValue<GcAntagonistGroup>();
		set => TrySetValue<GcAntagonistGroup>(value);
	}

	public Single ScarinessFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShockedFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ComprehensionFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CommunicationDelay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<GcAntagonistFriend> Friends
	{
		get => cache.GetOrAddValue(new VirtualArray<GcAntagonistFriend>(address + GetOffset(), 6));
		set => TrySetValue<GcAntagonistFriend>(value);
	}

	public VirtualArray<GcAntagonistEnemy> Enemies
	{
		get => cache.GetOrAddValue(new VirtualArray<GcAntagonistEnemy>(address + GetOffset(), 6));
		set => TrySetValue<GcAntagonistEnemy>(value);
	}

	public VirtualList<GcAntagonistPerception> Perceptions
	{
		get => cache.GetOrAddValue(new VirtualList<GcAntagonistPerception>(address + GetOffset()));
		set => TrySetValue<GcAntagonistPerception>(value);
	}

	public GcAntagonistComponentData(long address) : base(address)
	{

	}
}
