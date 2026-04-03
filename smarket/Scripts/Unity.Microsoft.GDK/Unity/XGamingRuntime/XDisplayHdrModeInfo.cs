using System;
using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XDisplayHdrModeInfo
	{
		internal Unity.XGamingRuntime.Interop.XDisplayHdrModeInfo interop;

		public float MinToneMapLuminance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float MaxToneMapLuminance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float MaxFullFrameToneMapLuminance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[Obsolete("Please use MinToneMapLuminance instead, (UnityUpgradable) -> MinToneMapLuminance", true)]
		public float minToneMapLuminance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[Obsolete("Please use MaxToneMapLuminance instead, (UnityUpgradable) -> MaxToneMapLuminance", true)]
		public float maxToneMapLuminance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[Obsolete("Please use MaxFullFrameToneMapLuminance instead, (UnityUpgradable) -> MaxFullFrameToneMapLuminance", true)]
		public float maxFullFrameToneMapLuminance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		internal XDisplayHdrModeInfo(Unity.XGamingRuntime.Interop.XDisplayHdrModeInfo interop)
		{
		}

		public XDisplayHdrModeInfo()
		{
		}
	}
}
