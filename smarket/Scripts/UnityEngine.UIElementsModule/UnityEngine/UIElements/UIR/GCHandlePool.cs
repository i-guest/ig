using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace UnityEngine.UIElements.UIR
{
	internal class GCHandlePool : IDisposable
	{
		private List<GCHandle> m_Handles;

		private int m_UsedHandlesCount;

		private readonly int k_AllocBatchSize;

		internal bool disposed { get; private set; }

		public GCHandlePool(int capacity = 256, int allocBatchSize = 64)
		{
		}

		public GCHandle Get(object target)
		{
			return default(GCHandle);
		}

		public IntPtr GetIntPtr(object target)
		{
			return (IntPtr)0;
		}

		public void ReturnAll()
		{
		}

		public void Dispose()
		{
		}

		private void Dispose(bool disposing)
		{
		}
	}
}
