using System;
using System.Runtime.InteropServices;

namespace UnityEngine.UIElements.Experimental
{
	[StructLayout((LayoutKind)0, Size = 1)]
	internal struct EventDebuggerLogIMGUICall : IDisposable
	{
		public EventDebuggerLogIMGUICall(EventBase evt)
		{
		}

		public void Dispose()
		{
		}
	}
}
