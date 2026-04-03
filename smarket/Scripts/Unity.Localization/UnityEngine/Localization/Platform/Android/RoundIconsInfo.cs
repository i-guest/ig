using System;
using System.Collections.Generic;
using UnityEngine.Localization.Metadata;

namespace UnityEngine.Localization.Platform.Android
{
	[Serializable]
	[DisplayName("Android Round Icon Info", null)]
	[Metadata(AllowedTypes = MetadataType.LocalizationSettings, AllowMultiple = false, MenuItem = "Android/Round Icon")]
	public class RoundIconsInfo : IMetadata
	{
		[SerializeField]
		private LocalizedTexture m_Round_idpi;

		[SerializeField]
		private LocalizedTexture m_Round_mdpi;

		[SerializeField]
		private LocalizedTexture m_Round_hdpi;

		[SerializeField]
		private LocalizedTexture m_Round_xhdpi;

		[SerializeField]
		private LocalizedTexture m_Round_xxhdpi;

		[SerializeField]
		private LocalizedTexture m_Round_xxxhdpi;

		internal List<LocalizedTexture> RoundIcons;

		public LocalizedTexture RoundHdpi
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public LocalizedTexture RoundIdpi
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public LocalizedTexture RoundMdpi
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public LocalizedTexture RoundXhdpi
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public LocalizedTexture RoundXXHdpi
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public LocalizedTexture RoundXXXHdpi
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal void RefreshRoundIcons()
		{
		}
	}
}
