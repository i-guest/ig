using System;
using Unity.Properties;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	[Serializable]
	public struct Cursor : IEquatable<Cursor>
	{
		internal class PropertyBag : ContainerPropertyBag<Cursor>
		{
			private class TextureProperty : Property<Cursor, Texture2D>
			{
				public override string Name { get; }

				public override bool IsReadOnly { get; }

				public override Texture2D GetValue(ref Cursor container)
				{
					return null;
				}

				public override void SetValue(ref Cursor container, Texture2D value)
				{
				}
			}

			private class HotspotProperty : Property<Cursor, Vector2>
			{
				public override string Name { get; }

				public override bool IsReadOnly { get; }

				public override Vector2 GetValue(ref Cursor container)
				{
					return default(Vector2);
				}

				public override void SetValue(ref Cursor container, Vector2 value)
				{
				}
			}

			private class DefaultCursorIdProperty : Property<Cursor, int>
			{
				public override string Name { get; }

				public override bool IsReadOnly { get; }

				public override int GetValue(ref Cursor container)
				{
					return 0;
				}

				public override void SetValue(ref Cursor container, int value)
				{
				}
			}
		}

		[SerializeField]
		private Texture2D m_Texture;

		[SerializeField]
		private Vector2 m_Hotspot;

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

		public Vector2 hotspot
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal int defaultCursorId { get; set; }

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(Cursor other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool operator ==(Cursor style1, Cursor style2)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
