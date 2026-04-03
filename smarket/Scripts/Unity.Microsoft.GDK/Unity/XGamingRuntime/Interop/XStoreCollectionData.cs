namespace Unity.XGamingRuntime.Interop
{
	internal struct XStoreCollectionData
	{
		internal long acquiredDate;

		internal long startDate;

		internal long endDate;

		internal bool isTrial;

		internal uint trialTimeRemainingInSeconds;

		internal uint quantity;

		internal string campaignId;

		internal string developerOfferId;
	}
}
