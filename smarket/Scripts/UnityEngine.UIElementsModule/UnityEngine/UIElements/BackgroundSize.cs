using System;
using Unity.Properties;

namespace UnityEngine.UIElements
{
	[Serializable]
	public struct BackgroundSize : IEquatable<BackgroundSize>
	{
		internal class PropertyBag : ContainerPropertyBag<BackgroundSize>
		{
			private class SizeTypeProperty : Property<BackgroundSize, BackgroundSizeType>
			{
				public override string Name { get; }

				public override bool IsReadOnly { get; }

				public override BackgroundSizeType GetValue(ref BackgroundSize container)
				{
					return default(BackgroundSizeType);
				}

				public override void SetValue(ref BackgroundSize container, BackgroundSizeType value)
				{
				}
			}

			private class XProperty : Property<BackgroundSize, Length>
			{
				public override string Name { get; }

				public override bool IsReadOnly { get; }

				public override Length GetValue(ref BackgroundSize container)
				{
					return default(Length);
				}

				public override void SetValue(ref BackgroundSize container, Length value)
				{
				}
			}

			private class YProperty : Property<BackgroundSize, Length>
			{
				public override string Name { get; }

				public override bool IsReadOnly { get; }

				public override Length GetValue(ref BackgroundSize container)
				{
					return default(Length);
				}

				public override void SetValue(ref BackgroundSize container, Length value)
				{
				}
			}
		}

		[SerializeField]
		private BackgroundSizeType m_SizeType;

		[SerializeField]
		private Length m_X;

		[SerializeField]
		private Length m_Y;

		public BackgroundSizeType sizeType
		{
			get
			{
				return default(BackgroundSizeType);
			}
			set
			{
			}
		}

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

		public BackgroundSize(Length sizeX, Length sizeY)
		{
			m_SizeType = default(BackgroundSizeType);
			m_X = default(Length);
			m_Y = default(Length);
		}

		public BackgroundSize(BackgroundSizeType sizeType)
		{
			m_SizeType = default(BackgroundSizeType);
			m_X = default(Length);
			m_Y = default(Length);
		}

		internal static BackgroundSize Initial()
		{
			return default(BackgroundSize);
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(BackgroundSize other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool operator ==(BackgroundSize style1, BackgroundSize style2)
		{
			return false;
		}

		public static bool operator !=(BackgroundSize style1, BackgroundSize style2)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
