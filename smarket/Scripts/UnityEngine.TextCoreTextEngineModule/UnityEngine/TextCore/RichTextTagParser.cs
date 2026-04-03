using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine.Bindings;
using UnityEngine.TextCore.Text;

namespace UnityEngine.TextCore
{
	[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
	internal static class RichTextTagParser
	{
		public enum TagType
		{
			Hyperlink = 0,
			Align = 1,
			AllCaps = 2,
			Alpha = 3,
			Bold = 4,
			Br = 5,
			Color = 6,
			CSpace = 7,
			Font = 8,
			FontWeight = 9,
			Gradient = 10,
			Italic = 11,
			Indent = 12,
			LineHeight = 13,
			LineIndent = 14,
			Link = 15,
			Lowercase = 16,
			Margin = 17,
			MarginLeft = 18,
			MarginRight = 19,
			Mark = 20,
			Mspace = 21,
			NoBr = 22,
			NoParse = 23,
			Strikethrough = 24,
			Size = 25,
			SmallCaps = 26,
			Space = 27,
			Sprite = 28,
			Style = 29,
			Subscript = 30,
			Superscript = 31,
			Underline = 32,
			Uppercase = 33,
			Unknown = 34
		}

		public enum ValueID
		{
			Color = 0,
			Padding = 1,
			AssetID = 2,
			GlyphMetrics = 3,
			Scale = 4,
			Tint = 5,
			SpriteColor = 6,
			Gradient = 7
		}

		internal class TagTypeInfo : IEquatable<TagTypeInfo>
		{
			public TagType TagType;

			public string name;

			public TagValueType valueType;

			public TagUnitType unitType;

			[CompilerGenerated]
			protected virtual Type EqualityContract
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			internal TagTypeInfo(TagType tagType, string name, TagValueType valueType = TagValueType.None, TagUnitType unitType = TagUnitType.Unknown)
			{
			}

			[CompilerGenerated]
			public override string ToString()
			{
				return null;
			}

			[CompilerGenerated]
			protected virtual bool PrintMembers(StringBuilder builder)
			{
				return false;
			}

			[CompilerGenerated]
			public override int GetHashCode()
			{
				return 0;
			}

			[CompilerGenerated]
			public override bool Equals(object? obj)
			{
				return false;
			}

			[CompilerGenerated]
			public virtual bool Equals(TagTypeInfo? other)
			{
				return false;
			}
		}

		internal enum TagValueType
		{
			None = 0,
			NumericalValue = 1,
			StringValue = 2,
			ColorValue = 3,
			Vector4Value = 4,
			GlyphMetricsValue = 5,
			BoolValue = 6
		}

		internal enum TagUnitType
		{
			Unknown = 0,
			Pixels = 1,
			FontUnits = 2,
			Percentage = 3
		}

		internal class TagValue : IEquatable<TagValue>
		{
			internal TagValueType type;

			internal TagUnitType unit;

			private string? m_stringValue;

			private float m_numericalValue;

			private Color m_colorValue;

			private Vector4 m_vector4Value;

			private GlyphMetrics m_glyphMetricsValue;

			private bool m_boolValue;

			private ValueID? m_ID;

			[CompilerGenerated]
			protected virtual Type EqualityContract
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			internal string? StringValue => null;

			internal float NumericalValue => 0f;

			internal Color ColorValue => default(Color);

			internal Vector4 Vector4Value => default(Vector4);

			internal GlyphMetrics GlyphMetricsValue => default(GlyphMetrics);

			internal bool BoolValue => false;

			internal ValueID? ID => null;

			internal TagValue(float value, TagUnitType tagUnitType = TagUnitType.Unknown, ValueID? id = null)
			{
			}

			internal TagValue(Color value, ValueID? id = null)
			{
			}

			internal TagValue(string value, ValueID? id = null)
			{
			}

			internal TagValue(Vector4 value, ValueID? id = null)
			{
			}

			internal TagValue(GlyphMetrics value, ValueID? id = null)
			{
			}

			internal TagValue(bool value, ValueID? id = null)
			{
			}

			[CompilerGenerated]
			public override string ToString()
			{
				return null;
			}

			[CompilerGenerated]
			protected virtual bool PrintMembers(StringBuilder builder)
			{
				return false;
			}

			[CompilerGenerated]
			public static bool operator ==(TagValue? left, TagValue? right)
			{
				return false;
			}

			[CompilerGenerated]
			public override int GetHashCode()
			{
				return 0;
			}

			[CompilerGenerated]
			public override bool Equals(object? obj)
			{
				return false;
			}

			[CompilerGenerated]
			public virtual bool Equals(TagValue? other)
			{
				return false;
			}
		}

		internal struct Tag
		{
			public TagType tagType;

			public bool isClosing;

			public int start;

			public int end;

			public TagValue? value;

			public TagValue? value2;

			public TagValue? value3;

			public TagValue? value4;

			public TagValue? value5;
		}

		public struct Segment
		{
			public List<Tag>? tags;

			public int start;

			public int end;
		}

		internal class ParseError : IEquatable<ParseError>
		{
			public readonly int position;

			public readonly string message;

			[CompilerGenerated]
			protected virtual Type EqualityContract
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			internal ParseError(string message, int position)
			{
			}

			[CompilerGenerated]
			public override string ToString()
			{
				return null;
			}

			[CompilerGenerated]
			protected virtual bool PrintMembers(StringBuilder builder)
			{
				return false;
			}

			[CompilerGenerated]
			public override int GetHashCode()
			{
				return 0;
			}

			[CompilerGenerated]
			public override bool Equals(object? obj)
			{
				return false;
			}

			[CompilerGenerated]
			public virtual bool Equals(ParseError? other)
			{
				return false;
			}
		}

		internal static readonly Color32 k_HighlightColor;

		internal static readonly char k_PrivateArea;

		internal static Color s_AtgHyperlinkColor;

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal static readonly Dictionary<string, IntPtr> s_FontAssetCache;

		internal static readonly Dictionary<string, WeakReference<SpriteAsset>> s_SpriteAssetCache;

		internal static readonly Dictionary<string, IntPtr> s_GradientAssetCache;

		internal static readonly TagTypeInfo[] TagsInfo;

		private static bool tagMatch(ReadOnlySpan<char> tagCandidate, string tagName)
		{
			return false;
		}

		private static bool SpanToEnum(ReadOnlySpan<char> tagCandidate, out TagType tagType, out string? error, out ReadOnlySpan<char> attribute)
		{
			tagType = default(TagType);
			error = null;
			attribute = default(ReadOnlySpan<char>);
			return false;
		}

		private static TagValue ParseColorAttribute(ReadOnlySpan<char> attributeSection)
		{
			return null;
		}

		private static TagValue ParsePaddingAttribute(ReadOnlySpan<char> value)
		{
			return null;
		}

		private static TagValue ParseHref(ReadOnlySpan<char> attributeSection)
		{
			return null;
		}

		private static bool TryGetSimpleHref(ReadOnlySpan<char> attributeSection, out string hrefValue)
		{
			hrefValue = null;
			return false;
		}

		private static bool ParseSpriteAttributes(ReadOnlySpan<char> attributeSection, TextSettings textSettings, out char unicode, out TagValue? spriteAssetValue, out TagValue? glyphMetricsValue, out TagValue? tintValue, out TagValue? scaleValue, out TagValue? colorValue, out string? spriteAssetNameOut)
		{
			unicode = default(char);
			spriteAssetValue = null;
			glyphMetricsValue = null;
			tintValue = null;
			scaleValue = null;
			colorValue = null;
			spriteAssetNameOut = null;
			return false;
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal static void PreloadFontAssetsFromTags(string text, TextSettings textSettings)
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal static void PreloadSpriteAssetsFromTags(string text, TextSettings textSettings)
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal static void PreloadGradientAssetsFromTags(string text, TextSettings textSettings)
		{
		}

		internal static List<Tag> FindTags(ref string inputStr, TextSettings textSettings, bool preprocessingOnly = false, List<ParseError>? errors = null)
		{
			return null;
		}

		private static ReadOnlySpan<char> GetAttributeSpan(ReadOnlySpan<char> attributeSection)
		{
			return default(ReadOnlySpan<char>);
		}

		private static TagUnitType ParseTagUnitType(ref ReadOnlySpan<char> attributeSection)
		{
			return default(TagUnitType);
		}

		internal static List<Tag> PickResultingTags(List<Tag> allTags, string input, int atPosition, List<Tag>? applicableTags = null)
		{
			return null;
		}

		internal static Segment[] GenerateSegments(string input, List<Tag> tags)
		{
			return null;
		}

		internal static void ApplyStateToSegment(string input, List<Tag> tags, Segment[] segments)
		{
		}

		private static int AddLink(TagType type, string value, List<(int, TagType, string)> links)
		{
			return 0;
		}

		private static TextSpan CreateTextSpan(Segment segment, ref NativeTextGenerationSettings tgs, List<(int, TagType, string)> links, Color hyperlinkColor, float pixelsPerPoint)
		{
			return default(TextSpan);
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal static void CreateTextGenerationSettingsArray(ref NativeTextGenerationSettings tgs, List<(int, TagType, string)> links, Color hyperlinkColor, float pixelsPerPoint, TextSettings textSettings)
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal static bool MayNeedParsing(string text)
		{
			return false;
		}

		private static bool ContainsFontTag(string text)
		{
			return false;
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal static bool ContainsSpriteTag(string text)
		{
			return false;
		}

		internal static bool ContainsStyleTags(string text)
		{
			return false;
		}

		internal static bool ContainsGradientTag(string text)
		{
			return false;
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule", "UnityEngine.IMGUIModule" })]
		internal static bool HasFontTags(string text, TextSettings textSettings, out List<string> fontAssetNames)
		{
			fontAssetNames = null;
			return false;
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule", "UnityEngine.IMGUIModule" })]
		internal static bool HasSpriteTags(string text, TextSettings textSettings, out List<string> spriteAssetNames)
		{
			spriteAssetNames = null;
			return false;
		}

		internal static bool HasGradientTags(string text, TextSettings textSettings, out List<string> gradientAssetNames)
		{
			gradientAssetNames = null;
			return false;
		}
	}
}
