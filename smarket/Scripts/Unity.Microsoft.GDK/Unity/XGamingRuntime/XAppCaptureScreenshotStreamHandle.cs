using System;

namespace Unity.XGamingRuntime
{
	public class XAppCaptureScreenshotStreamHandle : EquatableHandle
	{
		public int CloseResult { get; private set; }

		public override bool IsInvalid => false;

		public XAppCaptureScreenshotStreamHandle(IntPtr handle)
			: base((IntPtr)0, ownsHandle: false, (IntPtr)0)
		{
		}

		protected override bool ReleaseHandle()
		{
			return false;
		}

		internal static int WrapAndReturnHResult(int hresult, IntPtr interopHandle, out XAppCaptureScreenshotStreamHandle handle)
		{
			handle = null;
			return 0;
		}
	}
}
