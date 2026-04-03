using System;
using System.Collections.Generic;
using UnityEngine.Localization.Metadata;

namespace UnityEngine.Localization.Platform.Android
{
	[Serializable]
	[DisplayName("Android Legacy Icon Info", null)]
	[Metadata(AllowedTypes = MetadataType.LocalizationSettings, AllowMultiple = false, MenuItem = "Android/Legacy Icon")]
	public class LegacyIconsInfo : IMetadata
	{
		[SerializeField]
		private LocalizedTexture m_Legacy_idpi;

		[SerializeField]
		private LocalizedTexture m_Legacy_mdpi;

		[SerializeField]
		private LocalizedTexture m_Legacy_hdpi;

		[SerializeField]
		private LocalizedTexture m_Legacy_xhdpi;

		[SerializeField]
		private LocalizedTexture m_Legacy_xxhdpi;

		[SerializeField]
		private LocalizedTexture m_Legacy_xxxhdpi;

		internal List<LocalizedTexture> LegacyIcons;

		public LocalizedTexture LegacyHdpi
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public LocalizedTexture LegacyIdpi
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public LocalizedTexture LegacyMdpi
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public LocalizedTexture LegacyXhdpi
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public LocalizedTexture LegacyXXHdpi
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public LocalizedTexture LegacyXXXHdpi
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal void RefreshLegacyIcons()
		{
		}
	}
}
