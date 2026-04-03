using System;

namespace Unity.XGamingRuntime
{
	public class XTaskQueuePortHandle : EquatableHandle
	{
		public override bool IsInvalid => false;

		public XTaskQueuePortHandle(IntPtr handle)
			: base((IntPtr)0, ownsHandle: false, (IntPtr)0)
		{
		}

		protected override bool ReleaseHandle()
		{
			return false;
		}
	}
}
