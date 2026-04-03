using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	[NativeHeader("Runtime/Export/Math/SphericalHarmonicsL2.bindings.h")]
	[UsedByNativeCode]
	public struct SphericalHarmonicsL2 : IEquatable<SphericalHarmonicsL2>
	{
		private float shr0;

		private float shr1;

		private float shr2;

		private float shr3;

		private float shr4;

		private float shr5;

		private float shr6;

		private float shr7;

		private float shr8;

		private float shg0;

		private float shg1;

		private float shg2;

		private float shg3;

		private float shg4;

		private float shg5;

		private float shg6;

		private float shg7;

		private float shg8;

		private float shb0;

		private float shb1;

		private float shb2;

		private float shb3;

		private float shb4;

		private float shb5;

		private float shb6;

		private float shb7;

		private float shb8;

		public float this[int rgb, int coefficient]
		{
			readonly get
			{
				return 0f;
			}
			set
			{
			}
		}

		public override readonly int GetHashCode()
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override readonly bool Equals(object other)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly bool Equals(SphericalHarmonicsL2 other)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly bool Equals(in SphericalHarmonicsL2 other)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator ==(SphericalHarmonicsL2 lhs, SphericalHarmonicsL2 rhs)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator !=(SphericalHarmonicsL2 lhs, SphericalHarmonicsL2 rhs)
		{
			return false;
		}
	}
}
