using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XStoreCanAcquireLicenseResult
	{
		internal Unity.XGamingRuntime.Interop.XStoreCanAcquireLicenseResult interop;

		public string LicensableSku
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public XStoreCanLicenseStatus Status
		{
			get
			{
				return default(XStoreCanLicenseStatus);
			}
			set
			{
			}
		}

		internal XStoreCanAcquireLicenseResult(Unity.XGamingRuntime.Interop.XStoreCanAcquireLicenseResult interop)
		{
		}

		public XStoreCanAcquireLicenseResult()
		{
		}
	}
}
