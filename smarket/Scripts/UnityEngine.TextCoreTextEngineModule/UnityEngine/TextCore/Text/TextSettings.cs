using System;
using System.Collections.Generic;
using UnityEngine.Bindings;
using UnityEngine.Serialization;

namespace UnityEngine.TextCore.Text
{
	[Serializable]
	[ExcludeFromPreset]
	[ExcludeFromObjectFactory]
	[NativeHeader("Modules/TextCoreTextEngine/Native/TextSettings.h")]
	public class TextSettings : ScriptableObject
	{
		[Serializable]
		internal struct FontReferenceMap
		{
			public Font font;

			public FontAsset fontAsset;

			public FontReferenceMap(Font font, FontAsset fontAsset)
			{
				this.font = null;
				this.fontAsset = null;
			}
		}

		[SerializeField]
		protected string m_Version;

		[FormerlySerializedAs("m_defaultFontAsset")]
		[SerializeField]
		protected FontAsset m_DefaultFontAsset;

		[FormerlySerializedAs("m_defaultFontAssetPath")]
		[SerializeField]
		protected string m_DefaultFontAssetPath;

		[SerializeField]
		[FormerlySerializedAs("m_fallbackFontAssets")]
		protected List<FontAsset> m_FallbackFontAssets;

		private static List<FontAsset> s_FallbackOSFontAssetInternal;

		[SerializeField]
		[FormerlySerializedAs("m_matchMaterialPreset")]
		protected bool m_MatchMaterialPreset;

		[SerializeField]
		[FormerlySerializedAs("m_missingGlyphCharacter")]
		protected int m_MissingCharacterUnicode;

		[SerializeField]
		protected bool m_ClearDynamicDataOnBuild;

		[SerializeField]
		private bool m_EnableEmojiSupport;

		[SerializeField]
		private List<TextAsset> m_EmojiFallbackTextAssets;

		[FormerlySerializedAs("m_defaultSpriteAsset")]
		[SerializeField]
		protected SpriteAsset m_DefaultSpriteAsset;

		[FormerlySerializedAs("m_defaultSpriteAssetPath")]
		[SerializeField]
		protected string m_DefaultSpriteAssetPath;

		[SerializeField]
		protected List<SpriteAsset> m_FallbackSpriteAssets;

		[SerializeField]
		protected uint m_MissingSpriteCharacterUnicode;

		[SerializeField]
		[FormerlySerializedAs("m_defaultStyleSheet")]
		protected TextStyleSheet m_DefaultStyleSheet;

		private string m_StyleSheetsResourcePath;

		[FormerlySerializedAs("m_defaultColorGradientPresetsPath")]
		[SerializeField]
		protected string m_DefaultColorGradientPresetsPath;

		[SerializeField]
		protected UnicodeLineBreakingRules m_UnicodeLineBreakingRules;

		[FormerlySerializedAs("m_warningsDisabled")]
		[SerializeField]
		protected bool m_DisplayWarnings;

		internal Dictionary<int, FontAsset> m_FontLookup;

		internal List<FontReferenceMap> m_FontReferences;

		private IntPtr m_NativeTextSettings;

		private bool m_IsNativeTextSettingsDirty;

		public string version
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public FontAsset defaultFontAsset
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string defaultFontAssetPath
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<FontAsset> fallbackFontAssets
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal List<FontAsset> fallbackOSFontAssets
		{
			[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
			get
			{
				return null;
			}
		}

		public bool matchMaterialPreset
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int missingCharacterUnicode
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool clearDynamicDataOnBuild
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool enableEmojiSupport
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public List<TextAsset> emojiFallbackTextAssets
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public SpriteAsset defaultSpriteAsset
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string defaultSpriteAssetPath
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Obsolete("The Fallback Sprite Assets list is now obsolete. Use the emojiFallbackTextAssets instead.", true)]
		public List<SpriteAsset> fallbackSpriteAssets
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal static SpriteAsset s_GlobalSpriteAsset { get; private set; }

		public uint missingSpriteCharacterUnicode
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public TextStyleSheet defaultStyleSheet
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Obsolete("styleSheetsResourcePath is no longer used and will be removed in a future version.", false)]
		public string styleSheetsResourcePath
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string defaultColorGradientPresetsPath
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public UnicodeLineBreakingRules lineBreakingRules
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool displayWarnings
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal IntPtr nativeTextSettings
		{
			[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
			get
			{
				return (IntPtr)0;
			}
		}

		internal virtual List<FontAsset> GetStaticFallbackOSFontAsset()
		{
			return null;
		}

		internal virtual void SetStaticFallbackOSFontAsset(List<FontAsset> fontAssets)
		{
		}

		internal virtual List<FontAsset> GetFallbackFontAssets(bool isRaster, int textPixelSize = -1)
		{
			return null;
		}

		private void OnEnable()
		{
		}

		private void OnDestroy()
		{
		}

		protected void InitializeFontReferenceLookup()
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
		internal FontAsset GetCachedFontAsset(Font font)
		{
			return null;
		}

		private List<FontAsset> GetOSFontAssetList()
		{
			return null;
		}

		[NativeMethod(Name = "TextSettings::Create")]
		private static IntPtr CreateNativeObject(IntPtr[] fallbacks, IntPtr managedObject)
		{
			return (IntPtr)0;
		}

		[NativeMethod(Name = "TextSettings::Destroy")]
		private static void DestroyNativeObject(IntPtr m_NativeTextSettings, IntPtr managedObject)
		{
		}

		private static void UpdateFallbacks(IntPtr ptr, IntPtr[] fallbacks)
		{
		}

		private IntPtr[] GetGlobalFallbacks()
		{
			return null;
		}

		internal void SetNativeTextSettingsDirty()
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal void UpdateNativeTextSettings()
		{
		}

		private static IntPtr CreateNativeObject_Injected(ref ManagedSpanWrapper fallbacks, IntPtr managedObject)
		{
			return (IntPtr)0;
		}

		private static void UpdateFallbacks_Injected(IntPtr ptr, ref ManagedSpanWrapper fallbacks)
		{
		}
	}
}
