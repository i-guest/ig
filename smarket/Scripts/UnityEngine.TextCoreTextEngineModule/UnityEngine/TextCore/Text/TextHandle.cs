using System;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine.Bindings;

namespace UnityEngine.TextCore.Text
{
	[DebuggerDisplay("{settings.text}")]
	[VisibleToOtherModules(new string[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule", "UnityEditor.QuickSearchModule" })]
	internal class TextHandle
	{
		[Flags]
		private protected enum TextHandleFlags
		{
			IsCachedPermanentTextCore = 2,
			IsCachedPermanentATG = 4
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal static TextHandleTemporaryCache s_TemporaryCache;

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal static TextHandlePermanentCache s_PermanentCache;

		private static TextGenerationSettings[] s_Settings;

		private static TextGenerator[] s_Generators;

		private static TextInfo[] s_TextInfosCommon;

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal NativeTextGenerationSettings nativeSettings;

		protected Vector2 pixelPreferedSize;

		private Rect m_ScreenRect;

		private float m_LineHeightDefault;

		private bool m_IsPlaceholder;

		protected bool m_IsElided;

		private int m_CreateGenerationIteration;

		private IntPtr m_TextGenerationInfo;

		private protected TextHandleFlags m_TextHandleFlags;

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal int m_PreviousGenerationSettingsHash;

		protected bool isDirty;

		internal static TextGenerationSettings[] settingsArray => null;

		internal static TextGenerator[] generators => null;

		internal static TextInfo[] textInfosCommon => null;

		internal static TextInfo textInfoCommon => null;

		private static TextGenerator generator => null;

		internal static TextGenerationSettings settings
		{
			[VisibleToOtherModules(new string[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
			get
			{
				return null;
			}
		}

		internal Vector2 preferredSize
		{
			[VisibleToOtherModules(new string[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
			get
			{
				return default(Vector2);
			}
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
		internal IntPtr textGenerationInfo
		{
			get
			{
				return (IntPtr)0;
			}
			set
			{
			}
		}

		internal LinkedListNode<TextCacheEntry> TextInfoNode { get; set; }

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		protected internal bool IsCachedPermanent => false;

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal bool IsCachedPermanentATG
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal bool IsCachedPermanentTextCore
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal bool IsCachedTemporary { get; set; }

		internal bool useAdvancedText
		{
			[VisibleToOtherModules(new string[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
			get
			{
				return false;
			}
		}

		internal int characterCount
		{
			[VisibleToOtherModules(new string[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
			get
			{
				return 0;
			}
		}

		internal TextInfo textInfo
		{
			[VisibleToOtherModules(new string[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
			get
			{
				return null;
			}
		}

		public virtual bool IsPlaceholder => false;

		~TextHandle()
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
		internal static void InitThreadArrays()
		{
		}

		private static void InitArray<T>(ref T[] array, Func<T> createInstance)
		{
		}

		protected float PixelsToPoints(float pixel)
		{
			return 0f;
		}

		protected Vector2 PointsToPixels(Vector2 point)
		{
			return default(Vector2);
		}

		protected Vector2 PixelsToPoints(Vector2 pixel)
		{
			return default(Vector2);
		}

		protected virtual float GetPixelsPerPoint()
		{
			return 0f;
		}

		public virtual void AddToPermanentCacheAndGenerateMesh()
		{
		}

		public void AddTextInfoToTemporaryCache(int hashCode)
		{
		}

		public void RemoveFromTemporaryCache()
		{
		}

		public void RemoveFromPermanentCache()
		{
		}

		public void RemoveFromPermanentCacheTextCore()
		{
		}

		public void RemoveFromPermanentCacheATG()
		{
		}

		public static void UpdateCurrentFrame()
		{
		}

		public virtual void SetDirty()
		{
		}

		public bool IsDirty(int hashCode)
		{
			return false;
		}

		protected void UpdatePreferredValues(TextGenerationSettings tgs)
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
		internal TextInfo Update()
		{
			return null;
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
		internal TextInfo UpdateWithHash(int hashCode)
		{
			return null;
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
		internal bool PrepareFontAsset()
		{
			return false;
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.IMGUIModule" })]
		internal void UpdatePreferredSize()
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal static float ConvertPixelUnitsToTextCoreRelativeUnits(float fontSize, FontAsset fontAsset)
		{
			return 0f;
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.IMGUIModule" })]
		internal static float GetLineHeightDefault(TextGenerationSettings settings)
		{
			return 0f;
		}

		public virtual Vector2 GetCursorPositionFromStringIndexUsingCharacterHeight(int index, bool inverseYAxis = true)
		{
			return default(Vector2);
		}

		public Vector2 GetCursorPositionFromStringIndexUsingLineHeight(int index, bool useXAdvance = false, bool inverseYAxis = true)
		{
			return default(Vector2);
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
		internal Rect[] GetHighlightRectangles(int cursorIndex, int selectIndex)
		{
			return null;
		}

		public int GetCursorIndexFromPosition(Vector2 position, bool inverseYAxis = true)
		{
			return 0;
		}

		public int LineDownCharacterPosition(int originalLogicalPos)
		{
			return 0;
		}

		public int LineUpCharacterPosition(int originalLogicalPos)
		{
			return 0;
		}

		public int FindIntersectingLink(Vector3 position, bool inverseYAxis = true)
		{
			return 0;
		}

		public int GetCorrespondingStringIndex(int index)
		{
			return 0;
		}

		public LineInfo GetLineInfoFromCharacterIndex(int index)
		{
			return default(LineInfo);
		}

		public int GetLineNumber(int index)
		{
			return 0;
		}

		public float GetLineHeight(int lineNumber)
		{
			return 0f;
		}

		public float GetLineHeightFromCharacterIndex(int index)
		{
			return 0f;
		}

		public float GetCharacterHeightFromIndex(int index)
		{
			return 0f;
		}

		public string Substring(int startIndex, int length)
		{
			return null;
		}

		public int PreviousCodePointIndex(int currentIndex)
		{
			return 0;
		}

		public int NextCodePointIndex(int currentIndex)
		{
			return 0;
		}

		public int GetStartOfNextWord(int currentIndex)
		{
			return 0;
		}

		public int GetEndOfPreviousWord(int currentIndex)
		{
			return 0;
		}

		public int GetFirstCharacterIndexOnLine(int currentIndex)
		{
			return 0;
		}

		public int GetLastCharacterIndexOnLine(int currentIndex)
		{
			return 0;
		}

		public int IndexOf(char value, int startIndex)
		{
			return 0;
		}

		public int LastIndexOf(char value, int startIndex)
		{
			return 0;
		}

		public void SelectCurrentWord(int index, ref int cursorIndex, ref int selectIndex)
		{
		}

		public void SelectCurrentParagraph(ref int cursorIndex, ref int selectIndex)
		{
		}

		public void SelectToPreviousParagraph(ref int cursorIndex)
		{
		}

		public void SelectToNextParagraph(ref int cursorIndex)
		{
		}

		public void SelectToStartOfParagraph(ref int cursorIndex)
		{
		}

		public void SelectToEndOfParagraph(ref int cursorIndex)
		{
		}

		internal virtual bool IsAdvancedTextEnabledForElement()
		{
			return false;
		}
	}
}
