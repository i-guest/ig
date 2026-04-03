using System.Collections;
using System.Collections.Generic;

namespace UnityEngine.Localization.Tables
{
	public abstract class DetailedLocalizationTable<TEntry> : LocalizationTable, IDictionary<long, TEntry>, ICollection<KeyValuePair<long, TEntry>>, IEnumerable<KeyValuePair<long, TEntry>>, IEnumerable, ISerializationCallbackReceiver
	{
		private Dictionary<long, TEntry> m_TableEntries;

		ICollection<long> IDictionary<long, TEntry>.Keys => null;

		public ICollection<TEntry> Values => null;

		public int Count => 0;

		public bool IsReadOnly => false;

		public TEntry this[long key]
		{
			get
			{
				return default(TEntry);
			}
			set
			{
			}
		}

		public TEntry this[string keyName]
		{
			get
			{
				return default(TEntry);
			}
			set
			{
			}
		}

		public abstract TEntry CreateTableEntry();

		internal TEntry CreateTableEntry(TableEntryData data)
		{
			return default(TEntry);
		}

		public override void CreateEmpty(TableEntryReference entryReference)
		{
		}

		public TEntry AddEntry(string key, string localized)
		{
			return default(TEntry);
		}

		public virtual TEntry AddEntry(long keyId, string localized)
		{
			return default(TEntry);
		}

		public TEntry AddEntryFromReference(TableEntryReference entryReference, string localized)
		{
			return default(TEntry);
		}

		public bool RemoveEntry(string key)
		{
			return false;
		}

		public virtual bool RemoveEntry(long keyId)
		{
			return false;
		}

		public TEntry GetEntryFromReference(TableEntryReference entryReference)
		{
			return default(TEntry);
		}

		public TEntry GetEntry(string key)
		{
			return default(TEntry);
		}

		public virtual TEntry GetEntry(long keyId)
		{
			return default(TEntry);
		}

		public void Add(long keyId, TEntry value)
		{
		}

		public void Add(KeyValuePair<long, TEntry> item)
		{
		}

		public bool ContainsKey(long keyId)
		{
			return false;
		}

		public bool ContainsValue(string localized)
		{
			return false;
		}

		public bool Contains(KeyValuePair<long, TEntry> item)
		{
			return false;
		}

		public bool Remove(long keyId)
		{
			return false;
		}

		public bool Remove(KeyValuePair<long, TEntry> item)
		{
			return false;
		}

		public IList<TEntry> CheckForMissingSharedTableDataEntries(MissingEntryAction action = MissingEntryAction.Nothing)
		{
			return null;
		}

		public bool TryGetValue(long keyId, out TEntry value)
		{
			value = default(TEntry);
			return false;
		}

		public void Clear()
		{
		}

		public void CopyTo(KeyValuePair<long, TEntry>[] array, int arrayIndex)
		{
		}

		public IEnumerator<KeyValuePair<long, TEntry>> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
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
