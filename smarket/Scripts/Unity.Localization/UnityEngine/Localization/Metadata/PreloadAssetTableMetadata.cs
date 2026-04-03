using System;

namespace UnityEngine.Localization.Metadata
{
	[Serializable]
	[Metadata(AllowedTypes = (MetadataType.SharedTableData | MetadataType.AssetTable), MenuItem = "Preload Assets")]
	public class PreloadAssetTableMetadata : IMetadata
	{
		public enum PreloadBehaviour
		{
			NoPreload = 0,
			PreloadAll = 1
		}

		[SerializeField]
		private PreloadBehaviour m_PreloadBehaviour;

		public PreloadBehaviour Behaviour
		{
			get
			{
				return default(PreloadBehaviour);
			}
			set
			{
			}
		}
	}
}
