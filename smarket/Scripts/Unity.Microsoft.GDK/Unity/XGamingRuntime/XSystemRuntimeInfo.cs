using Unity.XGamingRuntime.Interop;

namespace Unity.XGamingRuntime
{
	public class XSystemRuntimeInfo
	{
		internal XVersion _runtimeVersion;

		internal XVersion _availableVersion;

		public XVersion RuntimeVersion
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public XVersion AvailableVersion
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal XSystemRuntimeInfo(Unity.XGamingRuntime.Interop.XSystemRuntimeInfo interop)
		{
		}

		public XSystemRuntimeInfo()
		{
		}
	}
}
