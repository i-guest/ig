using System;
using System.Collections.Generic;
using UnityEngine.Localization.Metadata;
using UnityEngine.Serialization;

namespace UnityEngine.Localization.Tables
{
	public abstract class LocalizationTable : ScriptableObject, IMetadataCollection, IComparable<LocalizationTable>
	{
		[SerializeField]
		private LocaleIdentifier m_LocaleId;

		[FormerlySerializedAs("m_KeyDatabase")]
		[SerializeField]
		[HideInInspector]
		private SharedTableData m_SharedData;

		[SerializeField]
		private MetadataCollection m_Metadata;

		[SerializeField]
		private List<TableEntryData> m_TableData;

		public LocaleIdentifier LocaleIdentifier
		{
			get
			{
				return default(LocaleIdentifier);
			}
			set
			{
			}
		}

		public string TableCollectionName => null;

		public SharedTableData SharedData
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal List<TableEntryData> TableData => null;

		public IList<IMetadata> MetadataEntries => null;

		public TObject GetMetadata<TObject>()
		{
			return default(TObject);
		}

		public void GetMetadatas<TObject>(IList<TObject> foundItems)
		{
		}

		public IList<TObject> GetMetadatas<TObject>()
		{
			return null;
		}

		public void AddMetadata(IMetadata md)
		{
		}

		public bool RemoveMetadata(IMetadata md)
		{
			return false;
		}

		public bool Contains(IMetadata md)
		{
			return false;
		}

		public abstract void CreateEmpty(TableEntryReference entryReference);

		protected long FindKeyId(string key, bool addKey)
		{
			return 0L;
		}

		private void VerifySharedTableDataIsNotNull()
		{
		}

		public override string ToString()
		{
			return null;
		}

		public int CompareTo(LocalizationTable other)
		{
			return 0;
		}
	}
}
