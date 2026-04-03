using System;
using Unity.Properties;

namespace UnityEngine.UIElements
{
	public struct EasingFunction : IEquatable<EasingFunction>
	{
		internal class PropertyBag : ContainerPropertyBag<EasingFunction>
		{
			private class ModeProperty : Property<EasingFunction, EasingMode>
			{
				public override string Name { get; }

				public override bool IsReadOnly { get; }

				public override EasingMode GetValue(ref EasingFunction container)
				{
					return default(EasingMode);
				}

				public override void SetValue(ref EasingFunction container, EasingMode value)
				{
				}
			}
		}

		private EasingMode m_Mode;

		public EasingMode mode
		{
			get
			{
				return default(EasingMode);
			}
			set
			{
			}
		}

		public EasingFunction(EasingMode mode)
		{
			m_Mode = default(EasingMode);
		}

		public static implicit operator EasingFunction(EasingMode easingMode)
		{
			return default(EasingFunction);
		}

		public static bool operator ==(EasingFunction lhs, EasingFunction rhs)
		{
			return false;
		}

		public bool Equals(EasingFunction other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
