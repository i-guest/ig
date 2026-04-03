using System;
using System.Collections.Generic;
using UnityEngine.Localization.Metadata;

namespace UnityEngine.Localization.Platform.Android
{
	[Serializable]
	[DisplayName("Android Adaptive Icon Info", null)]
	[Metadata(AllowedTypes = MetadataType.LocalizationSettings, AllowMultiple = false, MenuItem = "Android/Adaptive Icon")]
	public class AdaptiveIconsInfo : IMetadata
	{
		[SerializeField]
		private AdaptiveIcon m_Adaptive_idpi;

		[SerializeField]
		private AdaptiveIcon m_Adaptive_mdpi;

		[SerializeField]
		private AdaptiveIcon m_Adaptive_hdpi;

		[SerializeField]
		private AdaptiveIcon m_Adaptive_xhdpi;

		[SerializeField]
		private AdaptiveIcon m_Adaptive_xxhdpi;

		[SerializeField]
		private AdaptiveIcon m_Adaptive_xxxhdpi;

		internal List<AdaptiveIcon> AdaptiveIcons;

		public AdaptiveIcon AdaptiveHdpi
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public AdaptiveIcon AdaptiveIdpi
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public AdaptiveIcon AdaptiveMdpi
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public AdaptiveIcon AdaptiveXhdpi
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public AdaptiveIcon AdaptiveXXHdpi
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public AdaptiveIcon AdaptiveXXXHdpi
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal void RefreshAdaptiveIcons()
		{
		}
	}
}
