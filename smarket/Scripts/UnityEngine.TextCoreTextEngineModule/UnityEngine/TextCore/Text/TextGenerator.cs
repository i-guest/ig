using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine.TextCore.Text
{
	[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
	internal class TextGenerator
	{
		public delegate void MissingCharacterEventCallback(uint unicode, int stringIndex, TextInfo text, FontAsset fontAsset);

		protected struct SpecialCharacter
		{
			public Character character;

			public FontAsset fontAsset;

			public Material material;

			public int materialIndex;

			public SpecialCharacter(Character character, int materialIndex)
			{
				this.character = null;
				fontAsset = null;
				material = null;
				this.materialIndex = 0;
			}
		}

		private const int k_Tab = 9;

		private const int k_LineFeed = 10;

		private const int k_VerticalTab = 11;

		private const int k_CarriageReturn = 13;

		private const int k_Space = 32;

		private const int k_DoubleQuotes = 34;

		private const int k_NumberSign = 35;

		private const int k_PercentSign = 37;

		private const int k_SingleQuote = 39;

		private const int k_Plus = 43;

		private const int k_Period = 46;

		private const int k_LesserThan = 60;

		private const int k_Equal = 61;

		private const int k_GreaterThan = 62;

		private const int k_Underline = 95;

		private const int k_NoBreakSpace = 160;

		private const int k_SoftHyphen = 173;

		private const int k_HyphenMinus = 45;

		private const int k_FigureSpace = 8199;

		private const int k_Hyphen = 8208;

		private const int k_NonBreakingHyphen = 8209;

		private const int k_ZeroWidthSpace = 8203;

		private const int k_NarrowNoBreakSpace = 8239;

		private const int k_WordJoiner = 8288;

		private const int k_HorizontalEllipsis = 8230;

		private const int k_LineSeparator = 8232;

		private const int k_ParagraphSeparator = 8233;

		private const int k_RightSingleQuote = 8217;

		private const int k_Square = 9633;

		private const int k_HangulJamoStart = 4352;

		private const int k_HangulJamoEnd = 4607;

		private const int k_CjkStart = 11904;

		private const int k_CjkEnd = 40959;

		private const int k_HangulJameExtendedStart = 43360;

		private const int k_HangulJameExtendedEnd = 43391;

		private const int k_HangulSyllablesStart = 44032;

		private const int k_HangulSyllablesEnd = 55295;

		private const int k_CjkIdeographsStart = 63744;

		private const int k_CjkIdeographsEnd = 64255;

		private const int k_CjkFormsStart = 65072;

		private const int k_CjkFormsEnd = 65103;

		private const int k_CjkHalfwidthStart = 65280;

		private const int k_CjkHalfwidthEnd = 65519;

		private const int k_EndOfText = 3;

		private const float k_FloatUnset = -32767f;

		private const int k_MaxCharacters = 8;

		private static TextGenerator s_TextGenerator;

		private TextBackingContainer m_TextBackingArray;

		internal TextProcessingElement[] m_TextProcessingArray;

		internal int m_InternalTextProcessingArraySize;

		[SerializeField]
		protected bool m_VertexBufferAutoSizeReduction;

		private char[] m_HtmlTag;

		internal HighlightState m_HighlightState;

		protected bool m_IsIgnoringAlignment;

		protected bool m_IsTextTruncated;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static MissingCharacterEventCallback OnMissingCharacter;

		private Vector3[] m_RectTransformCorners;

		private float m_MarginWidth;

		private float m_MarginHeight;

		private float m_PreferredWidth;

		private float m_PreferredHeight;

		private FontAsset m_CurrentFontAsset;

		private Material m_CurrentMaterial;

		private int m_CurrentMaterialIndex;

		private TextProcessingStack<MaterialReference> m_MaterialReferenceStack;

		private float m_Padding;

		private SpriteAsset m_CurrentSpriteAsset;

		private int m_TotalCharacterCount;

		private float m_FontSize;

		private float m_FontScaleMultiplier;

		private bool m_ShouldRenderBitmap;

		private float m_CurrentFontSize;

		private TextProcessingStack<float> m_SizeStack;

		protected TextProcessingStack<int>[] m_TextStyleStacks;

		protected int m_TextStyleStackDepth;

		private FontStyles m_FontStyleInternal;

		private FontStyleStack m_FontStyleStack;

		private TextFontWeight m_FontWeightInternal;

		private TextProcessingStack<TextFontWeight> m_FontWeightStack;

		private TextAlignment m_LineJustification;

		private TextProcessingStack<TextAlignment> m_LineJustificationStack;

		private float _m_BaselineOffset;

		private TextProcessingStack<float> m_BaselineOffsetStack;

		private Color32 m_FontColor32;

		private Color32 m_HtmlColor;

		private Color32 m_UnderlineColor;

		private Color32 m_StrikethroughColor;

		private TextProcessingStack<Color32> m_ColorStack;

		private TextProcessingStack<Color32> m_UnderlineColorStack;

		private TextProcessingStack<Color32> m_StrikethroughColorStack;

		private TextProcessingStack<Color32> m_HighlightColorStack;

		private TextProcessingStack<HighlightState> m_HighlightStateStack;

		private TextProcessingStack<int> m_ItalicAngleStack;

		private TextColorGradient m_ColorGradientPreset;

		private TextProcessingStack<TextColorGradient> m_ColorGradientStack;

		private bool m_ColorGradientPresetIsTinted;

		private TextProcessingStack<int> m_ActionStack;

		private float _m_LineOffset;

		private float _m_LineHeight;

		private bool m_IsDrivenLineSpacing;

		private float m_CSpacing;

		private float m_MonoSpacing;

		private bool m_DuoSpace;

		private float _m_XAdvance;

		private float m_TagLineIndent;

		private float m_TagIndent;

		private TextProcessingStack<float> m_IndentStack;

		private bool m_TagNoParsing;

		private int m_CharacterCount;

		private int m_FirstCharacterOfLine;

		private int m_LastCharacterOfLine;

		private int m_FirstVisibleCharacterOfLine;

		private int m_LastVisibleCharacterOfLine;

		private float m_MaxLineAscender;

		private float m_MaxLineDescender;

		private int m_LineNumber;

		private int m_LineVisibleCharacterCount;

		private int m_LineVisibleSpaceCount;

		private int m_FirstOverflowCharacterIndex;

		private float m_MarginLeft;

		private float m_MarginRight;

		private float m_Width;

		private Extents m_MeshExtents;

		private float m_MaxCapHeight;

		private float m_MaxAscender;

		private float m_MaxDescender;

		private bool m_IsNonBreakingSpace;

		private WordWrapState m_SavedWordWrapState;

		private WordWrapState m_SavedLineState;

		private WordWrapState m_SavedEllipsisState;

		private WordWrapState m_SavedLastValidState;

		private WordWrapState m_SavedSoftLineBreakState;

		private TextElementType m_TextElementType;

		private bool m_isTextLayoutPhase;

		private int m_SpriteIndex;

		private Color32 m_SpriteColor;

		private TextElement m_CachedTextElement;

		private Color32 m_HighlightColor;

		private float m_CharWidthAdjDelta;

		private float m_MaxFontSize;

		private float m_MinFontSize;

		private int m_AutoSizeIterationCount;

		private int m_AutoSizeMaxIterationCount;

		private float m_StartOfLineAscender;

		private float m_LineSpacingDelta;

		internal MaterialReference[] m_MaterialReferences;

		private int m_SpriteCount;

		private TextProcessingStack<int> m_StyleStack;

		private TextProcessingStack<WordWrapState> m_EllipsisInsertionCandidateStack;

		private int m_SpriteAnimationId;

		private int m_ItalicAngle;

		private Vector3 m_FXScale;

		private Quaternion m_FXRotation;

		private int m_LastBaseGlyphIndex;

		private float m_PageAscender;

		private RichTextTagAttribute[] m_XmlAttribute;

		private float[] m_AttributeParameterValues;

		private Dictionary<int, int> m_MaterialReferenceIndexLookup;

		private bool m_IsCalculatingPreferredValues;

		private bool m_TintSprite;

		protected SpecialCharacter m_Ellipsis;

		protected SpecialCharacter m_Underline;

		private TextElementInfo[] m_InternalTextElementInfo;

		internal static readonly bool EnableTextAlignmentAssertions;

		internal static readonly bool EnableCheckerboardPattern;

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal static bool IsExecutingJob { get; set; }

		public bool isTextTruncated => false;

		private float m_BaselineOffset
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		private float m_LineOffset
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		private float m_LineHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		private float m_XAdvance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		private bool NeedToRound => false;

		public void GenerateText(TextGenerationSettings settings, TextInfo textInfo)
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal void GenerateTextMesh(TextGenerationSettings generationSettings, TextInfo textInfo)
		{
		}

		private bool ValidateHtmlTag(TextProcessingElement[] chars, int startIndex, out int endIndex, TextGenerationSettings generationSettings, TextInfo textInfo, out bool isThreadSuccess)
		{
			endIndex = default(int);
			isThreadSuccess = default(bool);
			return false;
		}

		internal void CloseLastLinkTag(TextInfo textInfo)
		{
		}

		internal void CloseAllLinkTags(TextInfo textInfo)
		{
		}

		private void CloseLinkTag(TextInfo textInfo, int index)
		{
		}

		private void ClearMarkupTagAttributes()
		{
		}

		private void SaveWordWrappingState(ref WordWrapState state, int index, int count, TextInfo textInfo)
		{
		}

		private int RestoreWordWrappingState(ref WordWrapState state, TextInfo textInfo)
		{
			return 0;
		}

		private void SaveGlyphVertexInfo(float padding, float stylePadding, Color32 vertexColor, TextGenerationSettings generationSettings, TextInfo textInfo)
		{
		}

		private void SaveSpriteVertexInfo(Color32 vertexColor, TextGenerationSettings generationSettings, TextInfo textInfo)
		{
		}

		private void DrawUnderlineMesh(Vector3 start, Vector3 end, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor, TextGenerationSettings generationSettings, TextInfo textInfo)
		{
		}

		private void DrawTextHighlight(Vector3 start, Vector3 end, Color32 highlightColor, TextGenerationSettings generationSettings, TextInfo textInfo)
		{
		}

		private static void ClearMesh(bool updateMesh, TextInfo textInfo)
		{
		}

		public void LayoutPhase(TextInfo textInfo, TextGenerationSettings generationSettings, float maxVisibleDescender)
		{
		}

		private float Round(float v)
		{
			return 0f;
		}

		public void ParsingPhase(TextInfo textInfo, TextGenerationSettings generationSettings, out uint charCode, out float maxVisibleDescender)
		{
			charCode = default(uint);
			maxVisibleDescender = default(float);
		}

		private void InsertNewLine(int i, float baseScale, float currentElementScale, float currentEmScale, float boldSpacingAdjustment, float characterSpacingAdjustment, float width, float lineGap, ref bool isMaxVisibleDescenderSet, ref float maxVisibleDescender, TextGenerationSettings generationSettings, TextInfo textInfo)
		{
		}

		public Vector2 GetPreferredValues(TextGenerationSettings settings, TextInfo textInfo)
		{
			return default(Vector2);
		}

		private Vector2 GetPreferredValuesInternal(TextGenerationSettings generationSettings, TextInfo textInfo)
		{
			return default(Vector2);
		}

		protected virtual Vector2 CalculatePreferredValues(ref float fontSize, Vector2 marginSize, bool isTextAutoSizingEnabled, TextGenerationSettings generationSettings, TextInfo textInfo)
		{
			return default(Vector2);
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal void Prepare(TextGenerationSettings generationSettings, TextInfo textInfo)
		{
		}

		internal bool PrepareFontAsset(TextGenerationSettings generationSettings)
		{
			return false;
		}

		private int SetArraySizes(TextProcessingElement[] textProcessingArray, TextGenerationSettings generationSettings, TextInfo textInfo)
		{
			return 0;
		}

		private TextElement GetTextElement(TextGenerationSettings generationSettings, uint unicode, FontAsset fontAsset, FontStyles fontStyle, TextFontWeight fontWeight, out bool isUsingAlternativeTypeface, bool populateLigatures)
		{
			isUsingAlternativeTypeface = default(bool);
			return null;
		}

		private void PopulateTextBackingArray(in RenderedText sourceText)
		{
		}

		private void PopulateTextProcessingArray(TextGenerationSettings generationSettings)
		{
		}

		private bool PopulateFontAsset(TextGenerationSettings generationSettings, TextProcessingElement[] textProcessingArray)
		{
			return false;
		}

		private void ComputeMarginSize(Rect rect, Vector4 margins)
		{
		}

		protected bool GetSpecialCharacters(TextGenerationSettings generationSettings)
		{
			return false;
		}

		protected bool GetEllipsisSpecialCharacter(TextGenerationSettings generationSettings)
		{
			return false;
		}

		protected bool GetUnderlineSpecialCharacter(TextGenerationSettings generationSettings)
		{
			return false;
		}

		protected void DoMissingGlyphCallback(uint unicode, int stringIndex, FontAsset fontAsset, TextInfo textInfo)
		{
		}
	}
}
