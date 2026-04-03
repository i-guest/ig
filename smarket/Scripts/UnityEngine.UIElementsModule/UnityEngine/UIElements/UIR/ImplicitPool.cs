using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements.UIR
{
	internal class ImplicitPool<T> where T : class
	{
		private readonly int m_StartCapacity;

		private readonly int m_MaxCapacity;

		private Func<T> m_CreateAction;

		private Action<T> m_ResetAction;

		private List<T> m_List;

		private int m_UsedCount;

		public ImplicitPool(Func<T> createAction, Action<T> resetAction, int startCapacity, int maxCapacity)
		{
		}

		public T Get()
		{
			return null;
		}

		public void ReturnAll()
		{
		}
	}
}
