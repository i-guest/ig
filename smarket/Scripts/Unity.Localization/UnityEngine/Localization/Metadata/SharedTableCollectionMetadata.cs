using System;
using System.Collections.Generic;

namespace UnityEngine.Localization.Metadata
{
	[Serializable]
	public abstract class SharedTableCollectionMetadata : IMetadata, ISerializationCallbackReceiver
	{
		[Serializable]
		private class Item
		{
			[SerializeField]
			private long m_KeyId;

			[SerializeField]
			private List<string> m_TableCodes;

			public long KeyId
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public List<string> Tables
			{
				get
				{
					return null;
				}
				set
				{
				}
			}
		}

		[SerializeField]
		[HideInInspector]
		private List<Item> m_Entries;

		public Dictionary<long, HashSet<string>> EntriesLookup { get; set; }

		public bool IsEmpty => false;

		public bool Contains(long keyId)
		{
			return false;
		}

		public bool Contains(long keyId, string code)
		{
			return false;
		}

		public void AddEntry(long keyId, string code)
		{
		}

		public void RemoveEntry(long keyId, string code)
		{
		}

		public virtual void OnBeforeSerialize()
		{
		}

		public virtual void OnAfterDeserialize()
		{
		}
	}
}
