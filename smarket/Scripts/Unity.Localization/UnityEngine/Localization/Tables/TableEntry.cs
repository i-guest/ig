using System.Collections.Generic;
using UnityEngine.Localization.Metadata;

namespace UnityEngine.Localization.Tables
{
	public class TableEntry : IMetadataCollection
	{
		private SharedTableData.SharedTableEntry m_SharedTableEntry;

		public LocalizationTable Table { get; internal set; }

		internal TableEntryData Data { get; set; }

		public SharedTableData.SharedTableEntry SharedEntry => null;

		public string Key
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public long KeyId => 0L;

		public string LocalizedValue => null;

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

		public bool HasTagMetadata<TShared>()
		{
			return false;
		}

		public void AddTagMetadata<TShared>() where TShared : new()
		{
		}

		public void AddSharedMetadata(SharedTableEntryMetadata md)
		{
		}

		public void AddSharedMetadata(SharedTableCollectionMetadata md)
		{
		}

		public void AddMetadata(IMetadata md)
		{
		}

		public void RemoveTagMetadata<TShared>()
		{
		}

		public void RemoveSharedMetadata(SharedTableEntryMetadata md)
		{
		}

		public void RemoveSharedMetadata(SharedTableCollectionMetadata md)
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

		public override string ToString()
		{
			return null;
		}
	}
}
