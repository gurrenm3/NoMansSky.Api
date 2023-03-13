using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkBehaviourTreeConcurrentSelectorData : NMSTemplate
{
	public NMSString0x10 Name
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public libMBIN.NMS.Toolkit.TkBehaviourTreeConcurrentSelectorData.SucceedWhenEnum SucceedWhen
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkBehaviourTreeConcurrentSelectorData.SucceedWhenEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkBehaviourTreeConcurrentSelectorData.SucceedWhenEnum>(value);
	}

	public libMBIN.NMS.Toolkit.TkBehaviourTreeConcurrentSelectorData.FailWhenEnum FailWhen
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkBehaviourTreeConcurrentSelectorData.FailWhenEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkBehaviourTreeConcurrentSelectorData.FailWhenEnum>(value);
	}

	public VirtualList<NMSTemplate> Children
	{
		get => cache.GetOrAddValue(new VirtualList<NMSTemplate>(address + GetOffset()));
		set => TrySetValue<NMSTemplate>(value);
	}

	public TkBehaviourTreeConcurrentSelectorData(long address) : base(address)
	{

	}
}
