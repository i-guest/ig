using System;
using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XGameUiWebAuthenticationResultData
	{
		internal Unity.XGamingRuntime.Interop.XGameUiWebAuthenticationResultData data;

		public uint ResponseStatus
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public ulong ResponseCompletionUriSize
		{
			get
			{
				return 0uL;
			}
			set
			{
			}
		}

		public string ResponseCompletionUri
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Obsolete("Please use ResponseStatus instead, (UnityUpgradable) -> ResponseStatus", true)]
		public uint responseStatus
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		[Obsolete("Please use ResponseCompletionUriSize instead, (UnityUpgradable) -> ResponseCompletionUriSize", true)]
		public ulong responseCompletionUriSize
		{
			get
			{
				return 0uL;
			}
			set
			{
			}
		}

		[Obsolete("Please use ResponseCompletionUri instead, (UnityUpgradable) -> ResponseCompletionUri", true)]
		public string responseCompletionUri
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal XGameUiWebAuthenticationResultData(Unity.XGamingRuntime.Interop.XGameUiWebAuthenticationResultData interop)
		{
		}

		public XGameUiWebAuthenticationResultData()
		{
		}
	}
}
