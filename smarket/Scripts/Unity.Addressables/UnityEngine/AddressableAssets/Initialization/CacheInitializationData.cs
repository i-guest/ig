using System;
using UnityEngine.Serialization;

namespace UnityEngine.AddressableAssets.Initialization
{
	[Serializable]
	public class CacheInitializationData
	{
		[FormerlySerializedAs("m_compressionEnabled")]
		[SerializeField]
		private bool m_CompressionEnabled;

		[FormerlySerializedAs("m_cacheDirectoryOverride")]
		[SerializeField]
		private string m_CacheDirectoryOverride;

		[FormerlySerializedAs("m_limitCacheSize")]
		[SerializeField]
		private bool m_LimitCacheSize;

		[FormerlySerializedAs("m_maximumCacheSize")]
		[SerializeField]
		private long m_MaximumCacheSize;

		public bool CompressionEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string CacheDirectoryOverride
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool LimitCacheSize
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public long MaximumCacheSize
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}
	}
}
