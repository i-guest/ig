using System;
using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XAppBroadcastStatus
	{
		internal Unity.XGamingRuntime.Interop.XAppBroadcastStatus interop;

		public bool CanStartBroadcast
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsAnyAppBroadcasting
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsCaptureResourceUnavailable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsGameStreamInProgress
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsGpuConstrained
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsAppInactive
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsBlockedForApp
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsDisabledByUser
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsDisabledBySystem
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Obsolete("Please use CanStartBroadcast instead, (UnityUpgradable) -> CanStartBroadcast", true)]
		public bool canStartBroadcast
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Obsolete("Please use IsAnyAppBroadcasting instead, (UnityUpgradable) -> IsAnyAppBroadcasting", true)]
		public bool isAnyAppBroadcasting
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Obsolete("Please use IsCaptureResourceUnavailable instead, (UnityUpgradable) -> IsCaptureResourceUnavailable", true)]
		public bool isCaptureResourceUnavailable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Obsolete("Please use IsGameStreamInProgress instead, (UnityUpgradable) -> IsGameStreamInProgress", true)]
		public bool isGameStreamInProgress
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Obsolete("Please use IsGpuConstrained instead, (UnityUpgradable) -> IsGpuConstrained", true)]
		public bool isGpuConstrained
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Obsolete("Please use IsAppInactive instead, (UnityUpgradable) -> IsAppInactive", true)]
		public bool isAppInactive
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Obsolete("Please use IsBlockedForApp instead, (UnityUpgradable) -> IsBlockedForApp", true)]
		public bool isBlockedForApp
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Obsolete("Please use IsDisabledByUser instead, (UnityUpgradable) -> IsDisabledByUser", true)]
		public bool isDisabledByUser
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Obsolete("Please use IsDisabledBySystem instead, (UnityUpgradable) -> IsDisabledBySystem", true)]
		public bool isDisabledBySystem
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal XAppBroadcastStatus(Unity.XGamingRuntime.Interop.XAppBroadcastStatus interop)
		{
		}

		public XAppBroadcastStatus()
		{
		}
	}
}
