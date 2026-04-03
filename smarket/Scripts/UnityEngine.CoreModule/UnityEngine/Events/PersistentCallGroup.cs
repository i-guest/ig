using System;
using System.Collections.Generic;
using UnityEngine.Serialization;

namespace UnityEngine.Events
{
	[Serializable]
	internal class PersistentCallGroup
	{
		[FormerlySerializedAs("m_Listeners")]
		[SerializeField]
		private List<PersistentCall> m_Calls;

		public int Count => 0;

		public PersistentCall GetListener(int index)
		{
			return null;
		}

		public void Initialize(InvokableCallList invokableList, UnityEventBase unityEventBase)
		{
		}
	}
}
