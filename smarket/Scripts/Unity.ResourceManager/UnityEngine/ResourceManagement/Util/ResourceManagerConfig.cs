using System;
using System.Collections;

namespace UnityEngine.ResourceManagement.Util
{
	public static class ResourceManagerConfig
	{
		public static bool ExtractKeyAndSubKey(object keyObj, out string mainKey, out string subKey)
		{
			mainKey = null;
			subKey = null;
			return false;
		}

		public static bool IsPathRemote(string path)
		{
			return false;
		}

		public static string StripQueryParameters(string path)
		{
			return null;
		}

		public static bool ShouldPathUseWebRequest(string path)
		{
			return false;
		}

		private static bool PlatformCanLoadLocallyFromUrlPath()
		{
			return false;
		}

		public static Array CreateArrayResult(Type type, Object[] allAssets)
		{
			return null;
		}

		public static TObject CreateArrayResult<TObject>(Object[] allAssets) where TObject : class
		{
			return null;
		}

		public static IList CreateListResult(Type type, Object[] allAssets)
		{
			return null;
		}

		public static TObject CreateListResult<TObject>(Object[] allAssets)
		{
			return default(TObject);
		}

		public static bool IsInstance<T1, T2>()
		{
			return false;
		}
	}
}
