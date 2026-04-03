using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XGameSaveBlobInfo
	{
		internal Unity.XGamingRuntime.Interop.XGameSaveBlobInfo interop;

		public string Name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public uint Size
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		internal XGameSaveBlobInfo(Unity.XGamingRuntime.Interop.XGameSaveBlobInfo interop)
		{
		}

		public XGameSaveBlobInfo()
		{
		}
	}
}
