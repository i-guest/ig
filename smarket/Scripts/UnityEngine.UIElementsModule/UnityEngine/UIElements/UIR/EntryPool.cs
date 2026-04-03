using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements.UIR
{
	internal class EntryPool
	{
		private const int k_StackSize = 128;

		private Stack<Entry>[] m_ThreadEntries;

		private ImplicitPool<Entry> m_SharedPool;

		private static readonly Func<Entry> k_CreateAction;

		private static readonly Action<Entry> k_ResetAction;

		public EntryPool(int maxCapacity = 1024)
		{
		}

		public Entry Get()
		{
			return null;
		}

		public void ReturnAll()
		{
		}
	}
}
