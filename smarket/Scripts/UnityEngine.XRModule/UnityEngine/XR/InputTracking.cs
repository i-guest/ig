using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.XR
{
	[StaticAccessor("XRInputTrackingFacade::Get()", StaticAccessorType.Dot)]
	[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputTrackingFacade.h")]
	[NativeConditional("ENABLE_VR")]
	[RequiredByNativeCode]
	public static class InputTracking
	{
		private enum TrackingStateEventType
		{
			NodeAdded = 0,
			NodeRemoved = 1,
			TrackingAcquired = 2,
			TrackingLost = 3
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<XRNodeState> trackingAcquired;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<XRNodeState> trackingLost;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<XRNodeState> nodeAdded;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<XRNodeState> nodeRemoved;

		[RequiredByNativeCode]
		private static void InvokeTrackingEvent(TrackingStateEventType eventType, XRNode nodeType, long uniqueID, bool tracked)
		{
		}
	}
}
