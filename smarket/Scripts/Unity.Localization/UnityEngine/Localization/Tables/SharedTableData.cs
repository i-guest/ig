using System;
using System.Collections.Generic;
using UnityEngine.Localization.Metadata;
using UnityEngine.Serialization;

namespace UnityEngine.Localization.Tables
{
	public class SharedTableData : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		public class SharedTableEntry
		{
			[SerializeField]
			private long m_Id;

			[SerializeField]
			private string m_Key;

			[SerializeField]
			private MetadataCollection m_Metadata;

			public long Id
			{
				get
				{
					return 0L;
				}
				internal set
				{
				}
			}

			public string Key
			{
				get
				{
					return null;
				}
				internal set
				{
				}
			}

			public MetadataCollection Metadata
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public override string ToString()
			{
				return null;
			}
		}

		public const long EmptyId = 0L;

		internal const string NewEntryKey = "New Entry";

		[FormerlySerializedAs("m_TableName")]
		[SerializeField]
		private string m_TableCollectionName;

		[FormerlySerializedAs("m_TableNameGuidString")]
		[SerializeField]
		private string m_TableCollectionNameGuidString;

		[SerializeField]
		private List<SharedTableEntry> m_Entries;

		[SerializeField]
		[MetadataType(MetadataType.SharedTableData)]
		private MetadataCollection m_Metadata;

		[SerializeReference]
		private IKeyGenerator m_KeyGenerator;

		private Guid m_TableCollectionNameGuid;

		private Dictionary<long, SharedTableEntry> m_IdDictionary;

		private Dictionary<string, SharedTableEntry> m_KeyDictionary;

		public List<SharedTableEntry> Entries
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string TableCollectionName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Guid TableCollectionNameGuid
		{
			get
			{
				return default(Guid);
			}
			internal set
			{
			}
		}

		public MetadataCollection Metadata
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IKeyGenerator KeyGenerator
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void Clear()
		{
		}

		public string GetKey(long id)
		{
			return null;
		}

		public long GetId(string key)
		{
			return 0L;
		}

		public long GetId(string key, bool addNewKey)
		{
			return 0L;
		}

		public SharedTableEntry GetEntryFromReference(TableEntryReference tableEntryReference)
		{
			return null;
		}

		public SharedTableEntry GetEntry(long id)
		{
			return null;
		}

		public SharedTableEntry GetEntry(string key)
		{
			return null;
		}

		public bool Contains(long id)
		{
			return false;
		}

		public bool Contains(string key)
		{
			return false;
		}

		public SharedTableEntry AddKey(string key, long id)
		{
			return null;
		}

		public SharedTableEntry AddKey(string key = null)
		{
			return null;
		}

		public void RemoveKey(long id)
		{
		}

		public void RemoveKey(string key)
		{
		}

		public void RenameKey(long id, string newValue)
		{
		}

		public void RenameKey(string oldValue, string newValue)
		{
		}

		public bool RemapId(long currentId, long newId)
		{
			return false;
		}

		[Obsolete("FindSimilarKey will be removed in the future, please use Unity Search. See TableEntrySearchData class for further details.")]
		public SharedTableEntry FindSimilarKey(string text, out int distance)
		{
			distance = default(int);
			return null;
		}

		private static int ComputeLevenshteinDistance(string a, string b)
		{
			return 0;
		}

		private SharedTableEntry AddKeyInternal(string key)
		{
			return null;
		}

		private SharedTableEntry AddKeyInternal(string key, long id)
		{
			return null;
		}

		private void RenameKeyInternal(SharedTableEntry entry, string newValue)
		{
		}

		private void RemoveKeyInternal(SharedTableEntry entry)
		{
		}

		private SharedTableEntry FindWithId(long id)
		{
			return null;
		}

		private SharedTableEntry FindWithKey(string key)
		{
			return null;
		}

		public override string ToString()
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
