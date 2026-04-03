using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[UsedByNativeCode]
	public struct Plane : IEquatable<Plane>, IFormattable
	{
		internal const int size = 16;

		private Vector3 m_Normal;

		private float m_Distance;

		public readonly Vector3 normal
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(Vector3);
			}
		}

		public float distance
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			readonly get
			{
				return 0f;
			}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Plane(Vector3 inNormal, Vector3 inPoint)
		{
			m_Normal = default(Vector3);
			m_Distance = 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Plane(Vector3 inNormal, float d)
		{
			m_Normal = default(Vector3);
			m_Distance = 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Plane(Vector3 a, Vector3 b, Vector3 c)
		{
			m_Normal = default(Vector3);
			m_Distance = 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly Vector3 ClosestPointOnPlane(Vector3 point)
		{
			return default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly float GetDistanceToPoint(Vector3 point)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly bool Raycast(Ray ray, out float enter)
		{
			enter = default(float);
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator ==(Plane lhs, Plane rhs)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override readonly bool Equals(object other)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly bool Equals(Plane other)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly bool Equals(in Plane other)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override readonly int GetHashCode()
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override readonly string ToString()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}
	}
}
