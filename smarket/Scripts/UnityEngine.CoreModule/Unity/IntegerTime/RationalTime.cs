using System;
using UnityEngine;
using UnityEngine.Bindings;

namespace Unity.IntegerTime
{
	[Serializable]
	[NativeHeader("Runtime/Input/RationalTime.h")]
	public struct RationalTime
	{
		[Serializable]
		public struct TicksPerSecond : IEquatable<TicksPerSecond>
		{
			[SerializeField]
			private uint m_Numerator;

			[SerializeField]
			private uint m_Denominator;

			public static readonly TicksPerSecond DefaultTicksPerSecond;

			public static readonly TicksPerSecond TicksPerSecond24;

			public static readonly TicksPerSecond TicksPerSecond25;

			public static readonly TicksPerSecond TicksPerSecond30;

			public static readonly TicksPerSecond TicksPerSecond50;

			public static readonly TicksPerSecond TicksPerSecond60;

			public static readonly TicksPerSecond TicksPerSecond120;

			public static readonly TicksPerSecond TicksPerSecond2397;

			public static readonly TicksPerSecond TicksPerSecond2425;

			public static readonly TicksPerSecond TicksPerSecond2997;

			public static readonly TicksPerSecond TicksPerSecond5994;

			public static readonly TicksPerSecond TicksPerSecond11988;

			internal static readonly TicksPerSecond DiscreteTimeRate;

			public TicksPerSecond(uint num, uint den = 1u)
			{
				m_Numerator = 0u;
				m_Denominator = 0u;
			}

			public readonly bool Equals(TicksPerSecond rhs)
			{
				return false;
			}

			public override readonly bool Equals(object rhs)
			{
				return false;
			}

			public override readonly int GetHashCode()
			{
				return 0;
			}

			private static void Simplify(ref uint num, ref uint den)
			{
			}

			private static uint Gcd(uint a, uint b)
			{
				return 0u;
			}
		}

		[SerializeField]
		private long m_Count;

		[SerializeField]
		private TicksPerSecond m_TicksPerSecond;

		public long Count => 0L;

		public static explicit operator DiscreteTime(RationalTime t)
		{
			return default(DiscreteTime);
		}
	}
}
