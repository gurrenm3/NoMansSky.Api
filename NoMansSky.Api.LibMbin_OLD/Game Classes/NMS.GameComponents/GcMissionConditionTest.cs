using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionTest : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcMissionConditionTest.ConditionTestEnum ConditionTest
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMissionConditionTest.ConditionTestEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMissionConditionTest.ConditionTestEnum>(value);
	}

	public GcMissionConditionTest(long address) : base(address)
	{

	}
}
