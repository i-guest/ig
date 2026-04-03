using System;
using Unity.Properties;

namespace UnityEngine.UIElements
{
	[Serializable]
	public struct BackgroundRepeat : IEquatable<BackgroundRepeat>
	{
		internal class PropertyBag : ContainerPropertyBag<BackgroundRepeat>
		{
			private class XProperty : Property<BackgroundRepeat, Repeat>
			{
				public override string Name { get; }

				public override bool IsReadOnly { get; }

				public override Repeat GetValue(ref BackgroundRepeat container)
				{
					return default(Repeat);
				}

				public override void SetValue(ref BackgroundRepeat container, Repeat value)
				{
				}
			}

			private class YProperty : Property<BackgroundRepeat, Repeat>
			{
				public override string Name { get; }

				public override bool IsReadOnly { get; }

				public override Repeat GetValue(ref BackgroundRepeat container)
				{
					return default(Repeat);
				}

				public override void SetValue(ref BackgroundRepeat container, Repeat value)
				{
				}
			}
		}

		public Repeat x;

		public Repeat y;

		public BackgroundRepeat(Repeat repeatX, Repeat repeatY)
		{
			x = default(Repeat);
			y = default(Repeat);
		}

		internal static BackgroundRepeat Initial()
		{
			return default(BackgroundRepeat);
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(BackgroundRepeat other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool operator ==(BackgroundRepeat style1, BackgroundRepeat style2)
		{
			return false;
		}

		public static bool operator !=(BackgroundRepeat style1, BackgroundRepeat style2)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
