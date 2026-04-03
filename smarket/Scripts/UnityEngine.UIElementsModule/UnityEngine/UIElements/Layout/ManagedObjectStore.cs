using System.Collections.Generic;

namespace UnityEngine.UIElements.Layout
{
	internal class ManagedObjectStore<T>
	{
		private readonly int m_ChunkSize;

		private int m_Length;

		private readonly List<T[]> m_Chunks;

		private readonly Queue<int> m_Free;

		public ManagedObjectStore(int chunkSize = 2048)
		{
		}

		public T GetValue(int index)
		{
			return default(T);
		}

		public void UpdateValue(ref int index, T value)
		{
		}
	}
}
