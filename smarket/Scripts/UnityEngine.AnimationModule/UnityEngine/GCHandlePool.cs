using System.Runtime.InteropServices;

namespace UnityEngine
{
	internal class GCHandlePool
	{
		private GCHandle[] m_handles;

		private int m_current;

		public void Free(GCHandle h)
		{
		}
	}
}
