using System.Collections.Generic;

namespace UnityEngine.Localization.Metadata
{
	public interface IMetadataCollection
	{
		IList<IMetadata> MetadataEntries { get; }

		TObject GetMetadata<TObject>();

		void GetMetadatas<TObject>(IList<TObject> foundItems);

		IList<TObject> GetMetadatas<TObject>();

		void AddMetadata(IMetadata md);

		bool RemoveMetadata(IMetadata md);

		bool Contains(IMetadata md);
	}
}
