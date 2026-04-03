using System;
using Unity.Properties;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	[Serializable]
	public struct Background : IEquatable<Background>
	{
		internal class PropertyBag : ContainerPropertyBag<Background>
		{
			private class TextureProperty : Property<Background, Texture2D>
			{
				public override string Name { get; }

				public override bool IsReadOnly { get; }

				public override Texture2D GetValue(ref Background container)
				{
					return null;
				}

				public override void SetValue(ref Background container, Texture2D value)
				{
				}
			}

			private class SpriteProperty : Property<Background, Sprite>
			{
				public override string Name { get; }

				public override bool IsReadOnly { get; }

				public override Sprite GetValue(ref Background container)
				{
					return null;
				}

				public override void SetValue(ref Background container, Sprite value)
				{
				}
			}

			private class RenderTextureProperty : Property<Background, RenderTexture>
			{
				public override string Name { get; }

				public override bool IsReadOnly { get; }

				public override RenderTexture GetValue(ref Background container)
				{
					return null;
				}

				public override void SetValue(ref Background container, RenderTexture value)
				{
				}
			}

			private class VectorImageProperty : Property<Background, VectorImage>
			{
				public override string Name { get; }

				public override bool IsReadOnly { get; }

				public override VectorImage GetValue(ref Background container)
				{
					return null;
				}

				public override void SetValue(ref Background container, VectorImage value)
				{
				}
			}
		}

		[SerializeField]
		private Texture2D m_Texture;

		[SerializeField]
		private Sprite m_Sprite;

		[SerializeField]
		private RenderTexture m_RenderTexture;

		[SerializeField]
		private VectorImage m_VectorImage;

		public Texture2D texture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

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

		public RenderTexture renderTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

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

		public static Background FromTexture2D(Texture2D t)
		{
			return default(Background);
		}

		public static Background FromRenderTexture(RenderTexture rt)
		{
			return default(Background);
		}

		public static Background FromSprite(Sprite s)
		{
			return default(Background);
		}

		public static Background FromVectorImage(VectorImage vi)
		{
			return default(Background);
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIToolkitAuthoringModule" })]
		internal static Background FromObject(object obj)
		{
			return default(Background);
		}

		public bool IsEmpty()
		{
			return false;
		}

		public static bool operator ==(Background lhs, Background rhs)
		{
			return false;
		}

		public static bool operator !=(Background lhs, Background rhs)
		{
			return false;
		}

		public static implicit operator Background(Texture2D v)
		{
			return default(Background);
		}

		public bool Equals(Background other)
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

		public override string ToString()
		{
			return null;
		}
	}
}
