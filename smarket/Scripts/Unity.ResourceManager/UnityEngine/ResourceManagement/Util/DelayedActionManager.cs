using System;
using System.Collections.Generic;

namespace UnityEngine.ResourceManagement.Util
{
	internal class DelayedActionManager : ComponentSingleton<DelayedActionManager>
	{
		private struct DelegateInfo
		{
			private static int s_Id;

			private int m_Id;

			private Delegate m_Delegate;

			private object[] m_Target;

			public float InvocationTime { get; private set; }

			public DelegateInfo(Delegate d, float invocationTime, params object[] p)
			{
				m_Id = 0;
				m_Delegate = null;
				m_Target = null;
				InvocationTime = 0f;
			}

			public override string ToString()
			{
				return null;
			}

			public void Invoke()
			{
			}
		}

		private List<DelegateInfo>[] m_Actions;

		private LinkedList<DelegateInfo> m_DelayedActions;

		private Stack<LinkedListNode<DelegateInfo>> m_NodeCache;

		private int m_CollectionIndex;

		private bool m_DestroyOnCompletion;

		public static bool IsActive => false;

		private LinkedListNode<DelegateInfo> GetNode(ref DelegateInfo del)
		{
			return null;
		}

		public static void Clear()
		{
		}

		private void DestroyWhenComplete()
		{
		}

		public static void AddAction(Delegate action, float delay = 0f, params object[] parameters)
		{
		}

		private void AddActionInternal(Delegate action, float delay, params object[] parameters)
		{
		}

		public static bool Wait(float timeout = 0f, float timeAdvanceAmount = 0f)
		{
			return false;
		}

		private void LateUpdate()
		{
		}

		private void InternalLateUpdate(float t)
		{
		}

		private void OnApplicationQuit()
		{
		}
	}
}
