using System;
using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XUserLocalId
	{
		internal Unity.XGamingRuntime.Interop.XUserLocalId interop;

		public ulong Value
		{
			get
			{
				return 0uL;
			}
			set
			{
			}
		}

		[Obsolete("Please use Value instead, (UnityUpgradable) -> Value", true)]
		public ulong value
		{
			get
			{
				return 0uL;
			}
			set
			{
			}
		}

		internal XUserLocalId(Unity.XGamingRuntime.Interop.XUserLocalId interop)
		{
		}

		public XUserLocalId()
		{
		}
	}
}
