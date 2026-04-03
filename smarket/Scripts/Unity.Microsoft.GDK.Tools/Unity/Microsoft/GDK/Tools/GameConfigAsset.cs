using System;
using UnityEngine;

namespace Unity.Microsoft.GDK.Tools
{
	public class GameConfigAsset : ScriptableObject
	{
		public const string k_FileExtension = "mgc";

		[SerializeField]
		[HideInInspector]
		internal string m_IdentityName;

		[SerializeField]
		[HideInInspector]
		internal string m_IdentityPublisher;

		[SerializeField]
		[HideInInspector]
		internal string m_IdentityVersion;

		[SerializeField]
		[HideInInspector]
		internal string m_TitleId;

		[SerializeField]
		[HideInInspector]
		internal string m_SCID;

		[SerializeField]
		[HideInInspector]
		internal string m_MSAAppId;

		[SerializeField]
		[HideInInspector]
		internal string m_StoreId;

		[SerializeField]
		[HideInInspector]
		internal string m_ContentIdOverride;

		[SerializeField]
		[HideInInspector]
		internal string m_EKBIDOverride;

		[SerializeField]
		[HideInInspector]
		internal string[] m_Sandboxes;

		[SerializeField]
		[HideInInspector]
		public LanguagePairs m_LanguagePairs;

		public string IdentityName => null;

		public string IdentityPublisher => null;

		public string IdentityVersion => null;

		public string TitleId
		{
			get
			{
				return null;
			}
			[Obsolete("Please do not use. This will be removed in a future release. See package documentation 'Modify GDK settings with C# script'", false)]
			set
			{
			}
		}

		public string SCID
		{
			get
			{
				return null;
			}
			[Obsolete("Please do not use. This will be removed in a future release. See package documentation 'Modify GDK settings with C# script'", false)]
			set
			{
			}
		}

		public string MSAAppId
		{
			get
			{
				return null;
			}
			[Obsolete("Please do not use. This will be removed in a future release. See package documentation 'Modify GDK settings with C# script'", false)]
			set
			{
			}
		}

		public string StoreId
		{
			get
			{
				return null;
			}
			[Obsolete("Please do not use. This will be removed in a future release. See package documentation 'Modify GDK settings with C# script'", false)]
			set
			{
			}
		}

		public string ContentIdOverride
		{
			get
			{
				return null;
			}
			[Obsolete("Please do not use. This will be removed in a future release. See package documentation 'Modify GDK settings with C# script'", false)]
			set
			{
			}
		}

		public string EKBIDOverride
		{
			get
			{
				return null;
			}
			[Obsolete("Please do not use. This will be removed in a future release. See package documentation 'Modify GDK settings with C# script'", false)]
			set
			{
			}
		}

		public string[] Sandboxes => null;

		public LanguagePairs LanguagePairs => null;

		public static Game LoadAsXmlGameConfig(string xmlGameConfigPath)
		{
			return null;
		}

		public void LoadXmlGameConfig(string xmlGameConfigPath)
		{
		}

		public static void SaveXmlGameConfig(string xmlGameConfigPath, Game xmlGameConfig)
		{
		}

		public void SaveXmlGameConfig(string xmlGameConfigPath)
		{
		}

		public static string GameConfigToString(Game xmlGameConfig)
		{
			return null;
		}

		public void SetLanguagePair(GameConfigLanguages language, bool isActive)
		{
		}

		public bool IsLanguagePairSet(GameConfigLanguages language)
		{
			return false;
		}

		public bool HasLanguagePairSet()
		{
			return false;
		}
	}
}
