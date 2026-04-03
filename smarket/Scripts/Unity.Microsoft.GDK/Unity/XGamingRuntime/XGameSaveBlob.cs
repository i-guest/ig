using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XGameSaveBlob
	{
		public XGameSaveBlobInfo Info { get; set; }

		public byte[] Data { get; set; }

		internal XGameSaveBlob(XGameSaveBlobInterop interop)
		{
		}
	}
}
