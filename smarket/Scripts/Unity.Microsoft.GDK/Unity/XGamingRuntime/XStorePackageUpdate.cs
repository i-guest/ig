using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XStorePackageUpdate
	{
		internal Unity.XGamingRuntime.Interop.XStorePackageUpdate interop;

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

		public bool IsMandatory
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal XStorePackageUpdate(Unity.XGamingRuntime.Interop.XStorePackageUpdate interop)
		{
		}

		public XStorePackageUpdate()
		{
		}
	}
}
