using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XStoreProduct
	{
		public string StoreId { get; }

		public string Title { get; }

		public string Description { get; }

		public string Language { get; }

		public string InAppOfferToken { get; }

		public string LinkUri { get; }

		public XStoreProductKind ProductKind { get; }

		public XStorePrice Price { get; }

		public bool HasDigitalDownload { get; }

		public bool IsInUserCollection { get; }

		public string[] Keywords { get; }

		public XStoreSku[] Skus { get; }

		public XStoreImage[] Images { get; }

		public XStoreVideo[] Videos { get; }

		internal XStoreProduct(ref XStoreProductInterop interop)
		{
		}
	}
}
