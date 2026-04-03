using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XStoreGameLicense
	{
		internal Unity.XGamingRuntime.Interop.XStoreGameLicense interop;

		public string SkuStoreId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsActive
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsTrialOwnedByThisUser
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsDiscLicense
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsTrial
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public uint TrialTimeRemainingInSeconds
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public string TrialUniqueId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public long ExpirationDate
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		internal XStoreGameLicense(Unity.XGamingRuntime.Interop.XStoreGameLicense interop)
		{
		}

		public XStoreGameLicense()
		{
		}
	}
}
