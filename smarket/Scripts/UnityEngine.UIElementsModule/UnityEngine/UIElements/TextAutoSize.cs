using System;
using Unity.Properties;

namespace UnityEngine.UIElements
{
	public struct TextAutoSize : IEquatable<TextAutoSize>
	{
		internal class PropertyBag : ContainerPropertyBag<TextAutoSize>
		{
			private class ModeProperty : Property<TextAutoSize, TextAutoSizeMode>
			{
				public override string Name { get; }

				public override bool IsReadOnly { get; }

				public override TextAutoSizeMode GetValue(ref TextAutoSize container)
				{
					return default(TextAutoSizeMode);
				}

				public override void SetValue(ref TextAutoSize container, TextAutoSizeMode value)
				{
				}
			}

			private class MinSizeProperty : Property<TextAutoSize, Length>
			{
				public override string Name { get; }

				public override bool IsReadOnly { get; }

				public override Length GetValue(ref TextAutoSize container)
				{
					return default(Length);
				}

				public override void SetValue(ref TextAutoSize container, Length value)
				{
				}
			}

			private class MaxSizeProperty : Property<TextAutoSize, Length>
			{
				public override string Name { get; }

				public override bool IsReadOnly { get; }

				public override Length GetValue(ref TextAutoSize container)
				{
					return default(Length);
				}

				public override void SetValue(ref TextAutoSize container, Length value)
				{
				}
			}
		}

		public TextAutoSizeMode mode { get; set; }

		public Length minSize { get; set; }

		public Length maxSize { get; set; }

		public static TextAutoSize None()
		{
			return default(TextAutoSize);
		}

		public bool Equals(TextAutoSize other)
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

		public static bool operator ==(TextAutoSize left, TextAutoSize right)
		{
			return false;
		}

		public static bool operator !=(TextAutoSize left, TextAutoSize right)
		{
			return false;
		}
	}
}
