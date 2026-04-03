using System;
using System.Collections.Generic;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements
{
	internal class InlineStyleAccess : StyleValueCollection, IStyle
	{
		internal struct InlineRule
		{
			public StyleSheet sheet;

			public StyleRule rule;
		}

		private static StylePropertyReader s_StylePropertyReader;

		private List<StyleValueManaged> m_ValuesManaged;

		private bool m_HasInlineCursor;

		private StyleCursor m_InlineCursor;

		private bool m_HasInlineTextShadow;

		private StyleTextShadow m_InlineTextShadow;

		private bool m_HasInlineTextAutoSize;

		private StyleTextAutoSize m_InlineTextAutoSize;

		private bool m_HasInlineTransformOrigin;

		private StyleTransformOrigin m_InlineTransformOrigin;

		private bool m_HasInlineTranslate;

		private StyleTranslate m_InlineTranslateOperation;

		private bool m_HasInlineRotate;

		private StyleRotate m_InlineRotateOperation;

		private bool m_HasInlineScale;

		private StyleScale m_InlineScale;

		private bool m_HasInlineBackgroundSize;

		public StyleBackgroundSize m_InlineBackgroundSize;

		private bool m_HasInlineFilter;

		public StyleList<FilterFunction> m_InlineFilter;

		private InlineRule m_InlineRule;

		StyleEnum<Align> IStyle.alignContent
		{
			get
			{
				return default(StyleEnum<Align>);
			}
			set
			{
			}
		}

		StyleEnum<Align> IStyle.alignItems
		{
			get
			{
				return default(StyleEnum<Align>);
			}
			set
			{
			}
		}

		StyleEnum<Align> IStyle.alignSelf
		{
			get
			{
				return default(StyleEnum<Align>);
			}
			set
			{
			}
		}

		StyleRatio IStyle.aspectRatio
		{
			get
			{
				return default(StyleRatio);
			}
			set
			{
			}
		}

		StyleColor IStyle.backgroundColor
		{
			get
			{
				return default(StyleColor);
			}
			set
			{
			}
		}

		StyleBackground IStyle.backgroundImage
		{
			get
			{
				return default(StyleBackground);
			}
			set
			{
			}
		}

		StyleBackgroundPosition IStyle.backgroundPositionX
		{
			get
			{
				return default(StyleBackgroundPosition);
			}
			set
			{
			}
		}

		StyleBackgroundPosition IStyle.backgroundPositionY
		{
			get
			{
				return default(StyleBackgroundPosition);
			}
			set
			{
			}
		}

		StyleBackgroundRepeat IStyle.backgroundRepeat
		{
			get
			{
				return default(StyleBackgroundRepeat);
			}
			set
			{
			}
		}

		StyleColor IStyle.borderBottomColor
		{
			get
			{
				return default(StyleColor);
			}
			set
			{
			}
		}

		StyleLength IStyle.borderBottomLeftRadius
		{
			get
			{
				return default(StyleLength);
			}
			set
			{
			}
		}

		StyleLength IStyle.borderBottomRightRadius
		{
			get
			{
				return default(StyleLength);
			}
			set
			{
			}
		}

		StyleFloat IStyle.borderBottomWidth
		{
			get
			{
				return default(StyleFloat);
			}
			set
			{
			}
		}

		StyleColor IStyle.borderLeftColor
		{
			get
			{
				return default(StyleColor);
			}
			set
			{
			}
		}

		StyleFloat IStyle.borderLeftWidth
		{
			get
			{
				return default(StyleFloat);
			}
			set
			{
			}
		}

		StyleColor IStyle.borderRightColor
		{
			get
			{
				return default(StyleColor);
			}
			set
			{
			}
		}

		StyleFloat IStyle.borderRightWidth
		{
			get
			{
				return default(StyleFloat);
			}
			set
			{
			}
		}

		StyleColor IStyle.borderTopColor
		{
			get
			{
				return default(StyleColor);
			}
			set
			{
			}
		}

		StyleLength IStyle.borderTopLeftRadius
		{
			get
			{
				return default(StyleLength);
			}
			set
			{
			}
		}

		StyleLength IStyle.borderTopRightRadius
		{
			get
			{
				return default(StyleLength);
			}
			set
			{
			}
		}

		StyleFloat IStyle.borderTopWidth
		{
			get
			{
				return default(StyleFloat);
			}
			set
			{
			}
		}

		StyleLength IStyle.bottom
		{
			get
			{
				return default(StyleLength);
			}
			set
			{
			}
		}

		StyleColor IStyle.color
		{
			get
			{
				return default(StyleColor);
			}
			set
			{
			}
		}

		StyleEnum<DisplayStyle> IStyle.display
		{
			get
			{
				return default(StyleEnum<DisplayStyle>);
			}
			set
			{
			}
		}

		StyleLength IStyle.flexBasis
		{
			get
			{
				return default(StyleLength);
			}
			set
			{
			}
		}

		StyleEnum<FlexDirection> IStyle.flexDirection
		{
			get
			{
				return default(StyleEnum<FlexDirection>);
			}
			set
			{
			}
		}

		StyleFloat IStyle.flexGrow
		{
			get
			{
				return default(StyleFloat);
			}
			set
			{
			}
		}

		StyleFloat IStyle.flexShrink
		{
			get
			{
				return default(StyleFloat);
			}
			set
			{
			}
		}

		StyleEnum<Wrap> IStyle.flexWrap
		{
			get
			{
				return default(StyleEnum<Wrap>);
			}
			set
			{
			}
		}

		StyleLength IStyle.fontSize
		{
			get
			{
				return default(StyleLength);
			}
			set
			{
			}
		}

		StyleLength IStyle.height
		{
			get
			{
				return default(StyleLength);
			}
			set
			{
			}
		}

		StyleEnum<Justify> IStyle.justifyContent
		{
			get
			{
				return default(StyleEnum<Justify>);
			}
			set
			{
			}
		}

		StyleLength IStyle.left
		{
			get
			{
				return default(StyleLength);
			}
			set
			{
			}
		}

		StyleLength IStyle.letterSpacing
		{
			get
			{
				return default(StyleLength);
			}
			set
			{
			}
		}

		StyleLength IStyle.marginBottom
		{
			get
			{
				return default(StyleLength);
			}
			set
			{
			}
		}

		StyleLength IStyle.marginLeft
		{
			get
			{
				return default(StyleLength);
			}
			set
			{
			}
		}

		StyleLength IStyle.marginRight
		{
			get
			{
				return default(StyleLength);
			}
			set
			{
			}
		}

		StyleLength IStyle.marginTop
		{
			get
			{
				return default(StyleLength);
			}
			set
			{
			}
		}

		StyleLength IStyle.maxHeight
		{
			get
			{
				return default(StyleLength);
			}
			set
			{
			}
		}

		StyleLength IStyle.maxWidth
		{
			get
			{
				return default(StyleLength);
			}
			set
			{
			}
		}

		StyleLength IStyle.minHeight
		{
			get
			{
				return default(StyleLength);
			}
			set
			{
			}
		}

		StyleLength IStyle.minWidth
		{
			get
			{
				return default(StyleLength);
			}
			set
			{
			}
		}

		StyleFloat IStyle.opacity
		{
			get
			{
				return default(StyleFloat);
			}
			set
			{
			}
		}

		StyleEnum<Overflow> IStyle.overflow
		{
			get
			{
				return default(StyleEnum<Overflow>);
			}
			set
			{
			}
		}

		StyleLength IStyle.paddingBottom
		{
			get
			{
				return default(StyleLength);
			}
			set
			{
			}
		}

		StyleLength IStyle.paddingLeft
		{
			get
			{
				return default(StyleLength);
			}
			set
			{
			}
		}

		StyleLength IStyle.paddingRight
		{
			get
			{
				return default(StyleLength);
			}
			set
			{
			}
		}

		StyleLength IStyle.paddingTop
		{
			get
			{
				return default(StyleLength);
			}
			set
			{
			}
		}

		StyleEnum<Position> IStyle.position
		{
			get
			{
				return default(StyleEnum<Position>);
			}
			set
			{
			}
		}

		StyleLength IStyle.right
		{
			get
			{
				return default(StyleLength);
			}
			set
			{
			}
		}

		StyleEnum<TextOverflow> IStyle.textOverflow
		{
			get
			{
				return default(StyleEnum<TextOverflow>);
			}
			set
			{
			}
		}

		StyleLength IStyle.top
		{
			get
			{
				return default(StyleLength);
			}
			set
			{
			}
		}

		StyleList<TimeValue> IStyle.transitionDelay
		{
			get
			{
				return default(StyleList<TimeValue>);
			}
			set
			{
			}
		}

		StyleList<TimeValue> IStyle.transitionDuration
		{
			get
			{
				return default(StyleList<TimeValue>);
			}
			set
			{
			}
		}

		StyleList<StylePropertyName> IStyle.transitionProperty
		{
			get
			{
				return default(StyleList<StylePropertyName>);
			}
			set
			{
			}
		}

		StyleList<EasingFunction> IStyle.transitionTimingFunction
		{
			get
			{
				return default(StyleList<EasingFunction>);
			}
			set
			{
			}
		}

		StyleColor IStyle.unityBackgroundImageTintColor
		{
			get
			{
				return default(StyleColor);
			}
			set
			{
			}
		}

		StyleEnum<EditorTextRenderingMode> IStyle.unityEditorTextRenderingMode
		{
			get
			{
				return default(StyleEnum<EditorTextRenderingMode>);
			}
			set
			{
			}
		}

		StyleFont IStyle.unityFont
		{
			get
			{
				return default(StyleFont);
			}
			set
			{
			}
		}

		StyleFontDefinition IStyle.unityFontDefinition
		{
			get
			{
				return default(StyleFontDefinition);
			}
			set
			{
			}
		}

		StyleEnum<FontStyle> IStyle.unityFontStyleAndWeight
		{
			get
			{
				return default(StyleEnum<FontStyle>);
			}
			set
			{
			}
		}

		StyleMaterialDefinition IStyle.unityMaterial
		{
			get
			{
				return default(StyleMaterialDefinition);
			}
			set
			{
			}
		}

		StyleEnum<OverflowClipBox> IStyle.unityOverflowClipBox
		{
			get
			{
				return default(StyleEnum<OverflowClipBox>);
			}
			set
			{
			}
		}

		StyleLength IStyle.unityParagraphSpacing
		{
			get
			{
				return default(StyleLength);
			}
			set
			{
			}
		}

		StyleInt IStyle.unitySliceBottom
		{
			get
			{
				return default(StyleInt);
			}
			set
			{
			}
		}

		StyleInt IStyle.unitySliceLeft
		{
			get
			{
				return default(StyleInt);
			}
			set
			{
			}
		}

		StyleInt IStyle.unitySliceRight
		{
			get
			{
				return default(StyleInt);
			}
			set
			{
			}
		}

		StyleFloat IStyle.unitySliceScale
		{
			get
			{
				return default(StyleFloat);
			}
			set
			{
			}
		}

		StyleInt IStyle.unitySliceTop
		{
			get
			{
				return default(StyleInt);
			}
			set
			{
			}
		}

		StyleEnum<SliceType> IStyle.unitySliceType
		{
			get
			{
				return default(StyleEnum<SliceType>);
			}
			set
			{
			}
		}

		StyleEnum<TextAnchor> IStyle.unityTextAlign
		{
			get
			{
				return default(StyleEnum<TextAnchor>);
			}
			set
			{
			}
		}

		StyleEnum<TextGeneratorType> IStyle.unityTextGenerator
		{
			get
			{
				return default(StyleEnum<TextGeneratorType>);
			}
			set
			{
			}
		}

		StyleColor IStyle.unityTextOutlineColor
		{
			get
			{
				return default(StyleColor);
			}
			set
			{
			}
		}

		StyleFloat IStyle.unityTextOutlineWidth
		{
			get
			{
				return default(StyleFloat);
			}
			set
			{
			}
		}

		StyleEnum<TextOverflowPosition> IStyle.unityTextOverflowPosition
		{
			get
			{
				return default(StyleEnum<TextOverflowPosition>);
			}
			set
			{
			}
		}

		StyleEnum<Visibility> IStyle.visibility
		{
			get
			{
				return default(StyleEnum<Visibility>);
			}
			set
			{
			}
		}

		StyleEnum<WhiteSpace> IStyle.whiteSpace
		{
			get
			{
				return default(StyleEnum<WhiteSpace>);
			}
			set
			{
			}
		}

		StyleLength IStyle.width
		{
			get
			{
				return default(StyleLength);
			}
			set
			{
			}
		}

		StyleLength IStyle.wordSpacing
		{
			get
			{
				return default(StyleLength);
			}
			set
			{
			}
		}

		private VisualElement ve { get; set; }

		StyleCursor IStyle.cursor
		{
			get
			{
				return default(StyleCursor);
			}
			set
			{
			}
		}

		StyleTextShadow IStyle.textShadow
		{
			get
			{
				return default(StyleTextShadow);
			}
			set
			{
			}
		}

		StyleTextAutoSize IStyle.unityTextAutoSize
		{
			get
			{
				return default(StyleTextAutoSize);
			}
			set
			{
			}
		}

		StyleBackgroundSize IStyle.backgroundSize
		{
			get
			{
				return default(StyleBackgroundSize);
			}
			set
			{
			}
		}

		StyleList<FilterFunction> IStyle.filter
		{
			get
			{
				return default(StyleList<FilterFunction>);
			}
			set
			{
			}
		}

		StyleTransformOrigin IStyle.transformOrigin
		{
			get
			{
				return default(StyleTransformOrigin);
			}
			set
			{
			}
		}

		StyleTranslate IStyle.translate
		{
			get
			{
				return default(StyleTranslate);
			}
			set
			{
			}
		}

		StyleRotate IStyle.rotate
		{
			get
			{
				return default(StyleRotate);
			}
			set
			{
			}
		}

		StyleScale IStyle.scale
		{
			get
			{
				return default(StyleScale);
			}
			set
			{
			}
		}

		public InlineStyleAccess(VisualElement ve)
		{
		}

		~InlineStyleAccess()
		{
		}

		public void SetInlineRule(StyleSheet sheet, StyleRule rule)
		{
		}

		public bool IsValueSet(StylePropertyId id)
		{
			return false;
		}

		public void ApplyInlineStyles(ref ComputedStyle computedStyle)
		{
		}

		private StyleList<T> GetStyleList<T>(StylePropertyId id)
		{
			return default(StyleList<T>);
		}

		private void SetStyleValueManaged(StyleValueManaged value)
		{
		}

		private bool TryGetStyleValueManaged(StylePropertyId id, ref StyleValueManaged value)
		{
			return false;
		}

		private bool SetStyleValue(StylePropertyId id, StyleBackgroundPosition inlineValue)
		{
			return false;
		}

		private bool SetStyleValue(StylePropertyId id, StyleBackgroundRepeat inlineValue)
		{
			return false;
		}

		private bool SetStyleValue(StylePropertyId id, StyleLength inlineValue)
		{
			return false;
		}

		private bool SetStyleValue(StylePropertyId id, StyleFloat inlineValue)
		{
			return false;
		}

		private bool SetStyleValue(StylePropertyId id, StyleInt inlineValue)
		{
			return false;
		}

		private bool SetStyleValue(StylePropertyId id, StyleColor inlineValue)
		{
			return false;
		}

		private bool SetStyleValue<T>(StylePropertyId id, StyleEnum<T> inlineValue) where T : struct, IConvertible
		{
			return false;
		}

		private bool SetStyleValue(StylePropertyId id, StyleBackground inlineValue)
		{
			return false;
		}

		private bool SetStyleValue(StylePropertyId id, StyleFontDefinition inlineValue)
		{
			return false;
		}

		private bool SetStyleValue(StylePropertyId id, StyleFont inlineValue)
		{
			return false;
		}

		private bool SetStyleValue(StylePropertyId id, StyleMaterialDefinition inlineValue)
		{
			return false;
		}

		private bool SetStyleValue<T>(StylePropertyId id, StyleList<T> inlineValue)
		{
			return false;
		}

		private bool SetStyleValue(StylePropertyId id, StyleRatio inlineValue)
		{
			return false;
		}

		private bool SetInlineCursor(StyleCursor inlineValue)
		{
			return false;
		}

		private void ApplyStyleCursor(StyleCursor cursor)
		{
		}

		private bool SetInlineTextShadow(StyleTextShadow inlineValue)
		{
			return false;
		}

		private void ApplyStyleTextShadow(StyleTextShadow textShadow)
		{
		}

		private bool SetInlineTextAutoSize(StyleTextAutoSize inlineValue)
		{
			return false;
		}

		private void ApplyStyleTextAutoSize(StyleTextAutoSize textAutoSize)
		{
		}

		private bool SetInlineTransformOrigin(StyleTransformOrigin inlineValue)
		{
			return false;
		}

		private void ApplyStyleTransformOrigin(StyleTransformOrigin transformOrigin)
		{
		}

		private bool SetInlineTranslate(StyleTranslate inlineValue)
		{
			return false;
		}

		private void ApplyStyleTranslate(StyleTranslate translate)
		{
		}

		private bool SetInlineScale(StyleScale inlineValue)
		{
			return false;
		}

		private void ApplyStyleScale(StyleScale scale)
		{
		}

		private bool SetInlineRotate(StyleRotate inlineValue)
		{
			return false;
		}

		private void ApplyStyleRotate(StyleRotate rotate)
		{
		}

		private bool SetInlineBackgroundSize(StyleBackgroundSize inlineValue)
		{
			return false;
		}

		private void ApplyStyleBackgroundSize(StyleBackgroundSize backgroundSize)
		{
		}

		private bool SetInlineFilter(StyleList<FilterFunction> inlineValue)
		{
			return false;
		}

		private void ApplyStyleFilter(StyleList<FilterFunction> filter)
		{
		}

		private void ApplyStyleValue(StyleValue value)
		{
		}

		private void ApplyStyleValue(StyleValueManaged value)
		{
		}

		private bool RemoveInlineStyle(StylePropertyId id)
		{
			return false;
		}

		private void ApplyFromComputedStyle(StylePropertyId id, ref ComputedStyle newStyle)
		{
		}

		public bool TryGetInlineCursor(ref StyleCursor value)
		{
			return false;
		}

		public bool TryGetInlineTextShadow(ref StyleTextShadow value)
		{
			return false;
		}

		public bool TryGetInlineTextAutoSize(ref StyleTextAutoSize value)
		{
			return false;
		}

		public bool TryGetInlineTransformOrigin(ref StyleTransformOrigin value)
		{
			return false;
		}

		public bool TryGetInlineTranslate(ref StyleTranslate value)
		{
			return false;
		}

		public bool TryGetInlineRotate(ref StyleRotate value)
		{
			return false;
		}

		public bool TryGetInlineScale(ref StyleScale value)
		{
			return false;
		}

		public bool TryGetInlineBackgroundSize(ref StyleBackgroundSize value)
		{
			return false;
		}

		public bool TryGetInlineFilter(ref StyleList<FilterFunction> value)
		{
			return false;
		}
	}
}
