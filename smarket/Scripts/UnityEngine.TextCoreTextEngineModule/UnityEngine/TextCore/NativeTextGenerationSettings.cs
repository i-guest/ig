using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.TextCore.Text;

namespace UnityEngine.TextCore
{
	[UsedByNativeCode("TextGenerationSettings")]
	[VisibleToOtherModules(new string[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
	[NativeHeader("Modules/TextCoreTextEngine/Native/TextGenerationSettings.h")]
	internal struct NativeTextGenerationSettings
	{
		public IntPtr fontAsset;

		public IntPtr textSettings;

		public string text;

		public int screenWidth;

		public int screenHeight;

		public bool wordWrapEnabled;

		public TextOverflow overflow;

		public LanguageDirection languageDirection;

		public int vertexPadding;

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal HorizontalAlignment horizontalAlignment;

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal VerticalAlignment verticalAlignment;

		public int fontSize;

		public bool bestFit;

		public int maxFontSize;

		public int minFontSize;

		public FontStyles fontStyle;

		public TextFontWeight fontWeight;

		public TextSpan[] textSpans;

		public Color32 color;

		public int characterSpacing;

		public int wordSpacing;

		public int paragraphSpacing;

		public PreProcessFlags preProcessFlags;

		public bool hasLink => false;

		public static NativeTextGenerationSettings Default => default(NativeTextGenerationSettings);

		public readonly TextSpan CreateTextSpan()
		{
			return default(TextSpan);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
