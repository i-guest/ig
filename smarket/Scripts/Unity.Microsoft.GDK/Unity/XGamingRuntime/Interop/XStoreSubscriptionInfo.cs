namespace Unity.XGamingRuntime.Interop
{
	internal struct XStoreSubscriptionInfo
	{
		internal bool hasTrialPeriod;

		internal XStoreDurationUnit trialPeriodUnit;

		internal uint trialPeriod;

		internal XStoreDurationUnit billingPeriodUnit;

		internal uint billingPeriod;
	}
}
