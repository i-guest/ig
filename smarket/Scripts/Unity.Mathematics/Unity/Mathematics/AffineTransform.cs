using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics
{
	[Serializable]
	[Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstruction]
	public struct AffineTransform : IEquatable<AffineTransform>, IFormattable
	{
		public float3x3 rs;

		public float3 t;

		public static readonly AffineTransform identity;

		public static readonly AffineTransform zero;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public AffineTransform(float3 translation, quaternion rotation)
		{
			rs = default(float3x3);
			t = default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public AffineTransform(float3 translation, quaternion rotation, float3 scale)
		{
			rs = default(float3x3);
			t = default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public AffineTransform(float3 translation, float3x3 rotationScale)
		{
			rs = default(float3x3);
			t = default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public AffineTransform(float3x3 rotationScale)
		{
			rs = default(float3x3);
			t = default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public AffineTransform(RigidTransform rigid)
		{
			rs = default(float3x3);
			t = default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public AffineTransform(float3x4 m)
		{
			rs = default(float3x3);
			t = default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public AffineTransform(float4x4 m)
		{
			rs = default(float3x3);
			t = default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static implicit operator float3x4(AffineTransform m)
		{
			return default(float3x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static implicit operator float4x4(AffineTransform m)
		{
			return default(float4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Equals(AffineTransform rhs)
		{
			return false;
		}

		public override bool Equals(object o)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override string ToString()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}
	}
}
