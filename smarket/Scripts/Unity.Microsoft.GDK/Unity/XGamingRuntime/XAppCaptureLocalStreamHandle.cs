using System;

namespace Unity.XGamingRuntime
{
	public class XAppCaptureLocalStreamHandle : EquatableHandle
	{
		public int CloseResult { get; private set; }

		public override bool IsInvalid => false;

		public XAppCaptureLocalStreamHandle(IntPtr handle)
			: base((IntPtr)0, ownsHandle: false, (IntPtr)0)
		{
		}

		protected override bool ReleaseHandle()
		{
			return false;
		}
	}
}
