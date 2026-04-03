using System;
using System.Collections.Generic;
using UnityEngine.Localization.Tables;

namespace UnityEngine.Localization.Metadata
{
	[Serializable]
	[Metadata(AllowedTypes = (MetadataType.AllTableEntries | MetadataType.AllSharedTableEntries), AllowMultiple = false)]
	public class PlatformOverride : IEntryOverride, IMetadata, ISerializationCallbackReceiver
	{
		[Serializable]
		private class PlatformOverrideData
		{
			public RuntimePlatform platform;

			public EntryOverrideType entryOverrideType;

			public TableReference tableReference;

			public TableEntryReference tableEntryReference;

			public override string ToString()
			{
				return null;
			}
		}

		[SerializeField]
		private List<PlatformOverrideData> m_PlatformOverrides;

		private PlatformOverrideData m_PlayerPlatformOverride;

		public void AddPlatformTableOverride(RuntimePlatform platform, TableReference table)
		{
		}

		public void AddPlatformEntryOverride(RuntimePlatform platform, TableEntryReference entry)
		{
		}

		public void AddPlatformOverride(RuntimePlatform platform, TableReference table, TableEntryReference entry, EntryOverrideType entryOverrideType = EntryOverrideType.TableAndEntry)
		{
		}

		public bool RemovePlatformOverride(RuntimePlatform platform)
		{
			return false;
		}

		public EntryOverrideType GetOverride(out TableReference tableReference, out TableEntryReference tableEntryReference)
		{
			tableReference = default(TableReference);
			tableEntryReference = default(TableEntryReference);
			return default(EntryOverrideType);
		}

		public EntryOverrideType GetOverride(out TableReference tableReference, out TableEntryReference tableEntryReference, RuntimePlatform platform)
		{
			tableReference = default(TableReference);
			tableEntryReference = default(TableEntryReference);
			return default(EntryOverrideType);
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}
	}
}
