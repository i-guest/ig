using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XColor
	{
		internal Unity.XGamingRuntime.Interop.XColor _interop;

		internal ARGB _argb;

		internal Unity.XGamingRuntime.Interop.XColor interop => default(Unity.XGamingRuntime.Interop.XColor);

		public ARGB Argb
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public uint Value
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		internal XColor(Unity.XGamingRuntime.Interop.XColor interop)
		{
		}

		public XColor()
		{
		}
	}
}
