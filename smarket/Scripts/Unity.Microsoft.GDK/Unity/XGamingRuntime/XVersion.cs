using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XVersion
	{
		internal Unity.XGamingRuntime.Interop.XVersion interop;

		public ushort Major
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public ushort Minor
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public ushort Build
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public ushort Revision
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

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

		internal XVersion(Unity.XGamingRuntime.Interop.XVersion interop)
		{
		}

		public XVersion()
		{
		}
	}
}
