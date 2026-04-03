namespace UnityEngine.UnityConsent
{
	public struct ConsentState
	{
		public ConsentStatus AdsIntent;

		public ConsentStatus AnalyticsIntent;

		public ConsentState()
		{
			AdsIntent = default(ConsentStatus);
			AnalyticsIntent = default(ConsentStatus);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
