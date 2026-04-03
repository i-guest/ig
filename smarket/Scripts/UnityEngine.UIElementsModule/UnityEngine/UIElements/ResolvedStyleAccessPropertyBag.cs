using System;
using System.Collections.Generic;
using Unity.Properties;

namespace UnityEngine.UIElements
{
	internal class ResolvedStyleAccessPropertyBag : PropertyBag<ResolvedStyleAccess>, INamedProperties<ResolvedStyleAccess>
	{
		private class AlignContentProperty : ResolvedEnumProperty<Align>
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override Align GetValue(ref ResolvedStyleAccess container)
			{
				return default(Align);
			}

			public override void SetValue(ref ResolvedStyleAccess container, Align value)
			{
			}
		}

		private class AlignItemsProperty : ResolvedEnumProperty<Align>
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override Align GetValue(ref ResolvedStyleAccess container)
			{
				return default(Align);
			}

			public override void SetValue(ref ResolvedStyleAccess container, Align value)
			{
			}
		}

		private class AlignSelfProperty : ResolvedEnumProperty<Align>
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override Align GetValue(ref ResolvedStyleAccess container)
			{
				return default(Align);
			}

			public override void SetValue(ref ResolvedStyleAccess container, Align value)
			{
			}
		}

		private class AspectRatioProperty : ResolvedRatioProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override Ratio GetValue(ref ResolvedStyleAccess container)
			{
				return default(Ratio);
			}

			public override void SetValue(ref ResolvedStyleAccess container, Ratio value)
			{
			}
		}

		private class BackgroundColorProperty : ResolvedColorProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override Color GetValue(ref ResolvedStyleAccess container)
			{
				return default(Color);
			}

			public override void SetValue(ref ResolvedStyleAccess container, Color value)
			{
			}
		}

		private class BackgroundImageProperty : ResolvedBackgroundProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override Background GetValue(ref ResolvedStyleAccess container)
			{
				return default(Background);
			}

			public override void SetValue(ref ResolvedStyleAccess container, Background value)
			{
			}
		}

		private class BackgroundPositionXProperty : ResolvedBackgroundPositionProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override BackgroundPosition GetValue(ref ResolvedStyleAccess container)
			{
				return default(BackgroundPosition);
			}

			public override void SetValue(ref ResolvedStyleAccess container, BackgroundPosition value)
			{
			}
		}

		private class BackgroundPositionYProperty : ResolvedBackgroundPositionProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override BackgroundPosition GetValue(ref ResolvedStyleAccess container)
			{
				return default(BackgroundPosition);
			}

			public override void SetValue(ref ResolvedStyleAccess container, BackgroundPosition value)
			{
			}
		}

		private class BackgroundRepeatProperty : ResolvedBackgroundRepeatProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override BackgroundRepeat GetValue(ref ResolvedStyleAccess container)
			{
				return default(BackgroundRepeat);
			}

			public override void SetValue(ref ResolvedStyleAccess container, BackgroundRepeat value)
			{
			}
		}

		private class BackgroundSizeProperty : ResolvedBackgroundSizeProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override BackgroundSize GetValue(ref ResolvedStyleAccess container)
			{
				return default(BackgroundSize);
			}

			public override void SetValue(ref ResolvedStyleAccess container, BackgroundSize value)
			{
			}
		}

		private class BorderBottomColorProperty : ResolvedColorProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override Color GetValue(ref ResolvedStyleAccess container)
			{
				return default(Color);
			}

			public override void SetValue(ref ResolvedStyleAccess container, Color value)
			{
			}
		}

		private class BorderBottomLeftRadiusProperty : ResolvedFloatProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override float GetValue(ref ResolvedStyleAccess container)
			{
				return 0f;
			}

			public override void SetValue(ref ResolvedStyleAccess container, float value)
			{
			}
		}

		private class BorderBottomRightRadiusProperty : ResolvedFloatProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override float GetValue(ref ResolvedStyleAccess container)
			{
				return 0f;
			}

			public override void SetValue(ref ResolvedStyleAccess container, float value)
			{
			}
		}

		private class BorderBottomWidthProperty : ResolvedFloatProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override float GetValue(ref ResolvedStyleAccess container)
			{
				return 0f;
			}

			public override void SetValue(ref ResolvedStyleAccess container, float value)
			{
			}
		}

		private class BorderLeftColorProperty : ResolvedColorProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override Color GetValue(ref ResolvedStyleAccess container)
			{
				return default(Color);
			}

			public override void SetValue(ref ResolvedStyleAccess container, Color value)
			{
			}
		}

		private class BorderLeftWidthProperty : ResolvedFloatProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override float GetValue(ref ResolvedStyleAccess container)
			{
				return 0f;
			}

			public override void SetValue(ref ResolvedStyleAccess container, float value)
			{
			}
		}

		private class BorderRightColorProperty : ResolvedColorProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override Color GetValue(ref ResolvedStyleAccess container)
			{
				return default(Color);
			}

			public override void SetValue(ref ResolvedStyleAccess container, Color value)
			{
			}
		}

		private class BorderRightWidthProperty : ResolvedFloatProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override float GetValue(ref ResolvedStyleAccess container)
			{
				return 0f;
			}

			public override void SetValue(ref ResolvedStyleAccess container, float value)
			{
			}
		}

		private class BorderTopColorProperty : ResolvedColorProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override Color GetValue(ref ResolvedStyleAccess container)
			{
				return default(Color);
			}

			public override void SetValue(ref ResolvedStyleAccess container, Color value)
			{
			}
		}

		private class BorderTopLeftRadiusProperty : ResolvedFloatProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override float GetValue(ref ResolvedStyleAccess container)
			{
				return 0f;
			}

			public override void SetValue(ref ResolvedStyleAccess container, float value)
			{
			}
		}

		private class BorderTopRightRadiusProperty : ResolvedFloatProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override float GetValue(ref ResolvedStyleAccess container)
			{
				return 0f;
			}

			public override void SetValue(ref ResolvedStyleAccess container, float value)
			{
			}
		}

		private class BorderTopWidthProperty : ResolvedFloatProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override float GetValue(ref ResolvedStyleAccess container)
			{
				return 0f;
			}

			public override void SetValue(ref ResolvedStyleAccess container, float value)
			{
			}
		}

		private class BottomProperty : ResolvedFloatProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override float GetValue(ref ResolvedStyleAccess container)
			{
				return 0f;
			}

			public override void SetValue(ref ResolvedStyleAccess container, float value)
			{
			}
		}

		private class ColorProperty : ResolvedColorProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override Color GetValue(ref ResolvedStyleAccess container)
			{
				return default(Color);
			}

			public override void SetValue(ref ResolvedStyleAccess container, Color value)
			{
			}
		}

		private class DisplayProperty : ResolvedEnumProperty<DisplayStyle>
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override DisplayStyle GetValue(ref ResolvedStyleAccess container)
			{
				return default(DisplayStyle);
			}

			public override void SetValue(ref ResolvedStyleAccess container, DisplayStyle value)
			{
			}
		}

		private class FilterProperty : ResolvedListProperty<FilterFunction>
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override IEnumerable<FilterFunction> GetValue(ref ResolvedStyleAccess container)
			{
				return null;
			}

			public override void SetValue(ref ResolvedStyleAccess container, IEnumerable<FilterFunction> value)
			{
			}
		}

		private class FlexBasisProperty : ResolvedStyleFloatProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleFloat GetValue(ref ResolvedStyleAccess container)
			{
				return default(StyleFloat);
			}

			public override void SetValue(ref ResolvedStyleAccess container, StyleFloat value)
			{
			}
		}

		private class FlexDirectionProperty : ResolvedEnumProperty<FlexDirection>
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override FlexDirection GetValue(ref ResolvedStyleAccess container)
			{
				return default(FlexDirection);
			}

			public override void SetValue(ref ResolvedStyleAccess container, FlexDirection value)
			{
			}
		}

		private class FlexGrowProperty : ResolvedFloatProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override float GetValue(ref ResolvedStyleAccess container)
			{
				return 0f;
			}

			public override void SetValue(ref ResolvedStyleAccess container, float value)
			{
			}
		}

		private class FlexShrinkProperty : ResolvedFloatProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override float GetValue(ref ResolvedStyleAccess container)
			{
				return 0f;
			}

			public override void SetValue(ref ResolvedStyleAccess container, float value)
			{
			}
		}

		private class FlexWrapProperty : ResolvedEnumProperty<Wrap>
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override Wrap GetValue(ref ResolvedStyleAccess container)
			{
				return default(Wrap);
			}

			public override void SetValue(ref ResolvedStyleAccess container, Wrap value)
			{
			}
		}

		private class FontSizeProperty : ResolvedFloatProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override float GetValue(ref ResolvedStyleAccess container)
			{
				return 0f;
			}

			public override void SetValue(ref ResolvedStyleAccess container, float value)
			{
			}
		}

		private class HeightProperty : ResolvedFloatProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override float GetValue(ref ResolvedStyleAccess container)
			{
				return 0f;
			}

			public override void SetValue(ref ResolvedStyleAccess container, float value)
			{
			}
		}

		private class JustifyContentProperty : ResolvedEnumProperty<Justify>
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override Justify GetValue(ref ResolvedStyleAccess container)
			{
				return default(Justify);
			}

			public override void SetValue(ref ResolvedStyleAccess container, Justify value)
			{
			}
		}

		private class LeftProperty : ResolvedFloatProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override float GetValue(ref ResolvedStyleAccess container)
			{
				return 0f;
			}

			public override void SetValue(ref ResolvedStyleAccess container, float value)
			{
			}
		}

		private class LetterSpacingProperty : ResolvedFloatProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override float GetValue(ref ResolvedStyleAccess container)
			{
				return 0f;
			}

			public override void SetValue(ref ResolvedStyleAccess container, float value)
			{
			}
		}

		private class MarginBottomProperty : ResolvedFloatProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override float GetValue(ref ResolvedStyleAccess container)
			{
				return 0f;
			}

			public override void SetValue(ref ResolvedStyleAccess container, float value)
			{
			}
		}

		private class MarginLeftProperty : ResolvedFloatProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override float GetValue(ref ResolvedStyleAccess container)
			{
				return 0f;
			}

			public override void SetValue(ref ResolvedStyleAccess container, float value)
			{
			}
		}

		private class MarginRightProperty : ResolvedFloatProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override float GetValue(ref ResolvedStyleAccess container)
			{
				return 0f;
			}

			public override void SetValue(ref ResolvedStyleAccess container, float value)
			{
			}
		}

		private class MarginTopProperty : ResolvedFloatProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override float GetValue(ref ResolvedStyleAccess container)
			{
				return 0f;
			}

			public override void SetValue(ref ResolvedStyleAccess container, float value)
			{
			}
		}

		private class MaxHeightProperty : ResolvedStyleFloatProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleFloat GetValue(ref ResolvedStyleAccess container)
			{
				return default(StyleFloat);
			}

			public override void SetValue(ref ResolvedStyleAccess container, StyleFloat value)
			{
			}
		}

		private class MaxWidthProperty : ResolvedStyleFloatProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleFloat GetValue(ref ResolvedStyleAccess container)
			{
				return default(StyleFloat);
			}

			public override void SetValue(ref ResolvedStyleAccess container, StyleFloat value)
			{
			}
		}

		private class MinHeightProperty : ResolvedStyleFloatProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleFloat GetValue(ref ResolvedStyleAccess container)
			{
				return default(StyleFloat);
			}

			public override void SetValue(ref ResolvedStyleAccess container, StyleFloat value)
			{
			}
		}

		private class MinWidthProperty : ResolvedStyleFloatProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override StyleFloat GetValue(ref ResolvedStyleAccess container)
			{
				return default(StyleFloat);
			}

			public override void SetValue(ref ResolvedStyleAccess container, StyleFloat value)
			{
			}
		}

		private class OpacityProperty : ResolvedFloatProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override float GetValue(ref ResolvedStyleAccess container)
			{
				return 0f;
			}

			public override void SetValue(ref ResolvedStyleAccess container, float value)
			{
			}
		}

		private class PaddingBottomProperty : ResolvedFloatProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override float GetValue(ref ResolvedStyleAccess container)
			{
				return 0f;
			}

			public override void SetValue(ref ResolvedStyleAccess container, float value)
			{
			}
		}

		private class PaddingLeftProperty : ResolvedFloatProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override float GetValue(ref ResolvedStyleAccess container)
			{
				return 0f;
			}

			public override void SetValue(ref ResolvedStyleAccess container, float value)
			{
			}
		}

		private class PaddingRightProperty : ResolvedFloatProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override float GetValue(ref ResolvedStyleAccess container)
			{
				return 0f;
			}

			public override void SetValue(ref ResolvedStyleAccess container, float value)
			{
			}
		}

		private class PaddingTopProperty : ResolvedFloatProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override float GetValue(ref ResolvedStyleAccess container)
			{
				return 0f;
			}

			public override void SetValue(ref ResolvedStyleAccess container, float value)
			{
			}
		}

		private class PositionProperty : ResolvedEnumProperty<Position>
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override Position GetValue(ref ResolvedStyleAccess container)
			{
				return default(Position);
			}

			public override void SetValue(ref ResolvedStyleAccess container, Position value)
			{
			}
		}

		private class RightProperty : ResolvedFloatProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override float GetValue(ref ResolvedStyleAccess container)
			{
				return 0f;
			}

			public override void SetValue(ref ResolvedStyleAccess container, float value)
			{
			}
		}

		private class RotateProperty : ResolvedRotateProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override Rotate GetValue(ref ResolvedStyleAccess container)
			{
				return default(Rotate);
			}

			public override void SetValue(ref ResolvedStyleAccess container, Rotate value)
			{
			}
		}

		private class ScaleProperty : ResolvedScaleProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override Scale GetValue(ref ResolvedStyleAccess container)
			{
				return default(Scale);
			}

			public override void SetValue(ref ResolvedStyleAccess container, Scale value)
			{
			}
		}

		private class TextOverflowProperty : ResolvedEnumProperty<TextOverflow>
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override TextOverflow GetValue(ref ResolvedStyleAccess container)
			{
				return default(TextOverflow);
			}

			public override void SetValue(ref ResolvedStyleAccess container, TextOverflow value)
			{
			}
		}

		private class TopProperty : ResolvedFloatProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override float GetValue(ref ResolvedStyleAccess container)
			{
				return 0f;
			}

			public override void SetValue(ref ResolvedStyleAccess container, float value)
			{
			}
		}

		private class TransformOriginProperty : ResolvedVector3Property
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override Vector3 GetValue(ref ResolvedStyleAccess container)
			{
				return default(Vector3);
			}

			public override void SetValue(ref ResolvedStyleAccess container, Vector3 value)
			{
			}
		}

		private class TransitionDelayProperty : ResolvedListProperty<TimeValue>
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override IEnumerable<TimeValue> GetValue(ref ResolvedStyleAccess container)
			{
				return null;
			}

			public override void SetValue(ref ResolvedStyleAccess container, IEnumerable<TimeValue> value)
			{
			}
		}

		private class TransitionDurationProperty : ResolvedListProperty<TimeValue>
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override IEnumerable<TimeValue> GetValue(ref ResolvedStyleAccess container)
			{
				return null;
			}

			public override void SetValue(ref ResolvedStyleAccess container, IEnumerable<TimeValue> value)
			{
			}
		}

		private class TransitionPropertyProperty : ResolvedListProperty<StylePropertyName>
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override IEnumerable<StylePropertyName> GetValue(ref ResolvedStyleAccess container)
			{
				return null;
			}

			public override void SetValue(ref ResolvedStyleAccess container, IEnumerable<StylePropertyName> value)
			{
			}
		}

		private class TransitionTimingFunctionProperty : ResolvedListProperty<EasingFunction>
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override IEnumerable<EasingFunction> GetValue(ref ResolvedStyleAccess container)
			{
				return null;
			}

			public override void SetValue(ref ResolvedStyleAccess container, IEnumerable<EasingFunction> value)
			{
			}
		}

		private class TranslateProperty : ResolvedVector3Property
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override Vector3 GetValue(ref ResolvedStyleAccess container)
			{
				return default(Vector3);
			}

			public override void SetValue(ref ResolvedStyleAccess container, Vector3 value)
			{
			}
		}

		private class UnityBackgroundImageTintColorProperty : ResolvedColorProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override Color GetValue(ref ResolvedStyleAccess container)
			{
				return default(Color);
			}

			public override void SetValue(ref ResolvedStyleAccess container, Color value)
			{
			}
		}

		private class UnityEditorTextRenderingModeProperty : ResolvedEnumProperty<EditorTextRenderingMode>
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override EditorTextRenderingMode GetValue(ref ResolvedStyleAccess container)
			{
				return default(EditorTextRenderingMode);
			}

			public override void SetValue(ref ResolvedStyleAccess container, EditorTextRenderingMode value)
			{
			}
		}

		private class UnityFontProperty : ResolvedFontProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override Font GetValue(ref ResolvedStyleAccess container)
			{
				return null;
			}

			public override void SetValue(ref ResolvedStyleAccess container, Font value)
			{
			}
		}

		private class UnityFontDefinitionProperty : ResolvedFontDefinitionProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override FontDefinition GetValue(ref ResolvedStyleAccess container)
			{
				return default(FontDefinition);
			}

			public override void SetValue(ref ResolvedStyleAccess container, FontDefinition value)
			{
			}
		}

		private class UnityFontStyleAndWeightProperty : ResolvedEnumProperty<FontStyle>
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override FontStyle GetValue(ref ResolvedStyleAccess container)
			{
				return default(FontStyle);
			}

			public override void SetValue(ref ResolvedStyleAccess container, FontStyle value)
			{
			}
		}

		private class UnityMaterialProperty : ResolvedMaterialDefinitionProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override MaterialDefinition GetValue(ref ResolvedStyleAccess container)
			{
				return default(MaterialDefinition);
			}

			public override void SetValue(ref ResolvedStyleAccess container, MaterialDefinition value)
			{
			}
		}

		private class UnityParagraphSpacingProperty : ResolvedFloatProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override float GetValue(ref ResolvedStyleAccess container)
			{
				return 0f;
			}

			public override void SetValue(ref ResolvedStyleAccess container, float value)
			{
			}
		}

		private class UnitySliceBottomProperty : ResolvedIntProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override int GetValue(ref ResolvedStyleAccess container)
			{
				return 0;
			}

			public override void SetValue(ref ResolvedStyleAccess container, int value)
			{
			}
		}

		private class UnitySliceLeftProperty : ResolvedIntProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override int GetValue(ref ResolvedStyleAccess container)
			{
				return 0;
			}

			public override void SetValue(ref ResolvedStyleAccess container, int value)
			{
			}
		}

		private class UnitySliceRightProperty : ResolvedIntProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override int GetValue(ref ResolvedStyleAccess container)
			{
				return 0;
			}

			public override void SetValue(ref ResolvedStyleAccess container, int value)
			{
			}
		}

		private class UnitySliceScaleProperty : ResolvedFloatProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override float GetValue(ref ResolvedStyleAccess container)
			{
				return 0f;
			}

			public override void SetValue(ref ResolvedStyleAccess container, float value)
			{
			}
		}

		private class UnitySliceTopProperty : ResolvedIntProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override int GetValue(ref ResolvedStyleAccess container)
			{
				return 0;
			}

			public override void SetValue(ref ResolvedStyleAccess container, int value)
			{
			}
		}

		private class UnitySliceTypeProperty : ResolvedEnumProperty<SliceType>
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override SliceType GetValue(ref ResolvedStyleAccess container)
			{
				return default(SliceType);
			}

			public override void SetValue(ref ResolvedStyleAccess container, SliceType value)
			{
			}
		}

		private class UnityTextAlignProperty : ResolvedEnumProperty<TextAnchor>
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override TextAnchor GetValue(ref ResolvedStyleAccess container)
			{
				return default(TextAnchor);
			}

			public override void SetValue(ref ResolvedStyleAccess container, TextAnchor value)
			{
			}
		}

		private class UnityTextGeneratorProperty : ResolvedEnumProperty<TextGeneratorType>
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override TextGeneratorType GetValue(ref ResolvedStyleAccess container)
			{
				return default(TextGeneratorType);
			}

			public override void SetValue(ref ResolvedStyleAccess container, TextGeneratorType value)
			{
			}
		}

		private class UnityTextOutlineColorProperty : ResolvedColorProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override Color GetValue(ref ResolvedStyleAccess container)
			{
				return default(Color);
			}

			public override void SetValue(ref ResolvedStyleAccess container, Color value)
			{
			}
		}

		private class UnityTextOutlineWidthProperty : ResolvedFloatProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override float GetValue(ref ResolvedStyleAccess container)
			{
				return 0f;
			}

			public override void SetValue(ref ResolvedStyleAccess container, float value)
			{
			}
		}

		private class UnityTextOverflowPositionProperty : ResolvedEnumProperty<TextOverflowPosition>
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override TextOverflowPosition GetValue(ref ResolvedStyleAccess container)
			{
				return default(TextOverflowPosition);
			}

			public override void SetValue(ref ResolvedStyleAccess container, TextOverflowPosition value)
			{
			}
		}

		private class VisibilityProperty : ResolvedEnumProperty<Visibility>
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override Visibility GetValue(ref ResolvedStyleAccess container)
			{
				return default(Visibility);
			}

			public override void SetValue(ref ResolvedStyleAccess container, Visibility value)
			{
			}
		}

		private class WhiteSpaceProperty : ResolvedEnumProperty<WhiteSpace>
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override WhiteSpace GetValue(ref ResolvedStyleAccess container)
			{
				return default(WhiteSpace);
			}

			public override void SetValue(ref ResolvedStyleAccess container, WhiteSpace value)
			{
			}
		}

		private class WidthProperty : ResolvedFloatProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override float GetValue(ref ResolvedStyleAccess container)
			{
				return 0f;
			}

			public override void SetValue(ref ResolvedStyleAccess container, float value)
			{
			}
		}

		private class WordSpacingProperty : ResolvedFloatProperty
		{
			public override string Name => null;

			public override string ussName => null;

			public override bool IsReadOnly => false;

			public override float GetValue(ref ResolvedStyleAccess container)
			{
				return 0f;
			}

			public override void SetValue(ref ResolvedStyleAccess container, float value)
			{
			}
		}

		private abstract class ResolvedStyleProperty<TValue> : Property<ResolvedStyleAccess, TValue>
		{
			public abstract string ussName { get; }
		}

		private abstract class ResolvedEnumProperty<TValue> : ResolvedStyleProperty<TValue> where TValue : struct, IConvertible
		{
		}

		private abstract class ResolvedColorProperty : ResolvedStyleProperty<Color>
		{
		}

		private abstract class ResolvedBackgroundProperty : ResolvedStyleProperty<Background>
		{
		}

		private abstract class ResolvedFloatProperty : ResolvedStyleProperty<float>
		{
		}

		private abstract class ResolvedStyleFloatProperty : ResolvedStyleProperty<StyleFloat>
		{
		}

		private abstract class ResolvedListProperty<T> : ResolvedStyleProperty<IEnumerable<T>>
		{
		}

		private abstract class ResolvedFontProperty : ResolvedStyleProperty<Font>
		{
		}

		private abstract class ResolvedFontDefinitionProperty : ResolvedStyleProperty<FontDefinition>
		{
		}

		private abstract class ResolvedIntProperty : ResolvedStyleProperty<int>
		{
		}

		private abstract class ResolvedRotateProperty : ResolvedStyleProperty<Rotate>
		{
		}

		private abstract class ResolvedScaleProperty : ResolvedStyleProperty<Scale>
		{
		}

		private abstract class ResolvedVector3Property : ResolvedStyleProperty<Vector3>
		{
		}

		private abstract class ResolvedBackgroundPositionProperty : ResolvedStyleProperty<BackgroundPosition>
		{
		}

		private abstract class ResolvedBackgroundRepeatProperty : ResolvedStyleProperty<BackgroundRepeat>
		{
		}

		private abstract class ResolvedBackgroundSizeProperty : ResolvedStyleProperty<BackgroundSize>
		{
		}

		private abstract class ResolvedMaterialDefinitionProperty : ResolvedStyleProperty<MaterialDefinition>
		{
		}

		private abstract class ResolvedRatioProperty : ResolvedStyleProperty<Ratio>
		{
		}

		private readonly List<IProperty<ResolvedStyleAccess>> m_PropertiesList;

		private readonly Dictionary<string, IProperty<ResolvedStyleAccess>> m_PropertiesHash;

		private void AddProperty<TValue>(ResolvedStyleProperty<TValue> property)
		{
		}

		public override PropertyCollection<ResolvedStyleAccess> GetProperties()
		{
			return default(PropertyCollection<ResolvedStyleAccess>);
		}

		public override PropertyCollection<ResolvedStyleAccess> GetProperties(ref ResolvedStyleAccess container)
		{
			return default(PropertyCollection<ResolvedStyleAccess>);
		}

		public bool TryGetProperty(ref ResolvedStyleAccess container, string name, out IProperty<ResolvedStyleAccess> property)
		{
			property = null;
			return false;
		}
	}
}
