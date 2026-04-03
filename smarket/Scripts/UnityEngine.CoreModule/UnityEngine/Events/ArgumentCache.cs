using System;
using UnityEngine.Serialization;

namespace UnityEngine.Events
{
	[Serializable]
	internal class ArgumentCache : ISerializationCallbackReceiver
	{
		[FormerlySerializedAs("objectArgument")]
		[SerializeField]
		private Object m_ObjectArgument;

		[FormerlySerializedAs("objectArgumentAssemblyTypeName")]
		[SerializeField]
		private string m_ObjectArgumentAssemblyTypeName;

		[FormerlySerializedAs("intArgument")]
		[SerializeField]
		private int m_IntArgument;

		[SerializeField]
		[FormerlySerializedAs("floatArgument")]
		private float m_FloatArgument;

		[SerializeField]
		[FormerlySerializedAs("stringArgument")]
		private string m_StringArgument;

		[SerializeField]
		private bool m_BoolArgument;

		public Object unityObjectArgument => null;

		public string unityObjectArgumentAssemblyTypeName => null;

		public int intArgument => 0;

		public float floatArgument => 0f;

		public string stringArgument => null;

		public bool boolArgument => false;

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}
	}
}
