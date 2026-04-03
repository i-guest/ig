using System;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.Util;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	[Serializable]
	public class BinaryCatalogInitialization : IInitializableObject
	{
		public const int kDefaultBinaryStorageBufferCacheSize = 128;

		public const int kCatalogLocationCacheSize = 32;

		private static int s_BinaryStorageBufferCacheSize;

		private static int s_CatalogLocationCacheSize;

		public static int BinaryStorageBufferCacheSize => 0;

		public static int CatalogLocationCacheSize => 0;

		public static void ResetToDefaults()
		{
		}

		public bool Initialize(string id, string dataStr)
		{
			return false;
		}

		public AsyncOperationHandle<bool> InitializeAsync(ResourceManager resourceManager, string id, string dataStr)
		{
			return default(AsyncOperationHandle<bool>);
		}
	}
}
