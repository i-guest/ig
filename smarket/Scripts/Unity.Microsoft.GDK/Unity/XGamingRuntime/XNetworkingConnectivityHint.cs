using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XNetworkingConnectivityHint
	{
		internal Unity.XGamingRuntime.Interop.XNetworkingConnectivityHint data;

		public XNetworkingConnectivityLevelHint ConnectivityLevel
		{
			get
			{
				return default(XNetworkingConnectivityLevelHint);
			}
			set
			{
			}
		}

		public XNetworkingConnectivityCostHint ConnectivityCost
		{
			get
			{
				return default(XNetworkingConnectivityCostHint);
			}
			set
			{
			}
		}

		public uint IanaInterfaceType
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public bool NetworkInitialized
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ApproachingDataLimit
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool OverDataLimit
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool Roaming
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal XNetworkingConnectivityHint(Unity.XGamingRuntime.Interop.XNetworkingConnectivityHint interop)
		{
		}

		public XNetworkingConnectivityHint()
		{
		}
	}
}
