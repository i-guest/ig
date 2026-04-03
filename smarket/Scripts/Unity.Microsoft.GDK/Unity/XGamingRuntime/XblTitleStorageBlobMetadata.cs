using System;
using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XblTitleStorageBlobMetadata
	{
		internal Unity.XGamingRuntime.Interop.XblTitleStorageBlobMetadata interop;

		public string BlobPath
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public XblTitleStorageBlobType BlobType
		{
			get
			{
				return default(XblTitleStorageBlobType);
			}
			set
			{
			}
		}

		public XblTitleStorageType StorageType
		{
			get
			{
				return default(XblTitleStorageType);
			}
			set
			{
			}
		}

		public string DisplayName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string ETag
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public DateTime ClientTimestamp
		{
			get
			{
				return default(DateTime);
			}
			set
			{
			}
		}

		public ulong Length
		{
			get
			{
				return 0uL;
			}
			set
			{
			}
		}

		public string ServiceConfigurationId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ulong XboxUserId
		{
			get
			{
				return 0uL;
			}
			set
			{
			}
		}

		internal XblTitleStorageBlobMetadata(Unity.XGamingRuntime.Interop.XblTitleStorageBlobMetadata interopHandle)
		{
		}

		public XblTitleStorageBlobMetadata()
		{
		}
	}
}
