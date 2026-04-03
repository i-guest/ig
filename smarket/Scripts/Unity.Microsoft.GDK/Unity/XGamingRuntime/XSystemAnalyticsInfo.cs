using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore.Interop")]
	public class XSystemAnalyticsInfo
	{
		internal Unity.XGamingRuntime.Interop.XSystemAnalyticsInfo interop;

		private XVersion _osVersion;

		private XVersion _hostingOsVersion;

		public XVersion OsVersion
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public XVersion HostingOsVersion
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Family
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Form
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal XSystemAnalyticsInfo(Unity.XGamingRuntime.Interop.XSystemAnalyticsInfo interop)
		{
		}

		public XSystemAnalyticsInfo()
		{
		}
	}
}
