using System.Collections.Generic;

namespace UnityEngine.Localization
{
	internal struct CallbackArray<TDelegate>
	{
		private const int k_AllocationIncrement = 5;

		private TDelegate m_SingleDelegate;

		private TDelegate[] m_MultipleDelegates;

		private List<TDelegate> m_AddCallbacks;

		private List<TDelegate> m_RemoveCallbacks;

		private int m_Length;

		private bool m_CannotMutateCallbacksArray;

		private bool m_MutatedDuringCallback;

		public TDelegate SingleDelegate => default(TDelegate);

		public TDelegate[] MultiDelegates => null;

		public int Length => 0;

		public void Add(TDelegate callback, int capacityIncrement = 5)
		{
		}

		public void RemoveByMovingTail(TDelegate callback)
		{
		}

		public void LockForChanges()
		{
		}

		public void UnlockForChanges()
		{
		}

		public void Clear()
		{
		}
	}
}
