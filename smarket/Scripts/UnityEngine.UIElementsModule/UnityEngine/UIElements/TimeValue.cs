using System;
using Unity.Properties;

namespace UnityEngine.UIElements
{
	[Serializable]
	public struct TimeValue : IEquatable<TimeValue>
	{
		internal class PropertyBag : ContainerPropertyBag<TimeValue>
		{
			private class ValueProperty : Property<TimeValue, float>
			{
				public override string Name { get; }

				public override bool IsReadOnly { get; }

				public override float GetValue(ref TimeValue container)
				{
					return 0f;
				}

				public override void SetValue(ref TimeValue container, float value)
				{
				}
			}

			private class UnitProperty : Property<TimeValue, TimeUnit>
			{
				public override string Name { get; }

				public override bool IsReadOnly { get; }

				public override TimeUnit GetValue(ref TimeValue container)
				{
					return default(TimeUnit);
				}

				public override void SetValue(ref TimeValue container, TimeUnit value)
				{
				}
			}
		}

		[SerializeField]
		private float m_Value;

		[SerializeField]
		private TimeUnit m_Unit;

		public float value
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public TimeUnit unit
		{
			get
			{
				return default(TimeUnit);
			}
			set
			{
			}
		}

		public TimeValue(float value)
		{
			m_Value = 0f;
			m_Unit = default(TimeUnit);
		}

		public TimeValue(float value, TimeUnit unit)
		{
			m_Value = 0f;
			m_Unit = default(TimeUnit);
		}

		public static implicit operator TimeValue(float value)
		{
			return default(TimeValue);
		}

		public static bool operator ==(TimeValue lhs, TimeValue rhs)
		{
			return false;
		}

		public static bool operator !=(TimeValue lhs, TimeValue rhs)
		{
			return false;
		}

		public bool Equals(TimeValue other)
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
