using System;
using Unity.Properties;

namespace UnityEngine.UIElements
{
	public readonly struct Ratio : IEquatable<Ratio>
	{
		internal class PropertyBag : ContainerPropertyBag<Ratio>
		{
			private class ValueProperty : Property<Ratio, float>
			{
				public override string Name { get; }

				public override bool IsReadOnly { get; }

				public override float GetValue(ref Ratio container)
				{
					return 0f;
				}

				public override void SetValue(ref Ratio container, float value)
				{
				}
			}

			private class AutoProperty : Property<Ratio, bool>
			{
				public override string Name { get; }

				public override bool IsReadOnly { get; }

				public override bool GetValue(ref Ratio container)
				{
					return false;
				}

				public override void SetValue(ref Ratio container, bool value)
				{
				}
			}
		}

		private readonly float m_Value;

		public float value => 0f;

		public Ratio(float value)
		{
			m_Value = 0f;
		}

		public bool IsAuto()
		{
			return false;
		}

		public static implicit operator Ratio(float value)
		{
			return default(Ratio);
		}

		public static implicit operator float(Ratio value)
		{
			return 0f;
		}

		public static bool operator ==(Ratio lhs, Ratio rhs)
		{
			return false;
		}

		public static bool operator !=(Ratio lhs, Ratio rhs)
		{
			return false;
		}

		public bool Equals(Ratio other)
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
