using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[StaticAccessor("GetCachingManager()", StaticAccessorType.Dot)]
	[NativeHeader("Runtime/Misc/CachingManager.h")]
	public sealed class Caching
	{
		public static bool compressionEnabled
		{
			set
			{
			}
		}

		public static bool ready
		{
			[NativeName("GetIsReady")]
			get
			{
				return false;
			}
		}

		[StaticAccessor("CachingManagerWrapper", StaticAccessorType.DoubleColon)]
		public static Cache defaultCache
		{
			[NativeName("Caching_GetDefaultCacheHandle")]
			get
			{
				return default(Cache);
			}
		}

		[StaticAccessor("CachingManagerWrapper", StaticAccessorType.DoubleColon)]
		public static Cache currentCacheForWriting
		{
			[NativeName("Caching_GetCurrentCacheHandle")]
			get
			{
				return default(Cache);
			}
			[NativeName("Caching_SetCurrentCacheByHandle")]
			[NativeThrows]
			set
			{
			}
		}

		public static bool ClearCachedVersion(string assetBundleName, Hash128 hash)
		{
			return false;
		}

		[NativeName("ClearCachedVersion")]
		internal static bool ClearCachedVersionInternal(string assetBundleName, Hash128 hash)
		{
			return false;
		}

		public static bool ClearOtherCachedVersions(string assetBundleName, Hash128 hash)
		{
			return false;
		}

		public static bool ClearAllCachedVersions(string assetBundleName)
		{
			return false;
		}

		internal static bool ClearCachedVersions(string assetBundleName, Hash128 hash, bool keepInputVersion)
		{
			return false;
		}

		public static bool IsVersionCached(CachedAssetBundle cachedBundle)
		{
			return false;
		}

		[NativeName("IsCached")]
		internal static bool IsVersionCached(string url, string assetBundleName, Hash128 hash)
		{
			return false;
		}

		public static Cache AddCache(string cachePath)
		{
			return default(Cache);
		}

		[NativeName("AddCachePath")]
		internal static Cache AddCache(string cachePath, bool isReadonly)
		{
			return default(Cache);
		}

		[StaticAccessor("CachingManagerWrapper", StaticAccessorType.DoubleColon)]
		[NativeThrows]
		[NativeName("Caching_GetCacheHandleByPath")]
		public static Cache GetCacheByPath(string cachePath)
		{
			return default(Cache);
		}

		private static bool ClearCachedVersionInternal_Injected(ref ManagedSpanWrapper assetBundleName, [In] ref Hash128 hash)
		{
			return false;
		}

		private static bool ClearCachedVersions_Injected(ref ManagedSpanWrapper assetBundleName, [In] ref Hash128 hash, bool keepInputVersion)
		{
			return false;
		}

		private static bool IsVersionCached_Injected(ref ManagedSpanWrapper url, ref ManagedSpanWrapper assetBundleName, [In] ref Hash128 hash)
		{
			return false;
		}

		private static void AddCache_Injected(ref ManagedSpanWrapper cachePath, bool isReadonly, out Cache ret)
		{
			ret = default(Cache);
		}

		private static void GetCacheByPath_Injected(ref ManagedSpanWrapper cachePath, out Cache ret)
		{
			ret = default(Cache);
		}

		private static void get_defaultCache_Injected(out Cache ret)
		{
			ret = default(Cache);
		}

		private static void get_currentCacheForWriting_Injected(out Cache ret)
		{
			ret = default(Cache);
		}

		private static void set_currentCacheForWriting_Injected([In] ref Cache value)
		{
		}
	}
}
