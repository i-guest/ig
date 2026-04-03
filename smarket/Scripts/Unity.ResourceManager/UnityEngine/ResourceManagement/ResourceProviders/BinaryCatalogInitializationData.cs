using System;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	[Serializable]
	internal class BinaryCatalogInitializationData
	{
		[SerializeField]
		public int m_BinaryStorageBufferCacheSize;

		[SerializeField]
		public int m_CatalogLocationCacheSize;
	}
}
