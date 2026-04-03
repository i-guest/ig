using System.Collections.Generic;

namespace Unity.Collections.LowLevel.Unsafe
{
	internal sealed class UnsafeParallelHashSetDebuggerTypeProxy<T> where T : struct
	{
		private UnsafeParallelHashSet<T> Data;

		public List<T> Items => null;

		public UnsafeParallelHashSetDebuggerTypeProxy(UnsafeParallelHashSet<T> data)
		{
		}
	}
}
