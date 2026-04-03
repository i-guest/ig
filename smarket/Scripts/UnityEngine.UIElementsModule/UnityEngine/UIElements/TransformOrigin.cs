using System;
using Unity.Properties;

namespace UnityEngine.UIElements
{
	[Serializable]
	public struct TransformOrigin : IEquatable<TransformOrigin>
	{
		internal class PropertyBag : ContainerPropertyBag<TransformOrigin>
		{
			private class XProperty : Property<TransformOrigin, Length>
			{
				public override string Name { get; }

				public override bool IsReadOnly { get; }

				public override Length GetValue(ref TransformOrigin container)
				{
					return default(Length);
				}

				public override void SetValue(ref TransformOrigin container, Length value)
				{
				}
			}

			private class YProperty : Property<TransformOrigin, Length>
			{
				public override string Name { get; }

				public override bool IsReadOnly { get; }

				public override Length GetValue(ref TransformOrigin container)
				{
					return default(Length);
				}

				public override void SetValue(ref TransformOrigin container, Length value)
				{
				}
			}

			private class ZProperty : Property<TransformOrigin, float>
			{
				public override string Name { get; }

				public override bool IsReadOnly { get; }

				public override float GetValue(ref TransformOrigin container)
				{
					return 0f;
				}

				public override void SetValue(ref TransformOrigin container, float value)
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

		public TransformOrigin(Length x, Length y, float z)
		{
			m_X = default(Length);
			m_Y = default(Length);
			m_Z = 0f;
		}

		internal TransformOrigin(Vector3 vector)
		{
			m_X = default(Length);
			m_Y = default(Length);
			m_Z = 0f;
		}

		public static TransformOrigin Initial()
		{
			return default(TransformOrigin);
		}

		public static bool operator ==(TransformOrigin lhs, TransformOrigin rhs)
		{
			return false;
		}

		public static bool operator !=(TransformOrigin lhs, TransformOrigin rhs)
		{
			return false;
		}

		public bool Equals(TransformOrigin other)
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
