using System;
using System.Runtime.InteropServices;
using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XblContextHandle : EquatableHandle
	{
		internal GCHandle m_gCHandle;

		internal SDK.XBL.XblMultiplayerSessionChangedHandler sessionChangedCallback;

		internal XblFunctionContext sessionChangedHandlerId;

		internal SDK.XBL.XblMultiplayerSessionSubscriptionLostHandler sessionSubscriptionLostCallback;

		internal XblFunctionContext sessionSubscriptionLostId;

		internal SDK.XBL.XblMultiplayerConnectionIdChangedHandler connectionIdChangedCallback;

		internal XblFunctionContext connectionIdChangedId;

		internal SDK.XBL.XblUserStatisticsStatisticChangedHandler statisticChangedCallback;

		internal XblFunctionContext statisiticsAddChangeId;

		public override bool IsInvalid => false;

		public event SDK.XBL.XblMultiplayerSessionChangedHandler XblMultiplayerSessionChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		public event SDK.XBL.XblMultiplayerSessionSubscriptionLostHandler XblMultiplayerSessionSubscriptionLost
		{
			add
			{
			}
			remove
			{
			}
		}

		public event SDK.XBL.XblMultiplayerConnectionIdChangedHandler XblMultiplayerConnectionIdChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		public event SDK.XBL.XblUserStatisticsStatisticChangedHandler XblUserStatisticsStatisticChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		[MonoPInvokeCallback]
		private static void XblMultiplayerSessionChangedCallback(IntPtr context, Unity.XGamingRuntime.Interop.XblMultiplayerSessionChangeEventArgs args)
		{
		}

		[MonoPInvokeCallback]
		private static void XblMultiplayerSessionSubscriptionLostCallback(IntPtr context)
		{
		}

		[MonoPInvokeCallback]
		private static void XblMultiplayerConnectionIdChangedCallback(IntPtr context)
		{
		}

		[MonoPInvokeCallback]
		private static void XblUserStatisticsAddChangedCallback(Unity.XGamingRuntime.Interop.XblStatisticChangeEventArgs args, IntPtr context)
		{
		}

		internal XblContextHandle(Unity.XGamingRuntime.Interop.XblContextHandle interopHandle)
			: base((IntPtr)0, ownsHandle: false, (IntPtr)0)
		{
		}

		protected override bool ReleaseHandle()
		{
			return false;
		}
	}
}
