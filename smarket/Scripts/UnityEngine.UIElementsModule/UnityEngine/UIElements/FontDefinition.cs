using System;
using Unity.Properties;
using UnityEngine.TextCore.Text;

namespace UnityEngine.UIElements
{
	[Serializable]
	public struct FontDefinition : IEquatable<FontDefinition>
	{
		internal class PropertyBag : ContainerPropertyBag<FontDefinition>
		{
			private class FontProperty : Property<FontDefinition, Font>
			{
				public override string Name { get; }

				public override bool IsReadOnly { get; }

				public override Font GetValue(ref FontDefinition container)
				{
					return null;
				}

				public override void SetValue(ref FontDefinition container, Font value)
				{
				}
			}

			private class FontAssetProperty : Property<FontDefinition, FontAsset>
			{
				public override string Name { get; }

				public override bool IsReadOnly { get; }

				public override FontAsset GetValue(ref FontDefinition container)
				{
					return null;
				}

				public override void SetValue(ref FontDefinition container, FontAsset value)
				{
				}
			}
		}

		[SerializeField]
		private Font m_Font;

		[SerializeField]
		private FontAsset m_FontAsset;

		public Font font
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public FontAsset fontAsset
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static FontDefinition FromFont(Font f)
		{
			return default(FontDefinition);
		}

		public static FontDefinition FromSDFFont(FontAsset f)
		{
			return default(FontDefinition);
		}

		internal static FontDefinition FromObject(object obj)
		{
			return default(FontDefinition);
		}

		internal bool IsEmpty()
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}

		public bool Equals(FontDefinition other)
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

		public static bool operator ==(FontDefinition left, FontDefinition right)
		{
			return false;
		}

		public static bool operator !=(FontDefinition left, FontDefinition right)
		{
			return false;
		}
	}
}
