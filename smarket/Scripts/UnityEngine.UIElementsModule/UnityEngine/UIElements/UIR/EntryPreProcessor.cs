using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements.UIR
{
	internal class EntryPreProcessor
	{
		public struct AllocSize
		{
			public int vertexCount;

			public int indexCount;
		}

		private int m_ChildrenIndex;

		private List<AllocSize> m_Allocs;

		private List<AllocSize> m_HeadAllocs;

		private List<AllocSize> m_TailAllocs;

		private List<Entry> m_FlattenedEntries;

		private AllocSize m_Pending;

		private Stack<AllocSize> m_Mask;

		private bool m_IsPushingMask;

		public int childrenIndex => 0;

		public List<AllocSize> headAllocs => null;

		public List<AllocSize> tailAllocs => null;

		public List<Entry> flattenedEntries => null;

		public void PreProcess(Entry root)
		{
		}

		public void ClearReferences()
		{
		}

		private void DoEvaluate(Entry entry)
		{
		}

		private void Add(int vertexCount, int indexCount)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void Flush()
		{
		}
	}
}
