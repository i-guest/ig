using System.Collections.Generic;

namespace Unity.Collections
{
	internal sealed class NativeParallelHashSetDebuggerTypeProxy<T> where T : struct
	{
		private NativeParallelHashSet<T> Data;

		public List<T> Items => null;

		public NativeParallelHashSetDebuggerTypeProxy(NativeParallelHashSet<T> data)
		{
		}
	}
}
