using System;
using System.Collections.Generic;
using UnityEngine.Localization.Tables;

namespace UnityEngine.Localization.Metadata
{
	public abstract class SharedTableEntryMetadata : IMetadata, ISerializationCallbackReceiver
	{
		[Serializable]
		private struct Entry
		{
			public long id;
		}

		[SerializeField]
		private List<long> m_Entries;

		[SerializeField]
		private List<Entry> m_SharedEntries;

		private HashSet<long> m_EntriesLookup;

		internal int Count => 0;

		internal bool IsRegistered(TableEntry entry)
		{
			return false;
		}

		internal void Register(TableEntry entry)
		{
		}

		internal void Unregister(TableEntry entry)
		{
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}
	}
}
