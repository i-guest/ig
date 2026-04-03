namespace Unity.XGamingRuntime.Interop
{
	internal struct XStoreGameLicense
	{
		internal string skuStoreId;

		internal bool isActive;

		internal bool isTrialOwnedByThisUser;

		internal bool isDiscLicense;

		internal bool isTrial;

		internal uint trialTimeRemainingInSeconds;

		internal string trialUniqueId;

		internal long expirationDate;
	}
}
