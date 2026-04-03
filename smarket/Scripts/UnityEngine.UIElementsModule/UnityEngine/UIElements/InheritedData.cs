using System;

namespace UnityEngine.UIElements
{
	internal struct InheritedData : IStyleDataGroup<InheritedData>, IEquatable<InheritedData>
	{
		public Color color;

		public Length fontSize;

		public Length letterSpacing;

		public TextShadow textShadow;

		public EditorTextRenderingMode unityEditorTextRenderingMode;

		public Font unityFont;

		public FontDefinition unityFontDefinition;

		public FontStyle unityFontStyleAndWeight;

		public MaterialDefinition unityMaterial;

		public Length unityParagraphSpacing;

		public TextAnchor unityTextAlign;

		public TextAutoSize unityTextAutoSize;

		public TextGeneratorType unityTextGenerator;

		public Color unityTextOutlineColor;

		public float unityTextOutlineWidth;

		public Visibility visibility;

		public WhiteSpace whiteSpace;

		public Length wordSpacing;

		public InheritedData Copy()
		{
			return default(InheritedData);
		}

		public void CopyFrom(ref InheritedData other)
		{
		}

		public static bool operator ==(InheritedData lhs, InheritedData rhs)
		{
			return false;
		}

		public bool Equals(InheritedData other)
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
	}
}
