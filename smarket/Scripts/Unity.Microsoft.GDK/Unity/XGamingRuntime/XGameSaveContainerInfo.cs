using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XGameSaveContainerInfo
	{
		internal Unity.XGamingRuntime.Interop.XGameSaveContainerInfo interop;

		public string Name
		{
			get
			{
				return null;
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

		public uint BlobCount
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public ulong TotalSize
		{
			get
			{
				return 0uL;
			}
			set
			{
			}
		}

		public long LastModifiedTime
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public bool NeedsSync
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal XGameSaveContainerInfo(Unity.XGamingRuntime.Interop.XGameSaveContainerInfo interop)
		{
		}

		public XGameSaveContainerInfo()
		{
		}
	}
}
