using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XPackageDetails
	{
		internal Unity.XGamingRuntime.Interop.XPackageDetails interop;

		internal XVersion _XVersion;

		public string PackageIdentifier
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public XVersion Version
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public XPackageKind Kind
		{
			get
			{
				return default(XPackageKind);
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

		public string Description
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Publisher
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string StoreId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool Installing
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal XPackageDetails(Unity.XGamingRuntime.Interop.XPackageDetails interop)
		{
		}

		public XPackageDetails()
		{
		}
	}
}
