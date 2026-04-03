using System;
using System.Collections.Generic;
using Unity.Properties;

namespace UnityEngine.UIElements
{
	[Serializable]
	public struct Angle : IEquatable<Angle>
	{
		private enum Unit
		{
			Degree = 0,
			Gradian = 1,
			Radian = 2,
			Turn = 3,
			None = 4
		}

		internal class PropertyBag : ContainerPropertyBag<Angle>
		{
			private class ValueProperty : Property<Angle, float>
			{
				public override string Name { get; }

				public override bool IsReadOnly { get; }

				public override float GetValue(ref Angle container)
				{
					return 0f;
				}

				public override void SetValue(ref Angle container, float value)
				{
				}
			}

			private class UnitProperty : Property<Angle, AngleUnit>
			{
				public override string Name { get; }

				public override bool IsReadOnly { get; }

				public override AngleUnit GetValue(ref Angle container)
				{
					return default(AngleUnit);
				}

				public override void SetValue(ref Angle container, AngleUnit value)
				{
				}
			}
		}

		private static readonly Dictionary<string, AngleUnit> s_AngleUnitLookup;

		[SerializeField]
		private float m_Value;

		[SerializeField]
		private Unit m_Unit;

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

		public AngleUnit unit
		{
			get
			{
				return default(AngleUnit);
			}
			set
			{
			}
		}

		internal static Angle None()
		{
			return default(Angle);
		}

		internal bool IsNone()
		{
			return false;
		}

		public Angle(float value, AngleUnit unit)
		{
			m_Value = 0f;
			m_Unit = default(Unit);
		}

		private Angle(float value, Unit unit)
		{
			m_Value = 0f;
			m_Unit = default(Unit);
		}

		public float ToDegrees()
		{
			return 0f;
		}

		public static implicit operator Angle(float value)
		{
			return default(Angle);
		}

		public static bool operator ==(Angle lhs, Angle rhs)
		{
			return false;
		}

		public static bool operator !=(Angle lhs, Angle rhs)
		{
			return false;
		}

		public bool Equals(Angle other)
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
