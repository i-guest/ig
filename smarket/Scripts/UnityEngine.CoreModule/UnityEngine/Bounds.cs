using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Runtime/Geometry/Ray.h")]
	[NativeHeader("Runtime/Geometry/Intersection.h")]
	[NativeHeader("Runtime/Geometry/AABB.h")]
	[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
	[NativeType(Header = "Runtime/Geometry/AABB.h")]
	[NativeHeader("Runtime/Math/MathScripting.h")]
	[NativeClass("AABB")]
	public struct Bounds : IEquatable<Bounds>, IFormattable
	{
		private Vector3 m_Center;

		[NativeName("m_Extent")]
		private Vector3 m_Extents;

		public Vector3 center
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			readonly get
			{
				return default(Vector3);
			}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		public Vector3 size
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			readonly get
			{
				return default(Vector3);
			}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		public Vector3 extents
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			readonly get
			{
				return default(Vector3);
			}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		public Vector3 min
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			readonly get
			{
				return default(Vector3);
			}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		public Vector3 max
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			readonly get
			{
				return default(Vector3);
			}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Bounds(Vector3 center, Vector3 size)
		{
			m_Center = default(Vector3);
			m_Extents = default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
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
		public readonly bool Equals(Bounds other)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly bool Equals(in Bounds other)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator ==(Bounds lhs, Bounds rhs)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator !=(Bounds lhs, Bounds rhs)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void SetMinMax(Vector3 min, Vector3 max)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void SetMinMax(in Vector3 min, in Vector3 max)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Encapsulate(Vector3 point)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Encapsulate(in Vector3 point)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Encapsulate(Bounds bounds)
		{
		}

		public void Expand(float amount)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Expand(Vector3 amount)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly bool Intersects(Bounds bounds)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly bool IntersectRay(Ray ray)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly bool IntersectRay(Ray ray, out float distance)
		{
			distance = default(float);
			return false;
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

		[NativeMethod("IsInside", IsThreadSafe = true)]
		private readonly bool Internal_Contains(in Vector3 point)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly bool Contains(Vector3 point)
		{
			return false;
		}

		[FreeFunction("BoundsScripting::SqrDistance", HasExplicitThis = true, IsThreadSafe = true)]
		private readonly float Internal_SqrDistance(in Vector3 point)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly float SqrDistance(Vector3 point)
		{
			return 0f;
		}

		[FreeFunction("IntersectRayAABB", IsThreadSafe = true)]
		private static bool IntersectRayAABB(in Ray ray, in Bounds bounds, out float dist)
		{
			dist = default(float);
			return false;
		}
	}
}
