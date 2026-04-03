using System;
using System.Reflection;
using UnityEngine.Serialization;

namespace UnityEngine.Events
{
	[Serializable]
	internal class PersistentCall : ISerializationCallbackReceiver
	{
		[SerializeField]
		[FormerlySerializedAs("instance")]
		private Object m_Target;

		[SerializeField]
		private string m_TargetAssemblyTypeName;

		[FormerlySerializedAs("methodName")]
		[SerializeField]
		private string m_MethodName;

		[SerializeField]
		[FormerlySerializedAs("mode")]
		private PersistentListenerMode m_Mode;

		[FormerlySerializedAs("arguments")]
		[SerializeField]
		private ArgumentCache m_Arguments;

		[SerializeField]
		[FormerlySerializedAs("m_Enabled")]
		[FormerlySerializedAs("enabled")]
		private UnityEventCallState m_CallState;

		public Object target => null;

		public string targetAssemblyTypeName => null;

		public string methodName => null;

		public PersistentListenerMode mode => default(PersistentListenerMode);

		public ArgumentCache arguments => null;

		public bool IsValid()
		{
			return false;
		}

		public BaseInvokableCall GetRuntimeCall(UnityEventBase theEvent)
		{
			return null;
		}

		private static BaseInvokableCall GetObjectCall(Object target, MethodInfo method, ArgumentCache arguments)
		{
			return null;
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}
	}
}
