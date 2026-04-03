using System;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[StructLayout((LayoutKind)0)]
	[RequiredByNativeCode]
	public class ResourceRequest : AsyncOperation
	{
		internal string m_Path;

		internal Type m_Type;

		protected virtual Object GetResult()
		{
			return null;
		}

		protected ResourceRequest(IntPtr ptr)
			: base((IntPtr)0)
		{
		}
	}
}
