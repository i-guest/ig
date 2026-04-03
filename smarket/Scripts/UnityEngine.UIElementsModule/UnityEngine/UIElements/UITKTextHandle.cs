using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.TextCore;
using UnityEngine.TextCore.Text;

namespace UnityEngine.UIElements
{
	internal class UITKTextHandle : TextHandle
	{
		internal ATGTextEventHandler m_ATGTextEventHandler;

		private List<(int, RichTextTagParser.TagType, string)> m_Links;

		internal Color atgHyperlinkColor;

		private bool uvsAreGenerated;

		private static TextLib s_TextLib;

		internal TextEventHandler m_TextEventHandler;

		protected TextElement m_TextElement;

		internal static readonly float k_MinPadding;

		private List<(int, RichTextTagParser.TagType, string)> Links => null;

		protected internal TextLib textLib
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return null;
			}
		}

		internal float LastPixelPerPoint { get; set; }

		internal float? MeasuredWidth { get; set; }

		internal float RoundedWidth { get; set; }

		internal float? ATGMeasuredWidth { get; set; }

		internal float ATGRoundedWidth { get; set; }

		public override bool IsPlaceholder => false;

		private void ComputeNativeTextSize(in string textToMeasure, float width, VisualElement.MeasureMode widthMode, float height, VisualElement.MeasureMode heightMode, float? fontsize = null)
		{
		}

		public (NativeTextInfo, bool) UpdateNative(bool generateNativeSettings = true)
		{
			return default((NativeTextInfo, bool));
		}

		public void CacheTextGenerationInfo()
		{
		}

		public void ShapeText()
		{
		}

		public void ProcessMeshInfos(NativeTextInfo textInfo, ref List<List<List<int>>> textElementIndicesByMesh, ref List<bool> hasMultipleColorsByMesh)
		{
		}

		public bool HasMissingGlyphs(NativeTextInfo textInfo, ref Dictionary<int, HashSet<uint>> missingGlyphsPerFontAsset)
		{
			return false;
		}

		private (bool, bool) hasLinkAndHyperlink()
		{
			return default((bool, bool));
		}

		internal (RichTextTagParser.TagType, string) ATGFindIntersectingLink(Vector2 point)
		{
			return default((RichTextTagParser.TagType, string));
		}

		internal void UpdateATGTextEventHandler()
		{
		}

		internal void EnsureIsReadyForJobs()
		{
		}

		internal bool ConvertUssToNativeTextGenerationSettings(string? textToMeasure = null, float? fontsize = null)
		{
			return false;
		}

		private TextAsset GetICUAsset()
		{
			return null;
		}

		internal static TextAsset GetICUAssetStaticFalback()
		{
			return null;
		}

		protected internal void InitTextLib()
		{
		}

		public UITKTextHandle(TextElement te)
		{
		}

		protected override float GetPixelsPerPoint()
		{
			return 0f;
		}

		public override void SetDirty()
		{
		}

		public Vector2 ComputeTextSize(string textToMeasure, float width, VisualElement.MeasureMode widthMode, float height, VisualElement.MeasureMode heightMode, float? fontsize = null)
		{
			return default(Vector2);
		}

		public Vector2 ComputeTextSize(in RenderedText textToMeasure, float width, float height, float? fontsize = null)
		{
			return default(Vector2);
		}

		public void ComputeSettingsAndUpdate()
		{
		}

		public void HandleATag()
		{
		}

		public void HandleLinkTag()
		{
		}

		public void HandleLinkAndATagCallbacks()
		{
		}

		public void UpdateMesh()
		{
		}

		public override void AddToPermanentCacheAndGenerateMesh()
		{
		}

		private TextOverflowMode GetTextOverflowMode()
		{
			return default(TextOverflowMode);
		}

		internal virtual bool ConvertUssToTextGenerationSettings(bool populateScreenRect, float? fontsize = null)
		{
			return false;
		}

		internal bool TextLibraryCanElide()
		{
			return false;
		}

		internal float GetVertexPadding(FontAsset fontAsset)
		{
			return 0f;
		}

		internal override bool IsAdvancedTextEnabledForElement()
		{
			return false;
		}

		internal void ReleaseResourcesIfPossible()
		{
		}

		public bool IsElided()
		{
			return false;
		}
	}
}
