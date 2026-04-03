using System;
using Unity.Properties;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	public class Image : VisualElement
	{
		[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlFactory : UxmlFactory<Image, UxmlTraits>
		{
		}

		[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlTraits : VisualElement.UxmlTraits
		{
		}

		internal static readonly BindingId sourceProperty;

		internal static readonly BindingId imageProperty;

		internal static readonly BindingId spriteProperty;

		internal static readonly BindingId vectorImageProperty;

		internal static readonly BindingId sourceRectProperty;

		internal static readonly BindingId uvProperty;

		internal static readonly BindingId scaleModeProperty;

		internal static readonly BindingId tintColorProperty;

		private ScaleMode m_ScaleMode;

		private Object m_Image;

		private Rect m_UV;

		private Color m_TintColor;

		internal bool m_ImageIsInline;

		internal bool m_ScaleModeIsInline;

		internal bool m_TintColorIsInline;

		public static readonly string ussClassName;

		private static CustomStyleProperty<Texture2D> s_ImageProperty;

		private static CustomStyleProperty<Sprite> s_SpriteProperty;

		private static CustomStyleProperty<VectorImage> s_VectorImageProperty;

		private static CustomStyleProperty<string> s_ScaleModeProperty;

		private static CustomStyleProperty<Color> s_TintColorProperty;

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		[CreateProperty]
		internal Object source
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[CreateProperty]
		public Texture image
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[CreateProperty]
		public Sprite sprite
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[CreateProperty]
		public VectorImage vectorImage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[CreateProperty]
		public Rect sourceRect
		{
			get
			{
				return default(Rect);
			}
			set
			{
			}
		}

		[CreateProperty]
		public Rect uv
		{
			get
			{
				return default(Rect);
			}
			set
			{
			}
		}

		[CreateProperty]
		public ScaleMode scaleMode
		{
			get
			{
				return default(ScaleMode);
			}
			set
			{
			}
		}

		[CreateProperty]
		public Color tintColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		private Vector2 GetTextureDisplaySize(Texture texture)
		{
			return default(Vector2);
		}

		private Vector2 GetTextureDisplaySize(Sprite sprite)
		{
			return default(Vector2);
		}

		protected internal override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode)
		{
			return default(Vector2);
		}

		private void OnGenerateVisualContent(MeshGenerationContext mgc)
		{
		}

		private void OnCustomStyleResolved(CustomStyleResolvedEvent e)
		{
		}

		private void ReadCustomProperties(ICustomStyle customStyleProvider)
		{
		}

		private void SetInlineProperty<T>(Object value, BindingId binding)
		{
		}

		private void SetCustomProperty(Object value, BindingId binding)
		{
		}

		private void ClearProperty()
		{
		}

		private void SetScaleMode(ScaleMode mode)
		{
		}

		private void SetTintColor(Color color)
		{
		}

		private void CalculateUV(Rect srcRect)
		{
		}

		private Rect GetSourceRect()
		{
			return default(Rect);
		}
	}
}
