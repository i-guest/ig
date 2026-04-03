using System;

namespace Unity.XGamingRuntime.Interop
{
	internal struct XStoreSkuInterop
	{
		internal string skuId;

		internal string title;

		internal string description;

		internal string language;

		internal XStorePrice price;

		internal bool isTrial;

		internal bool isInUserCollection;

		internal XStoreCollectionData collectionData;

		internal bool isSubscription;

		internal XStoreSubscriptionInfo subscriptionInfo;

		internal uint bundledSkusCount;

		internal IntPtr bundledSkus;

		internal uint imagesCount;

		internal IntPtr images;

		internal uint videosCount;

		internal IntPtr videos;

		internal uint availabilitiesCount;

		internal IntPtr availabilities;
	}
}
