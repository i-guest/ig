using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XStoreAvailability
	{
		internal Unity.XGamingRuntime.Interop.XStoreAvailability _interop;

		internal XStorePrice _xstorePrice;

		internal Unity.XGamingRuntime.Interop.XStoreAvailability interop
		{
			get
			{
				return default(Unity.XGamingRuntime.Interop.XStoreAvailability);
			}
			set
			{
			}
		}

		public string AvailabilityId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public XStorePrice Price
		{
			get
			{
				return null;
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

		internal XStoreAvailability(Unity.XGamingRuntime.Interop.XStoreAvailability interop)
		{
		}

		public XStoreAvailability()
		{
		}
	}
}
