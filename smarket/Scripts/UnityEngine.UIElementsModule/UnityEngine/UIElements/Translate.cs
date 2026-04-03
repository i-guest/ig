using System;
using Unity.Properties;

namespace UnityEngine.UIElements
{
	[Serializable]
	public struct Translate : IEquatable<Translate>
	{
		internal class PropertyBag : ContainerPropertyBag<Translate>
		{
			private class XProperty : Property<Translate, Length>
			{
				public override string Name { get; }

				public override bool IsReadOnly { get; }

				public override Length GetValue(ref Translate container)
				{
					return default(Length);
				}

				public override void SetValue(ref Translate container, Length value)
				{
				}
			}

			private class YProperty : Property<Translate, Length>
			{
				public override string Name { get; }

				public override bool IsReadOnly { get; }

				public override Length GetValue(ref Translate container)
				{
					return default(Length);
				}

				public override void SetValue(ref Translate container, Length value)
				{
				}
			}

			private class ZProperty : Property<Translate, float>
			{
				public override string Name { get; }

				public override bool IsReadOnly { get; }

				public override float GetValue(ref Translate container)
				{
					return 0f;
				}

				public override void SetValue(ref Translate container, float value)
				{
				}
			}
		}

		[SerializeField]
		private Length m_X;

		[SerializeField]
		private Length m_Y;

		[SerializeField]
		private float m_Z;

		[SerializeField]
		private bool m_isNone;

		public Length x
		{
			get
			{
				return default(Length);
			}
			set
			{
			}
		}

		public Length y
		{
			get
			{
				return default(Length);
			}
			set
			{
			}
		}

		public float z
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Translate(Length x, Length y, float z)
		{
			m_X = default(Length);
			m_Y = default(Length);
			m_Z = 0f;
			m_isNone = false;
		}

		internal Translate(Vector3 v)
		{
			m_X = default(Length);
			m_Y = default(Length);
			m_Z = 0f;
			m_isNone = false;
		}

		public static implicit operator Translate(Vector3 v)
		{
			return default(Translate);
		}

		public static Translate None()
		{
			return default(Translate);
		}

		public static bool operator ==(Translate lhs, Translate rhs)
		{
			return false;
		}

		public static bool operator !=(Translate lhs, Translate rhs)
		{
			return false;
		}

		public bool Equals(Translate other)
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
