using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XPackageFeature
	{
		internal Unity.XGamingRuntime.Interop.XPackageFeature _interop;

		private string[] _storeIds;

		public string Id
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

		public string Tags
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool Hidden
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string[] StoreIds
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal XPackageFeature(Unity.XGamingRuntime.Interop.XPackageFeature interop)
		{
		}

		public XPackageFeature()
		{
		}
	}
}
