using System;
using System.Collections.Generic;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.Serialization;

namespace UnityEngine.ResourceManagement.Util
{
	[Serializable]
	public struct ObjectInitializationData
	{
		internal class Serializer : BinaryStorageBuffer.ISerializationAdapter<ObjectInitializationData>, BinaryStorageBuffer.ISerializationAdapter
		{
			private struct Data
			{
				public uint id;

				public uint type;

				public uint data;
			}

			public IEnumerable<BinaryStorageBuffer.ISerializationAdapter> Dependencies => null;

			public object Deserialize(BinaryStorageBuffer.Reader reader, Type t, uint offset, out uint size)
			{
				size = default(uint);
				return null;
			}

			public uint Serialize(BinaryStorageBuffer.Writer writer, object val)
			{
				return 0u;
			}
		}

		[FormerlySerializedAs("m_id")]
		[SerializeField]
		private string m_Id;

		[FormerlySerializedAs("m_objectType")]
		[SerializeField]
		private SerializedType m_ObjectType;

		[FormerlySerializedAs("m_data")]
		[SerializeField]
		private string m_Data;

		public string Id => null;

		public SerializedType ObjectType => default(SerializedType);

		public string Data => null;

		public override string ToString()
		{
			return null;
		}

		public TObject CreateInstance<TObject>(string idOverride = null)
		{
			return default(TObject);
		}

		public AsyncOperationHandle GetAsyncInitHandle(ResourceManager rm, string idOverride = null)
		{
			return default(AsyncOperationHandle);
		}
	}
}
