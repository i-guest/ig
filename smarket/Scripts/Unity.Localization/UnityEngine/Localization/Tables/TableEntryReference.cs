using System;

namespace UnityEngine.Localization.Tables
{
	[Serializable]
	public struct TableEntryReference : ISerializationCallbackReceiver, IEquatable<TableEntryReference>
	{
		public enum Type
		{
			Empty = 0,
			Name = 1,
			Id = 2
		}

		[SerializeField]
		private long m_KeyId;

		[SerializeField]
		private string m_Key;

		private bool m_Valid;

		public Type ReferenceType { get; private set; }

		public long KeyId
		{
			get
			{
				return 0L;
			}
			private set
			{
			}
		}

		public string Key
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public static implicit operator TableEntryReference(string key)
		{
			return default(TableEntryReference);
		}

		public static implicit operator TableEntryReference(long keyId)
		{
			return default(TableEntryReference);
		}

		public static implicit operator string(TableEntryReference tableEntryReference)
		{
			return null;
		}

		public static implicit operator long(TableEntryReference tableEntryReference)
		{
			return 0L;
		}

		internal void Validate()
		{
		}

		public string ResolveKeyName(SharedTableData sharedData)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public string ToString(TableReference tableReference)
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(TableEntryReference other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}
	}
}
