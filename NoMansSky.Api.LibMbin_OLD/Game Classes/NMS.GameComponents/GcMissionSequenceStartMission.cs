using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionSequenceStartMission : NMSTemplate
{
	public NMSString0x80 Message
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x10 MissionID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean MakeCurrent
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean Restart
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean Forced
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x80 DebugText
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcMissionSequenceStartMission(long address) : base(address)
	{

	}
}
