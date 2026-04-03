using UnityEngine;

namespace Unity.MemoryProfiler
{
	internal static class MetadataInjector
	{
		public static DefaultMetadataCollect DefaultCollector;

		public static long CollectorCount;

		public static byte DefaultCollectorInjected;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void PlayerInitMetadata()
		{
		}

		private static void InitializeMetadataCollection()
		{
		}
	}
}
