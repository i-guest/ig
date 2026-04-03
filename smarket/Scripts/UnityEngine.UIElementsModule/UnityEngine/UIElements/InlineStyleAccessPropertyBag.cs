using System;
using System.Collections.Generic;
using Unity.Properties;

namespace UnityEngine.UIElements
{
	internal class InlineStyleAccessPropertyBag : PropertyBag<InlineStyleAccess>, INamedProperties<InlineStyleAccess>
	{
		private class AlignContentProperty : InlineStyleEnumProperty<Align>
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleEnum<Align> GetValue(ref InlineStyleAccess container)
			{
				return default(StyleEnum<Align>);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleEnum<Align> value)
			{
			}
		}

		private class AlignItemsProperty : InlineStyleEnumProperty<Align>
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleEnum<Align> GetValue(ref InlineStyleAccess container)
			{
				return default(StyleEnum<Align>);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleEnum<Align> value)
			{
			}
		}

		private class AlignSelfProperty : InlineStyleEnumProperty<Align>
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleEnum<Align> GetValue(ref InlineStyleAccess container)
			{
				return default(StyleEnum<Align>);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleEnum<Align> value)
			{
			}
		}

		private class AspectRatioProperty : InlineStyleRatioProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleRatio GetValue(ref InlineStyleAccess container)
			{
				return default(StyleRatio);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleRatio value)
			{
			}
		}

		private class BackgroundColorProperty : InlineStyleColorProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleColor GetValue(ref InlineStyleAccess container)
			{
				return default(StyleColor);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleColor value)
			{
			}
		}

		private class BackgroundImageProperty : InlineStyleBackgroundProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleBackground GetValue(ref InlineStyleAccess container)
			{
				return default(StyleBackground);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleBackground value)
			{
			}
		}

		private class BackgroundPositionXProperty : InlineStyleBackgroundPositionProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleBackgroundPosition GetValue(ref InlineStyleAccess container)
			{
				return default(StyleBackgroundPosition);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleBackgroundPosition value)
			{
			}
		}

		private class BackgroundPositionYProperty : InlineStyleBackgroundPositionProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleBackgroundPosition GetValue(ref InlineStyleAccess container)
			{
				return default(StyleBackgroundPosition);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleBackgroundPosition value)
			{
			}
		}

		private class BackgroundRepeatProperty : InlineStyleBackgroundRepeatProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleBackgroundRepeat GetValue(ref InlineStyleAccess container)
			{
				return default(StyleBackgroundRepeat);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleBackgroundRepeat value)
			{
			}
		}

		private class BackgroundSizeProperty : InlineStyleBackgroundSizeProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleBackgroundSize GetValue(ref InlineStyleAccess container)
			{
				return default(StyleBackgroundSize);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleBackgroundSize value)
			{
			}
		}

		private class BorderBottomColorProperty : InlineStyleColorProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleColor GetValue(ref InlineStyleAccess container)
			{
				return default(StyleColor);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleColor value)
			{
			}
		}

		private class BorderBottomLeftRadiusProperty : InlineStyleLengthProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleLength GetValue(ref InlineStyleAccess container)
			{
				return default(StyleLength);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleLength value)
			{
			}
		}

		private class BorderBottomRightRadiusProperty : InlineStyleLengthProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleLength GetValue(ref InlineStyleAccess container)
			{
				return default(StyleLength);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleLength value)
			{
			}
		}

		private class BorderBottomWidthProperty : InlineStyleFloatProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleFloat GetValue(ref InlineStyleAccess container)
			{
				return default(StyleFloat);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleFloat value)
			{
			}
		}

		private class BorderLeftColorProperty : InlineStyleColorProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleColor GetValue(ref InlineStyleAccess container)
			{
				return default(StyleColor);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleColor value)
			{
			}
		}

		private class BorderLeftWidthProperty : InlineStyleFloatProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleFloat GetValue(ref InlineStyleAccess container)
			{
				return default(StyleFloat);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleFloat value)
			{
			}
		}

		private class BorderRightColorProperty : InlineStyleColorProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleColor GetValue(ref InlineStyleAccess container)
			{
				return default(StyleColor);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleColor value)
			{
			}
		}

		private class BorderRightWidthProperty : InlineStyleFloatProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleFloat GetValue(ref InlineStyleAccess container)
			{
				return default(StyleFloat);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleFloat value)
			{
			}
		}

		private class BorderTopColorProperty : InlineStyleColorProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleColor GetValue(ref InlineStyleAccess container)
			{
				return default(StyleColor);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleColor value)
			{
			}
		}

		private class BorderTopLeftRadiusProperty : InlineStyleLengthProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleLength GetValue(ref InlineStyleAccess container)
			{
				return default(StyleLength);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleLength value)
			{
			}
		}

		private class BorderTopRightRadiusProperty : InlineStyleLengthProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleLength GetValue(ref InlineStyleAccess container)
			{
				return default(StyleLength);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleLength value)
			{
			}
		}

		private class BorderTopWidthProperty : InlineStyleFloatProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleFloat GetValue(ref InlineStyleAccess container)
			{
				return default(StyleFloat);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleFloat value)
			{
			}
		}

		private class BottomProperty : InlineStyleLengthProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleLength GetValue(ref InlineStyleAccess container)
			{
				return default(StyleLength);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleLength value)
			{
			}
		}

		private class ColorProperty : InlineStyleColorProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleColor GetValue(ref InlineStyleAccess container)
			{
				return default(StyleColor);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleColor value)
			{
			}
		}

		private class CursorProperty : InlineStyleCursorProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleCursor GetValue(ref InlineStyleAccess container)
			{
				return default(StyleCursor);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleCursor value)
			{
			}
		}

		private class DisplayProperty : InlineStyleEnumProperty<DisplayStyle>
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleEnum<DisplayStyle> GetValue(ref InlineStyleAccess container)
			{
				return default(StyleEnum<DisplayStyle>);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleEnum<DisplayStyle> value)
			{
			}
		}

		private class FilterProperty : InlineStyleListProperty<FilterFunction>
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleList<FilterFunction> GetValue(ref InlineStyleAccess container)
			{
				return default(StyleList<FilterFunction>);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleList<FilterFunction> value)
			{
			}
		}

		private class FlexBasisProperty : InlineStyleLengthProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleLength GetValue(ref InlineStyleAccess container)
			{
				return default(StyleLength);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleLength value)
			{
			}
		}

		private class FlexDirectionProperty : InlineStyleEnumProperty<FlexDirection>
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleEnum<FlexDirection> GetValue(ref InlineStyleAccess container)
			{
				return default(StyleEnum<FlexDirection>);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleEnum<FlexDirection> value)
			{
			}
		}

		private class FlexGrowProperty : InlineStyleFloatProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleFloat GetValue(ref InlineStyleAccess container)
			{
				return default(StyleFloat);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleFloat value)
			{
			}
		}

		private class FlexShrinkProperty : InlineStyleFloatProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleFloat GetValue(ref InlineStyleAccess container)
			{
				return default(StyleFloat);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleFloat value)
			{
			}
		}

		private class FlexWrapProperty : InlineStyleEnumProperty<Wrap>
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleEnum<Wrap> GetValue(ref InlineStyleAccess container)
			{
				return default(StyleEnum<Wrap>);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleEnum<Wrap> value)
			{
			}
		}

		private class FontSizeProperty : InlineStyleLengthProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleLength GetValue(ref InlineStyleAccess container)
			{
				return default(StyleLength);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleLength value)
			{
			}
		}

		private class HeightProperty : InlineStyleLengthProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleLength GetValue(ref InlineStyleAccess container)
			{
				return default(StyleLength);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleLength value)
			{
			}
		}

		private class JustifyContentProperty : InlineStyleEnumProperty<Justify>
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleEnum<Justify> GetValue(ref InlineStyleAccess container)
			{
				return default(StyleEnum<Justify>);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleEnum<Justify> value)
			{
			}
		}

		private class LeftProperty : InlineStyleLengthProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleLength GetValue(ref InlineStyleAccess container)
			{
				return default(StyleLength);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleLength value)
			{
			}
		}

		private class LetterSpacingProperty : InlineStyleLengthProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleLength GetValue(ref InlineStyleAccess container)
			{
				return default(StyleLength);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleLength value)
			{
			}
		}

		private class MarginBottomProperty : InlineStyleLengthProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleLength GetValue(ref InlineStyleAccess container)
			{
				return default(StyleLength);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleLength value)
			{
			}
		}

		private class MarginLeftProperty : InlineStyleLengthProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleLength GetValue(ref InlineStyleAccess container)
			{
				return default(StyleLength);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleLength value)
			{
			}
		}

		private class MarginRightProperty : InlineStyleLengthProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleLength GetValue(ref InlineStyleAccess container)
			{
				return default(StyleLength);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleLength value)
			{
			}
		}

		private class MarginTopProperty : InlineStyleLengthProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleLength GetValue(ref InlineStyleAccess container)
			{
				return default(StyleLength);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleLength value)
			{
			}
		}

		private class MaxHeightProperty : InlineStyleLengthProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleLength GetValue(ref InlineStyleAccess container)
			{
				return default(StyleLength);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleLength value)
			{
			}
		}

		private class MaxWidthProperty : InlineStyleLengthProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleLength GetValue(ref InlineStyleAccess container)
			{
				return default(StyleLength);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleLength value)
			{
			}
		}

		private class MinHeightProperty : InlineStyleLengthProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleLength GetValue(ref InlineStyleAccess container)
			{
				return default(StyleLength);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleLength value)
			{
			}
		}

		private class MinWidthProperty : InlineStyleLengthProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleLength GetValue(ref InlineStyleAccess container)
			{
				return default(StyleLength);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleLength value)
			{
			}
		}

		private class OpacityProperty : InlineStyleFloatProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleFloat GetValue(ref InlineStyleAccess container)
			{
				return default(StyleFloat);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleFloat value)
			{
			}
		}

		private class OverflowProperty : InlineStyleEnumProperty<Overflow>
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleEnum<Overflow> GetValue(ref InlineStyleAccess container)
			{
				return default(StyleEnum<Overflow>);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleEnum<Overflow> value)
			{
			}
		}

		private class PaddingBottomProperty : InlineStyleLengthProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleLength GetValue(ref InlineStyleAccess container)
			{
				return default(StyleLength);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleLength value)
			{
			}
		}

		private class PaddingLeftProperty : InlineStyleLengthProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleLength GetValue(ref InlineStyleAccess container)
			{
				return default(StyleLength);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleLength value)
			{
			}
		}

		private class PaddingRightProperty : InlineStyleLengthProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleLength GetValue(ref InlineStyleAccess container)
			{
				return default(StyleLength);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleLength value)
			{
			}
		}

		private class PaddingTopProperty : InlineStyleLengthProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleLength GetValue(ref InlineStyleAccess container)
			{
				return default(StyleLength);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleLength value)
			{
			}
		}

		private class PositionProperty : InlineStyleEnumProperty<Position>
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleEnum<Position> GetValue(ref InlineStyleAccess container)
			{
				return default(StyleEnum<Position>);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleEnum<Position> value)
			{
			}
		}

		private class RightProperty : InlineStyleLengthProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleLength GetValue(ref InlineStyleAccess container)
			{
				return default(StyleLength);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleLength value)
			{
			}
		}

		private class RotateProperty : InlineStyleRotateProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleRotate GetValue(ref InlineStyleAccess container)
			{
				return default(StyleRotate);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleRotate value)
			{
			}
		}

		private class ScaleProperty : InlineStyleScaleProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleScale GetValue(ref InlineStyleAccess container)
			{
				return default(StyleScale);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleScale value)
			{
			}
		}

		private class TextOverflowProperty : InlineStyleEnumProperty<TextOverflow>
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleEnum<TextOverflow> GetValue(ref InlineStyleAccess container)
			{
				return default(StyleEnum<TextOverflow>);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleEnum<TextOverflow> value)
			{
			}
		}

		private class TextShadowProperty : InlineStyleTextShadowProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleTextShadow GetValue(ref InlineStyleAccess container)
			{
				return default(StyleTextShadow);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleTextShadow value)
			{
			}
		}

		private class TopProperty : InlineStyleLengthProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleLength GetValue(ref InlineStyleAccess container)
			{
				return default(StyleLength);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleLength value)
			{
			}
		}

		private class TransformOriginProperty : InlineStyleTransformOriginProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleTransformOrigin GetValue(ref InlineStyleAccess container)
			{
				return default(StyleTransformOrigin);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleTransformOrigin value)
			{
			}
		}

		private class TransitionDelayProperty : InlineStyleListProperty<TimeValue>
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleList<TimeValue> GetValue(ref InlineStyleAccess container)
			{
				return default(StyleList<TimeValue>);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleList<TimeValue> value)
			{
			}
		}

		private class TransitionDurationProperty : InlineStyleListProperty<TimeValue>
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleList<TimeValue> GetValue(ref InlineStyleAccess container)
			{
				return default(StyleList<TimeValue>);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleList<TimeValue> value)
			{
			}
		}

		private class TransitionPropertyProperty : InlineStyleListProperty<StylePropertyName>
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleList<StylePropertyName> GetValue(ref InlineStyleAccess container)
			{
				return default(StyleList<StylePropertyName>);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleList<StylePropertyName> value)
			{
			}
		}

		private class TransitionTimingFunctionProperty : InlineStyleListProperty<EasingFunction>
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleList<EasingFunction> GetValue(ref InlineStyleAccess container)
			{
				return default(StyleList<EasingFunction>);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleList<EasingFunction> value)
			{
			}
		}

		private class TranslateProperty : InlineStyleTranslateProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleTranslate GetValue(ref InlineStyleAccess container)
			{
				return default(StyleTranslate);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleTranslate value)
			{
			}
		}

		private class UnityBackgroundImageTintColorProperty : InlineStyleColorProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleColor GetValue(ref InlineStyleAccess container)
			{
				return default(StyleColor);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleColor value)
			{
			}
		}

		private class UnityEditorTextRenderingModeProperty : InlineStyleEnumProperty<EditorTextRenderingMode>
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleEnum<EditorTextRenderingMode> GetValue(ref InlineStyleAccess container)
			{
				return default(StyleEnum<EditorTextRenderingMode>);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleEnum<EditorTextRenderingMode> value)
			{
			}
		}

		private class UnityFontProperty : InlineStyleFontProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleFont GetValue(ref InlineStyleAccess container)
			{
				return default(StyleFont);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleFont value)
			{
			}
		}

		private class UnityFontDefinitionProperty : InlineStyleFontDefinitionProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleFontDefinition GetValue(ref InlineStyleAccess container)
			{
				return default(StyleFontDefinition);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleFontDefinition value)
			{
			}
		}

		private class UnityFontStyleAndWeightProperty : InlineStyleEnumProperty<FontStyle>
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleEnum<FontStyle> GetValue(ref InlineStyleAccess container)
			{
				return default(StyleEnum<FontStyle>);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleEnum<FontStyle> value)
			{
			}
		}

		private class UnityMaterialProperty : InlineStyleMaterialDefinitionProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleMaterialDefinition GetValue(ref InlineStyleAccess container)
			{
				return default(StyleMaterialDefinition);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleMaterialDefinition value)
			{
			}
		}

		private class UnityOverflowClipBoxProperty : InlineStyleEnumProperty<OverflowClipBox>
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleEnum<OverflowClipBox> GetValue(ref InlineStyleAccess container)
			{
				return default(StyleEnum<OverflowClipBox>);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleEnum<OverflowClipBox> value)
			{
			}
		}

		private class UnityParagraphSpacingProperty : InlineStyleLengthProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleLength GetValue(ref InlineStyleAccess container)
			{
				return default(StyleLength);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleLength value)
			{
			}
		}

		private class UnitySliceBottomProperty : InlineStyleIntProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleInt GetValue(ref InlineStyleAccess container)
			{
				return default(StyleInt);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleInt value)
			{
			}
		}

		private class UnitySliceLeftProperty : InlineStyleIntProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleInt GetValue(ref InlineStyleAccess container)
			{
				return default(StyleInt);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleInt value)
			{
			}
		}

		private class UnitySliceRightProperty : InlineStyleIntProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleInt GetValue(ref InlineStyleAccess container)
			{
				return default(StyleInt);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleInt value)
			{
			}
		}

		private class UnitySliceScaleProperty : InlineStyleFloatProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleFloat GetValue(ref InlineStyleAccess container)
			{
				return default(StyleFloat);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleFloat value)
			{
			}
		}

		private class UnitySliceTopProperty : InlineStyleIntProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleInt GetValue(ref InlineStyleAccess container)
			{
				return default(StyleInt);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleInt value)
			{
			}
		}

		private class UnitySliceTypeProperty : InlineStyleEnumProperty<SliceType>
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleEnum<SliceType> GetValue(ref InlineStyleAccess container)
			{
				return default(StyleEnum<SliceType>);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleEnum<SliceType> value)
			{
			}
		}

		private class UnityTextAlignProperty : InlineStyleEnumProperty<TextAnchor>
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleEnum<TextAnchor> GetValue(ref InlineStyleAccess container)
			{
				return default(StyleEnum<TextAnchor>);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleEnum<TextAnchor> value)
			{
			}
		}

		private class UnityTextAutoSizeProperty : InlineStyleTextAutoSizeProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleTextAutoSize GetValue(ref InlineStyleAccess container)
			{
				return default(StyleTextAutoSize);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleTextAutoSize value)
			{
			}
		}

		private class UnityTextGeneratorProperty : InlineStyleEnumProperty<TextGeneratorType>
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleEnum<TextGeneratorType> GetValue(ref InlineStyleAccess container)
			{
				return default(StyleEnum<TextGeneratorType>);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleEnum<TextGeneratorType> value)
			{
			}
		}

		private class UnityTextOutlineColorProperty : InlineStyleColorProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleColor GetValue(ref InlineStyleAccess container)
			{
				return default(StyleColor);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleColor value)
			{
			}
		}

		private class UnityTextOutlineWidthProperty : InlineStyleFloatProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleFloat GetValue(ref InlineStyleAccess container)
			{
				return default(StyleFloat);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleFloat value)
			{
			}
		}

		private class UnityTextOverflowPositionProperty : InlineStyleEnumProperty<TextOverflowPosition>
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleEnum<TextOverflowPosition> GetValue(ref InlineStyleAccess container)
			{
				return default(StyleEnum<TextOverflowPosition>);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleEnum<TextOverflowPosition> value)
			{
			}
		}

		private class VisibilityProperty : InlineStyleEnumProperty<Visibility>
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleEnum<Visibility> GetValue(ref InlineStyleAccess container)
			{
				return default(StyleEnum<Visibility>);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleEnum<Visibility> value)
			{
			}
		}

		private class WhiteSpaceProperty : InlineStyleEnumProperty<WhiteSpace>
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleEnum<WhiteSpace> GetValue(ref InlineStyleAccess container)
			{
				return default(StyleEnum<WhiteSpace>);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleEnum<WhiteSpace> value)
			{
			}
		}

		private class WidthProperty : InlineStyleLengthProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleLength GetValue(ref InlineStyleAccess container)
			{
				return default(StyleLength);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleLength value)
			{
			}
		}

		private class WordSpacingProperty : InlineStyleLengthProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleLength GetValue(ref InlineStyleAccess container)
			{
				return default(StyleLength);
			}

			public override void SetValue(ref InlineStyleAccess container, StyleLength value)
			{
			}
		}

		private abstract class InlineStyleProperty<TStyleValue, TValue> : Property<InlineStyleAccess, TStyleValue> where TStyleValue : IStyleValue<TValue>, new()
		{
			public abstract string ussName { get; }
		}

		private abstract class InlineStyleEnumProperty<TValue> : InlineStyleProperty<StyleEnum<TValue>, TValue> where TValue : struct, IConvertible
		{
		}

		private abstract class InlineStyleColorProperty : InlineStyleProperty<StyleColor, Color>
		{
		}

		private abstract class InlineStyleRatioProperty : InlineStyleProperty<StyleRatio, Ratio>
		{
		}

		private abstract class InlineStyleBackgroundProperty : InlineStyleProperty<StyleBackground, Background>
		{
		}

		private abstract class InlineStyleLengthProperty : InlineStyleProperty<StyleLength, Length>
		{
		}

		private abstract class InlineStyleFloatProperty : InlineStyleProperty<StyleFloat, float>
		{
		}

		private abstract class InlineStyleListProperty<T> : InlineStyleProperty<StyleList<T>, List<T>>
		{
		}

		private abstract class InlineStyleFontProperty : InlineStyleProperty<StyleFont, Font>
		{
		}

		private abstract class InlineStyleFontDefinitionProperty : InlineStyleProperty<StyleFontDefinition, FontDefinition>
		{
		}

		private abstract class InlineStyleIntProperty : InlineStyleProperty<StyleInt, int>
		{
		}

		private abstract class InlineStyleRotateProperty : InlineStyleProperty<StyleRotate, Rotate>
		{
		}

		private abstract class InlineStyleScaleProperty : InlineStyleProperty<StyleScale, Scale>
		{
		}

		private abstract class InlineStyleCursorProperty : InlineStyleProperty<StyleCursor, Cursor>
		{
		}

		private abstract class InlineStyleTextShadowProperty : InlineStyleProperty<StyleTextShadow, TextShadow>
		{
		}

		private abstract class InlineStyleTextAutoSizeProperty : InlineStyleProperty<StyleTextAutoSize, TextAutoSize>
		{
		}

		private abstract class InlineStyleTransformOriginProperty : InlineStyleProperty<StyleTransformOrigin, TransformOrigin>
		{
		}

		private abstract class InlineStyleTranslateProperty : InlineStyleProperty<StyleTranslate, Translate>
		{
		}

		private abstract class InlineStyleBackgroundPositionProperty : InlineStyleProperty<StyleBackgroundPosition, BackgroundPosition>
		{
		}

		private abstract class InlineStyleBackgroundRepeatProperty : InlineStyleProperty<StyleBackgroundRepeat, BackgroundRepeat>
		{
		}

		private abstract class InlineStyleBackgroundSizeProperty : InlineStyleProperty<StyleBackgroundSize, BackgroundSize>
		{
		}

		private abstract class InlineStyleMaterialDefinitionProperty : InlineStyleProperty<StyleMaterialDefinition, MaterialDefinition>
		{
		}

		private readonly List<IProperty<InlineStyleAccess>> m_PropertiesList;

		private readonly Dictionary<string, IProperty<InlineStyleAccess>> m_PropertiesHash;

		private void AddProperty<TStyleValue, TValue>(InlineStyleProperty<TStyleValue, TValue> property) where TStyleValue : IStyleValue<TValue>, new()
		{
		}

		public override PropertyCollection<InlineStyleAccess> GetProperties()
		{
			return default(PropertyCollection<InlineStyleAccess>);
		}

		public override PropertyCollection<InlineStyleAccess> GetProperties(ref InlineStyleAccess container)
		{
			return default(PropertyCollection<InlineStyleAccess>);
		}

		public bool TryGetProperty(ref InlineStyleAccess container, string name, out IProperty<InlineStyleAccess> property)
		{
			property = null;
			return false;
		}
	}
}
