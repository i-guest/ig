using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XStoreCollectionData
	{
		internal Unity.XGamingRuntime.Interop.XStoreCollectionData interop;

		public long AcquiredDate
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public long StartDate
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public long EndDate
		{
			get
			{
				return 0L;
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

		public uint Quantity
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public string CampaignId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string DeveloperOfferId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal XStoreCollectionData(Unity.XGamingRuntime.Interop.XStoreCollectionData interop)
		{
		}

		public XStoreCollectionData()
		{
		}
	}
}
