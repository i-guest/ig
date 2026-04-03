using System;
using System.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine.TextCore.Text
{
	[VisibleToOtherModules(new string[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
	internal class TextGenerationSettings : IEquatable<TextGenerationSettings>
	{
		[VisibleToOtherModules(new string[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
		internal static Func<bool> IsEditorTextRenderingModeBitmap;

		[VisibleToOtherModules(new string[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
		internal static Func<bool> IsEditorTextRenderingModeRaster;

		private RenderedText m_RenderedText;

		private string m_CachedRenderedText;

		public Rect screenRect;

		public FontAsset fontAsset;

		public FontStyles fontStyle;

		public TextSettings textSettings;

		public TextAlignment textAlignment;

		public TextOverflowMode overflowMode;

		public const float wordWrappingRatio = 0.4f;

		public Color color;

		public bool shouldConvertToLinearSpace;

		public int fontSize;

		public const bool autoSize = false;

		public const float fontSizeMin = 0f;

		public const float fontSizeMax = 0f;

		internal static readonly List<OTL_FeatureTag> fontFeatures;

		public bool emojiFallbackSupport;

		public bool richText;

		public bool isRightToLeft;

		public float extraPadding;

		public bool parseControlCharacters;

		public bool isPlaceholder;

		public const bool tagNoParsing = false;

		public float characterSpacing;

		public float wordSpacing;

		public const float lineSpacing = 0f;

		public float paragraphSpacing;

		public const float lineSpacingMax = 0f;

		public TextWrappingMode textWrappingMode;

		public const int maxVisibleCharacters = 99999;

		public const int maxVisibleWords = 99999;

		public const int maxVisibleLines = 99999;

		public const int firstVisibleCharacter = 0;

		public const bool useMaxVisibleDescender = false;

		public TextFontWeight fontWeight;

		public bool isIMGUI;

		public const float charWidthMaxAdj = 0f;

		public float pixelsPerPoint;

		public RenderedText renderedText
		{
			get
			{
				return default(RenderedText);
			}
			set
			{
			}
		}

		public string text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool Equals(TextGenerationSettings other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool operator !=(TextGenerationSettings left, TextGenerationSettings right)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
