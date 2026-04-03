using System.Collections.Generic;

namespace UnityEngine.AddressableAssets
{
	public class PlatformMappingService
	{
		internal static readonly Dictionary<RuntimePlatform, AddressablesPlatform> s_RuntimeTargetMapping;

		internal static AddressablesPlatform GetAddressablesPlatformInternal(RuntimePlatform platform)
		{
			return default(AddressablesPlatform);
		}

		internal static string GetAddressablesPlatformPathInternal(RuntimePlatform platform)
		{
			return null;
		}

		public static string GetPlatformPathSubFolder()
		{
			return null;
		}
	}
}
