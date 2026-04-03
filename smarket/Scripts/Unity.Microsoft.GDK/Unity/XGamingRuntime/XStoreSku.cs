using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XStoreSku
	{
		public string SkuId { get; }

		public string Title { get; }

		public string Description { get; }

		public string Language { get; }

		public XStorePrice Price { get; }

		public bool IsTrial { get; }

		public bool IsInUserCollection { get; }

		public XStoreCollectionData CollectionData { get; }

		public bool IsSubscription { get; }

		public XStoreSubscriptionInfo SubscriptionInfo { get; }

		public string[] BundledSkus { get; }

		public XStoreImage[] Images { get; }

		public XStoreVideo[] Videos { get; }

		public XStoreAvailability[] Availabilities { get; }

		internal XStoreSku(ref XStoreSkuInterop interop)
		{
		}
	}
}
