using System;
using UnityEngine.ResourceManagement.Util;
using UnityEngine.Serialization;

namespace UnityEngine.AddressableAssets.ResourceLocators
{
	[Serializable]
	public class ResourceLocationData
	{
		[FormerlySerializedAs("m_keys")]
		[SerializeField]
		private string[] m_Keys;

		[FormerlySerializedAs("m_internalId")]
		[SerializeField]
		private string m_InternalId;

		[FormerlySerializedAs("m_provider")]
		[SerializeField]
		private string m_Provider;

		[FormerlySerializedAs("m_dependencies")]
		[SerializeField]
		private string[] m_Dependencies;

		[SerializeField]
		private SerializedType m_ResourceType;

		[SerializeField]
		private byte[] SerializedData;

		private object _Data;

		public string[] Keys => null;

		public string InternalId => null;

		public string Provider => null;

		public string[] Dependencies => null;

		public Type ResourceType => null;

		public object Data
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ResourceLocationData(string[] keys, string id, Type provider, Type t, string[] dependencies = null)
		{
		}
	}
}
