using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XAppCaptureDiagnosticScreenshotResult
	{
		public XAppCaptureScreenshotFile[] Files { get; set; }

		internal XAppCaptureDiagnosticScreenshotResult(Unity.XGamingRuntime.Interop.XAppCaptureDiagnosticScreenshotResult interop)
		{
		}
	}
}
