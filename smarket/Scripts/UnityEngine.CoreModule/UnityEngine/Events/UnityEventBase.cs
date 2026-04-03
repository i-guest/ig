using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

namespace UnityEngine.Events
{
	[Serializable]
	[UsedByNativeCode]
	public abstract class UnityEventBase : ISerializationCallbackReceiver
	{
		private static readonly List<WeakReference<UnityEventBase>> s_UnityEvents;

		private InvokableCallList m_Calls;

		[SerializeField]
		[FormerlySerializedAs("m_PersistentListeners")]
		private PersistentCallGroup m_PersistentCalls;

		private bool m_CallsDirty;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void OnPlayModeStateChange()
		{
		}

		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		protected abstract MethodInfo FindMethod_Impl(string name, Type targetObjType);

		internal abstract BaseInvokableCall GetDelegate(object target, MethodInfo theFunction);

		internal MethodInfo FindMethod(PersistentCall call)
		{
			return null;
		}

		internal MethodInfo FindMethod(string name, Type listenerType, PersistentListenerMode mode, Type argumentType)
		{
			return null;
		}

		internal int GetCallsCount()
		{
			return 0;
		}

		public int GetPersistentEventCount()
		{
			return 0;
		}

		public Object GetPersistentTarget(int index)
		{
			return null;
		}

		public string GetPersistentMethodName(int index)
		{
			return null;
		}

		private void DirtyPersistentCalls()
		{
		}

		private void RebuildPersistentCallsIfNeeded()
		{
		}

		internal void AddCall(BaseInvokableCall call)
		{
		}

		protected void RemoveListener(object targetObj, MethodInfo method)
		{
		}

		public void RemoveAllListeners()
		{
		}

		internal List<BaseInvokableCall> PrepareInvoke()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public static MethodInfo GetValidMethodInfo(Type objectType, string functionName, Type[] argumentTypes)
		{
			return null;
		}
	}
}
