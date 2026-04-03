using System;

namespace UnityEngine.Localization.Metadata
{
	[HideInInspector]
	internal class AssetTypeMetadata : SharedTableCollectionMetadata
	{
		[SerializeField]
		[HideInInspector]
		internal string m_TypeString;

		public Type Type { get; set; }

		public override void OnBeforeSerialize()
		{
		}

		public override void OnAfterDeserialize()
		{
		}
	}
}
