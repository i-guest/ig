using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.ResourceManagement;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.ResourceProviders;

namespace UnityEngine.AddressableAssets.ResourceProviders
{
	[DisplayName("Content Catalog Provider")]
	public class ContentCatalogProvider : ResourceProviderBase
	{
		public enum DependencyHashIndex
		{
			Remote = 0,
			Cache = 1,
			Local = 2,
			Count = 3
		}

		internal class InternalOp
		{
			internal class BundledCatalog
			{
				private readonly string m_BundlePath;

				private bool m_OpInProgress;

				private AssetBundleCreateRequest m_LoadBundleRequest;

				internal AssetBundle m_CatalogAssetBundle;

				private AssetBundleRequest m_LoadTextAssetRequest;

				private ContentCatalogData m_CatalogData;

				private WebRequestQueueOperation m_WebRequestQueueOperation;

				private AsyncOperation m_RequestOperation;

				private int m_WebRequestTimeout;

				public bool OpInProgress => false;

				public bool OpIsSuccess => false;

				public event Action<ContentCatalogData> OnLoaded
				{
					[CompilerGenerated]
					add
					{
					}
					[CompilerGenerated]
					remove
					{
					}
				}

				public BundledCatalog(string bundlePath, int webRequestTimeout = 0)
				{
				}

				~BundledCatalog()
				{
				}

				private void Unload()
				{
				}

				public void LoadCatalogFromBundleAsync()
				{
				}

				private void WebRequestOperationCompleted(AsyncOperation op)
				{
				}

				private void LoadTextAssetRequestComplete(AsyncOperation op)
				{
				}

				public bool WaitForCompletion()
				{
					return false;
				}
			}

			private string m_LocalDataPath;

			private string m_RemoteHashValue;

			internal string m_LocalHashValue;

			private ProvideHandle m_ProviderInterface;

			internal ContentCatalogData m_ContentCatalogData;

			private AsyncOperationHandle<ContentCatalogData> m_ContentCatalogDataLoadOp;

			private BundledCatalog m_BundledCatalog;

			private bool m_Retried;

			private bool m_DisableCatalogUpdateOnStart;

			private bool m_IsLocalCatalogInBundle;

			private const string kCatalogExt = ".bin";

			public void Start(ProvideHandle providerInterface, bool disableCatalogUpdateOnStart, bool isLocalCatalogInBundle)
			{
			}

			private bool WaitForCompletionCallback()
			{
				return false;
			}

			public void Release()
			{
			}

			internal bool CanLoadCatalogFromBundle(string idToLoad, IResourceLocation location)
			{
				return false;
			}

			internal void LoadCatalog(string idToLoad, bool loadCatalogFromLocalBundle)
			{
			}

			private void CatalogLoadOpCompleteCallback(AsyncOperationHandle<ContentCatalogData> op)
			{
			}

			private string GetTransformedInternalId(IResourceLocation loc)
			{
				return null;
			}

			internal string DetermineIdToLoad(IResourceLocation location, IList<object> dependencyObjects, bool disableCatalogUpdateOnStart = false)
			{
				return null;
			}

			private void OnCatalogLoaded(ContentCatalogData ccd)
			{
			}
		}

		public bool DisableCatalogUpdateOnStart;

		public bool IsLocalCatalogInBundle;

		internal Dictionary<IResourceLocation, InternalOp> m_LocationToCatalogLoadOpMap;

		public ContentCatalogProvider(ResourceManager resourceManagerInstance)
		{
		}

		public override void Release(IResourceLocation location, object obj)
		{
		}

		public override void Provide(ProvideHandle providerInterface)
		{
		}
	}
}
