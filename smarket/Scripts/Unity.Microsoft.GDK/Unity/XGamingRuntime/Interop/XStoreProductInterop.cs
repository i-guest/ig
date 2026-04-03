using System;

namespace Unity.XGamingRuntime.Interop
{
	internal struct XStoreProductInterop
	{
		internal string storeId;

		internal string title;

		internal string description;

		internal string language;

		internal string inAppOfferToken;

		internal string linkUri;

		internal XStoreProductKind productKind;

		internal XStorePrice price;

		internal bool hasDigitalDownload;

		internal bool isInUserCollection;

		internal uint keywordsCount;

		internal IntPtr keywords;

		internal uint skusCount;

		internal IntPtr skus;

		internal uint imagesCount;

		internal IntPtr images;

		internal uint videosCount;

		internal IntPtr videos;
	}
}
