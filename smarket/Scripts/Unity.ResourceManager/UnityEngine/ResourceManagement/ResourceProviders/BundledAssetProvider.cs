using System.Collections.Generic;
using System.ComponentModel;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	[DisplayName("Assets from Bundles Provider")]
	public class BundledAssetProvider : ResourceProviderBase
	{
		internal class InternalOp
		{
			private AssetBundle m_AssetBundle;

			private AssetBundleRequest m_PreloadRequest;

			private AssetBundleRequest m_RequestOperation;

			private object m_Result;

			private ProvideHandle m_ProvideHandle;

			private string subObjectName;

			internal static T LoadBundleFromDependecies<T>(IList<object> results) where T : class
			{
				return null;
			}

			internal static bool IsDownloadOnly(IList<object> results)
			{
				return false;
			}

			public void Start(ProvideHandle provideHandle)
			{
			}

			private void BeginAssetLoad()
			{
			}

			private bool WaitForCompletionHandler()
			{
				return false;
			}

			private void ActionComplete(AsyncOperation obj)
			{
			}

			private void GetArrayResult(Object[] allAssets)
			{
			}

			private void GetListResult(Object[] allAssets)
			{
			}

			private void GetAssetResult(Object asset)
			{
			}

			private void GetAssetSubObjectResult(Object[] allAssets)
			{
			}

			private void CompleteOperation()
			{
			}

			public float ProgressCallback()
			{
				return 0f;
			}
		}

		public override void Provide(ProvideHandle provideHandle)
		{
		}
	}
}
