using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;

namespace Unity.Collections
{
	internal sealed class NativeHashSetDebuggerTypeProxy<T> where T : struct
	{
		private unsafe HashMapHelper<T>* Data;

		public List<T> Items => null;

		public NativeHashSetDebuggerTypeProxy(NativeHashSet<T> data)
		{
		}
	}
}
