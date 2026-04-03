using System;
using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XAppCaptureTakeScreenshotResult
	{
		internal Unity.XGamingRuntime.Interop.XAppCaptureTakeScreenshotResult data;

		public string LocalId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public XAppCaptureScreenshotFormatFlag AvailableScreenshotFormats
		{
			get
			{
				return default(XAppCaptureScreenshotFormatFlag);
			}
			set
			{
			}
		}

		[Obsolete("XAppScreenshotLocalId will be removed in future releases. Use XAppCaptureTakeScreenshotResult.localId", false)]
		public XAppScreenshotLocalId Id => null;

		internal XAppCaptureTakeScreenshotResult(Unity.XGamingRuntime.Interop.XAppCaptureTakeScreenshotResult interop)
		{
		}

		public XAppCaptureTakeScreenshotResult()
		{
		}
	}
}
