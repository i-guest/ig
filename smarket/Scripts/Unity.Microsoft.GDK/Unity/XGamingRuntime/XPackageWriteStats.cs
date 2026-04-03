using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XPackageWriteStats
	{
		internal Unity.XGamingRuntime.Interop.XPackageWriteStats interop;

		public ulong Interval
		{
			get
			{
				return 0uL;
			}
			set
			{
			}
		}

		public ulong Budget
		{
			get
			{
				return 0uL;
			}
			set
			{
			}
		}

		public ulong Elapsed
		{
			get
			{
				return 0uL;
			}
			set
			{
			}
		}

		public ulong BytesWritten
		{
			get
			{
				return 0uL;
			}
			set
			{
			}
		}

		internal XPackageWriteStats(Unity.XGamingRuntime.Interop.XPackageWriteStats interop)
		{
		}

		public XPackageWriteStats()
		{
		}
	}
}
