using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.IntegerTime
{
	[Serializable]
	public struct DiscreteTime : IEquatable<DiscreteTime>, IFormattable, IComparable<DiscreteTime>
	{
		[SerializeField]
		public long Value;

		public static readonly DiscreteTime Zero;

		public static readonly DiscreteTime MinValue;

		public static readonly DiscreteTime MaxValue;

		private static readonly int TicksPerSecondBits;

		private static readonly int NonPow2TpsBits;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public DiscreteTime(float v)
		{
			Value = 0L;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public DiscreteTime(double v)
		{
			Value = 0L;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private DiscreteTime(long v, int _)
		{
			Value = 0L;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static DiscreteTime FromTicks(long v)
		{
			return default(DiscreteTime);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static explicit operator float(DiscreteTime d)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static explicit operator double(DiscreteTime d)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator !=(DiscreteTime lhs, DiscreteTime rhs)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator >(DiscreteTime lhs, DiscreteTime rhs)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator >=(DiscreteTime lhs, DiscreteTime rhs)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static DiscreteTime operator +(DiscreteTime lhs, DiscreteTime rhs)
		{
			return default(DiscreteTime);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static DiscreteTime operator -(DiscreteTime lhs, DiscreteTime rhs)
		{
			return default(DiscreteTime);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly bool Equals(DiscreteTime rhs)
		{
			return false;
		}

		public override readonly bool Equals(object o)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override readonly int GetHashCode()
		{
			return 0;
		}

		public override readonly string ToString()
		{
			return null;
		}

		public readonly string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		public readonly int CompareTo(DiscreteTime other)
		{
			return 0;
		}
	}
}
