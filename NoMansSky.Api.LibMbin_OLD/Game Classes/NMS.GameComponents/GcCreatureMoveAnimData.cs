using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureMoveAnimData : NMSTemplate
{
	public NMSString0x10 Anim
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 AnimLeft
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 AnimRight
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single AnimSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinSpeedScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxSpeedScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxPredatorSpeedScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinPetSpeedScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxPetSpeedScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AnimMoveSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean AnimMoveSpeedCached
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcCreatureMoveAnimData(long address) : base(address)
	{

	}
}
