using Unity.XGamingRuntime.Interop;

namespace Unity.XGamingRuntime
{
	public class XGameStreamingClientId
	{
		internal Unity.XGamingRuntime.Interop.XGameStreamingClientId data;

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

		public XGameStreamingClientId(ulong value)
		{
		}

		internal XGameStreamingClientId(Unity.XGamingRuntime.Interop.XGameStreamingClientId interop)
		{
		}
	}
}
