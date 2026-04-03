using System;
using Unity.Properties;

namespace UnityEngine.UIElements
{
	[Serializable]
	public struct BackgroundPosition : IEquatable<BackgroundPosition>
	{
		internal class PropertyBag : ContainerPropertyBag<BackgroundPosition>
		{
			private class KeywordProperty : Property<BackgroundPosition, BackgroundPositionKeyword>
			{
				public override string Name { get; }

				public override bool IsReadOnly { get; }

				public override BackgroundPositionKeyword GetValue(ref BackgroundPosition container)
				{
					return default(BackgroundPositionKeyword);
				}

				public override void SetValue(ref BackgroundPosition container, BackgroundPositionKeyword value)
				{
				}
			}

			private class OffsetProperty : Property<BackgroundPosition, Length>
			{
				public override string Name { get; }

				public override bool IsReadOnly { get; }

				public override Length GetValue(ref BackgroundPosition container)
				{
					return default(Length);
				}

				public override void SetValue(ref BackgroundPosition container, Length value)
				{
				}
			}
		}

		public BackgroundPositionKeyword keyword;

		public Length offset;

		public BackgroundPosition(BackgroundPositionKeyword keyword)
		{
			this.keyword = default(BackgroundPositionKeyword);
			offset = default(Length);
		}

		public BackgroundPosition(BackgroundPositionKeyword keyword, Length offset)
		{
			this.keyword = default(BackgroundPositionKeyword);
			this.offset = default(Length);
		}

		internal static BackgroundPosition Initial()
		{
			return default(BackgroundPosition);
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(BackgroundPosition other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool operator ==(BackgroundPosition style1, BackgroundPosition style2)
		{
			return false;
		}

		public static bool operator !=(BackgroundPosition style1, BackgroundPosition style2)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
