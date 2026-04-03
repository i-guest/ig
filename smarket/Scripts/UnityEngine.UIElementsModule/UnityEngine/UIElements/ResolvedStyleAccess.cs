using System.Collections.Generic;

namespace UnityEngine.UIElements
{
	internal class ResolvedStyleAccess : IResolvedStyle
	{
		public Align alignContent => default(Align);

		public Align alignItems => default(Align);

		public Align alignSelf => default(Align);

		public Ratio aspectRatio => default(Ratio);

		public Color backgroundColor => default(Color);

		public Background backgroundImage => default(Background);

		public BackgroundPosition backgroundPositionX => default(BackgroundPosition);

		public BackgroundPosition backgroundPositionY => default(BackgroundPosition);

		public BackgroundRepeat backgroundRepeat => default(BackgroundRepeat);

		public BackgroundSize backgroundSize => default(BackgroundSize);

		public Color borderBottomColor => default(Color);

		public float borderBottomLeftRadius => 0f;

		public float borderBottomRightRadius => 0f;

		public float borderBottomWidth => 0f;

		public Color borderLeftColor => default(Color);

		public float borderLeftWidth => 0f;

		public Color borderRightColor => default(Color);

		public float borderRightWidth => 0f;

		public Color borderTopColor => default(Color);

		public float borderTopLeftRadius => 0f;

		public float borderTopRightRadius => 0f;

		public float borderTopWidth => 0f;

		public float bottom => 0f;

		public Color color => default(Color);

		public DisplayStyle display => default(DisplayStyle);

		public IEnumerable<FilterFunction> filter => null;

		public StyleFloat flexBasis => default(StyleFloat);

		public FlexDirection flexDirection => default(FlexDirection);

		public float flexGrow => 0f;

		public float flexShrink => 0f;

		public Wrap flexWrap => default(Wrap);

		public float fontSize => 0f;

		public float height => 0f;

		public Justify justifyContent => default(Justify);

		public float left => 0f;

		public float letterSpacing => 0f;

		public float marginBottom => 0f;

		public float marginLeft => 0f;

		public float marginRight => 0f;

		public float marginTop => 0f;

		public StyleFloat maxHeight => default(StyleFloat);

		public StyleFloat maxWidth => default(StyleFloat);

		public StyleFloat minHeight => default(StyleFloat);

		public StyleFloat minWidth => default(StyleFloat);

		public float opacity => 0f;

		public float paddingBottom => 0f;

		public float paddingLeft => 0f;

		public float paddingRight => 0f;

		public float paddingTop => 0f;

		public Position position => default(Position);

		public float right => 0f;

		public Rotate rotate => default(Rotate);

		public Scale scale => default(Scale);

		public TextOverflow textOverflow => default(TextOverflow);

		public float top => 0f;

		public Vector3 transformOrigin => default(Vector3);

		public IEnumerable<TimeValue> transitionDelay => null;

		public IEnumerable<TimeValue> transitionDuration => null;

		public IEnumerable<StylePropertyName> transitionProperty => null;

		public IEnumerable<EasingFunction> transitionTimingFunction => null;

		public Vector3 translate => default(Vector3);

		public Color unityBackgroundImageTintColor => default(Color);

		public EditorTextRenderingMode unityEditorTextRenderingMode => default(EditorTextRenderingMode);

		public Font unityFont => null;

		public FontDefinition unityFontDefinition => default(FontDefinition);

		public FontStyle unityFontStyleAndWeight => default(FontStyle);

		public MaterialDefinition unityMaterial => default(MaterialDefinition);

		public float unityParagraphSpacing => 0f;

		public int unitySliceBottom => 0;

		public int unitySliceLeft => 0;

		public int unitySliceRight => 0;

		public float unitySliceScale => 0f;

		public int unitySliceTop => 0;

		public SliceType unitySliceType => default(SliceType);

		public TextAnchor unityTextAlign => default(TextAnchor);

		public TextGeneratorType unityTextGenerator => default(TextGeneratorType);

		public Color unityTextOutlineColor => default(Color);

		public float unityTextOutlineWidth => 0f;

		public TextOverflowPosition unityTextOverflowPosition => default(TextOverflowPosition);

		public Visibility visibility => default(Visibility);

		public WhiteSpace whiteSpace => default(WhiteSpace);

		public float width => 0f;

		public float wordSpacing => 0f;

		private VisualElement ve { get; }

		public ResolvedStyleAccess(VisualElement ve)
		{
		}
	}
}
