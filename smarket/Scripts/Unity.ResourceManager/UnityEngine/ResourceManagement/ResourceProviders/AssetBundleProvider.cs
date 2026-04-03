using System;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.Util;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	[DisplayName("AssetBundle Provider")]
	public class AssetBundleProvider : ResourceProviderBase
	{
		internal static Dictionary<string, AssetBundleUnloadOperation> m_UnloadingBundles;

		protected internal static Dictionary<string, AssetBundleUnloadOperation> UnloadingBundles
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		internal static int UnloadingAssetBundleCount => 0;

		internal static int AssetBundleCount => 0;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void Init()
		{
		}

		internal static void WaitForAllUnloadingBundlesToComplete()
		{
		}

		public override void Provide(ProvideHandle providerInterface)
		{
		}

		public override Type GetDefaultType(IResourceLocation location)
		{
			return null;
		}

		public override void Release(IResourceLocation location, object asset)
		{
		}

		public virtual bool ShouldRetryDownloadError(UnityWebRequestResult uwrResult)
		{
			return false;
		}

		internal virtual IOperationCacheKey CreateCacheKeyForLocation(ResourceManager rm, IResourceLocation location, Type desiredType)
		{
			return null;
		}
	}
}
