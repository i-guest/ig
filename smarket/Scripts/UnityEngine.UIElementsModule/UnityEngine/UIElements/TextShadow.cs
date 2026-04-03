using System;
using Unity.Properties;

namespace UnityEngine.UIElements
{
	[Serializable]
	public struct TextShadow : IEquatable<TextShadow>
	{
		internal class PropertyBag : ContainerPropertyBag<TextShadow>
		{
			private class OffsetProperty : Property<TextShadow, Vector2>
			{
				public override string Name { get; }

				public override bool IsReadOnly { get; }

				public override Vector2 GetValue(ref TextShadow container)
				{
					return default(Vector2);
				}

				public override void SetValue(ref TextShadow container, Vector2 value)
				{
				}
			}

			private class BlurRadiusProperty : Property<TextShadow, float>
			{
				public override string Name { get; }

				public override bool IsReadOnly { get; }

				public override float GetValue(ref TextShadow container)
				{
					return 0f;
				}

				public override void SetValue(ref TextShadow container, float value)
				{
				}
			}

			private class ColorProperty : Property<TextShadow, Color>
			{
				public override string Name { get; }

				public override bool IsReadOnly { get; }

				public override Color GetValue(ref TextShadow container)
				{
					return default(Color);
				}

				public override void SetValue(ref TextShadow container, Color value)
				{
				}
			}
		}

		public Vector2 offset;

		public float blurRadius;

		public Color color;

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(TextShadow other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool operator ==(TextShadow style1, TextShadow style2)
		{
			return false;
		}

		public static bool operator !=(TextShadow style1, TextShadow style2)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}

		internal static TextShadow LerpUnclamped(TextShadow a, TextShadow b, float t)
		{
			return default(TextShadow);
		}
	}
}
