using System;
using UnityEngine.Serialization;

namespace UnityEngine.ResourceManagement.Util
{
	[Serializable]
	public struct SerializedType
	{
		[FormerlySerializedAs("m_assemblyName")]
		[SerializeField]
		private string m_AssemblyName;

		[FormerlySerializedAs("m_className")]
		[SerializeField]
		private string m_ClassName;

		private Type m_CachedType;

		public string AssemblyName => null;

		public string ClassName => null;

		public Type Value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool ValueChanged { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
