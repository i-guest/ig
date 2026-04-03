using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XStoreAddonLicense
	{
		internal Unity.XGamingRuntime.Interop.XStoreAddonLicense interop;

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

		public string InAppOfferToken
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

		internal XStoreAddonLicense(Unity.XGamingRuntime.Interop.XStoreAddonLicense interop)
		{
		}

		public XStoreAddonLicense()
		{
		}
	}
}
