using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XStoreSubscriptionInfo
	{
		internal Unity.XGamingRuntime.Interop.XStoreSubscriptionInfo interop;

		public bool HasTrialPeriod
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public XStoreDurationUnit TrialPeriodUnit
		{
			get
			{
				return default(XStoreDurationUnit);
			}
			set
			{
			}
		}

		public uint TrialPeriod
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public XStoreDurationUnit BillingPeriodUnit
		{
			get
			{
				return default(XStoreDurationUnit);
			}
			set
			{
			}
		}

		public uint BillingPeriod
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		internal XStoreSubscriptionInfo(Unity.XGamingRuntime.Interop.XStoreSubscriptionInfo interop)
		{
		}

		public XStoreSubscriptionInfo()
		{
		}
	}
}
