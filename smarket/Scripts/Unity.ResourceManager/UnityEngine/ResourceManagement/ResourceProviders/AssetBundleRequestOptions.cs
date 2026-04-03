using System;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.Serialization;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	[Serializable]
	public class AssetBundleRequestOptions : ILocationSizeData
	{
		[FormerlySerializedAs("m_hash")]
		[SerializeField]
		private string m_Hash;

		[FormerlySerializedAs("m_crc")]
		[SerializeField]
		private uint m_Crc;

		[FormerlySerializedAs("m_timeout")]
		[SerializeField]
		private int m_Timeout;

		[FormerlySerializedAs("m_chunkedTransfer")]
		[SerializeField]
		private bool m_ChunkedTransfer;

		[FormerlySerializedAs("m_redirectLimit")]
		[SerializeField]
		private int m_RedirectLimit;

		[FormerlySerializedAs("m_retryCount")]
		[SerializeField]
		private int m_RetryCount;

		[SerializeField]
		private string m_BundleName;

		[SerializeField]
		private AssetLoadMode m_AssetLoadMode;

		[SerializeField]
		private long m_BundleSize;

		[SerializeField]
		private bool m_UseCrcForCachedBundles;

		[SerializeField]
		private bool m_UseUWRForLocalBundles;

		[SerializeField]
		private bool m_ClearOtherCachedVersionsWhenLoaded;

		public string Hash
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public uint Crc
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public int Timeout
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool ChunkedTransfer
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int RedirectLimit
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int RetryCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public string BundleName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public AssetLoadMode AssetLoadMode
		{
			get
			{
				return default(AssetLoadMode);
			}
			set
			{
			}
		}

		public long BundleSize
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public bool UseCrcForCachedBundle
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool UseUnityWebRequestForLocalBundles
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ClearOtherCachedVersionsWhenLoaded
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public virtual long ComputeSize(IResourceLocation location, ResourceManager resourceManager)
		{
			return 0L;
		}
	}
}
