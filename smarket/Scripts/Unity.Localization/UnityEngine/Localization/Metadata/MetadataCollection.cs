using System;
using System.Collections.Generic;

namespace UnityEngine.Localization.Metadata
{
	[Serializable]
	public class MetadataCollection : IMetadataCollection
	{
		[SerializeReference]
		private List<IMetadata> m_Items;

		public IList<IMetadata> MetadataEntries => null;

		public bool HasData => false;

		public bool HasMetadata<TObject>()
		{
			return false;
		}

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
	}
}
