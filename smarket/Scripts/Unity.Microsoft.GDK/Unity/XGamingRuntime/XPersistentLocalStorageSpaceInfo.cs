using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XPersistentLocalStorageSpaceInfo
	{
		internal Unity.XGamingRuntime.Interop.XPersistentLocalStorageSpaceInfo interop;

		public ulong AvailableFreeBytes
		{
			get
			{
				return 0uL;
			}
			set
			{
			}
		}

		public ulong TotalFreeBytes
		{
			get
			{
				return 0uL;
			}
			set
			{
			}
		}

		public ulong UsedBytes
		{
			get
			{
				return 0uL;
			}
			set
			{
			}
		}

		public ulong TotalBytes
		{
			get
			{
				return 0uL;
			}
			set
			{
			}
		}

		internal XPersistentLocalStorageSpaceInfo(Unity.XGamingRuntime.Interop.XPersistentLocalStorageSpaceInfo interop)
		{
		}

		public XPersistentLocalStorageSpaceInfo()
		{
		}
	}
}
