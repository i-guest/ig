using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
	[Il2CppEagerStaticClassConstruction]
	[NativeClass("Vector3f")]
	[NativeHeader("Runtime/Math/Vector3.h")]
	[NativeType(Header = "Runtime/Math/Vector3.h")]
	[NativeHeader("Runtime/Math/MathScripting.h")]
	public struct Vector3 : IEquatable<Vector3>, IFormattable
	{
		public const float kEpsilon = 1E-05f;

		public const float kEpsilonNormalSqrt = 1E-15f;

		public float x;

		public float y;

		public float z;

		private static readonly Vector3 zeroVector;

		private static readonly Vector3 oneVector;

		private static readonly Vector3 upVector;

		private static readonly Vector3 downVector;

		private static readonly Vector3 leftVector;

		private static readonly Vector3 rightVector;

		private static readonly Vector3 forwardVector;

		private static readonly Vector3 backVector;

		private static readonly Vector3 positiveInfinityVector;

		private static readonly Vector3 negativeInfinityVector;

		public float this[int index]
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

		public readonly Vector3 normalized
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(Vector3);
			}
		}

		public readonly float magnitude
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return 0f;
			}
		}

		public readonly float sqrMagnitude
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return 0f;
			}
		}

		public static Vector3 zero
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(Vector3);
			}
		}

		public static Vector3 one
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(Vector3);
			}
		}

		public static Vector3 forward
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(Vector3);
			}
		}

		public static Vector3 back
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(Vector3);
			}
		}

		public static Vector3 up
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(Vector3);
			}
		}

		public static Vector3 down
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(Vector3);
			}
		}

		public static Vector3 left
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(Vector3);
			}
		}

		public static Vector3 right
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(Vector3);
			}
		}

		public static Vector3 positiveInfinity
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(Vector3);
			}
		}

		public static Vector3 negativeInfinity
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(Vector3);
			}
		}

		[FreeFunction("VectorScripting::Slerp", IsThreadSafe = true)]
		private static Vector3 Internal_Slerp(in Vector3 a, in Vector3 b, float t)
		{
			return default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Slerp(Vector3 a, Vector3 b, float t)
		{
			return default(Vector3);
		}

		[FreeFunction("VectorScripting::OrthoNormalize", IsThreadSafe = true)]
		private static void OrthoNormalize2(ref Vector3 a, ref Vector3 b)
		{
		}

		public static void OrthoNormalize(ref Vector3 normal, ref Vector3 tangent)
		{
		}

		[FreeFunction("VectorScripting::RotateTowards", IsThreadSafe = true)]
		private static Vector3 Internal_RotateTowards(in Vector3 current, in Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta)
		{
			return default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 RotateTowards(Vector3 current, Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta)
		{
			return default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Lerp(Vector3 a, Vector3 b, float t)
		{
			return default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 LerpUnclamped(Vector3 a, Vector3 b, float t)
		{
			return default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 MoveTowards(Vector3 current, Vector3 target, float maxDistanceDelta)
		{
			return default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[ExcludeFromDocs]
		public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime)
		{
			return default(Vector3);
		}

		public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, [DefaultValue("Mathf.Infinity")] float maxSpeed, [DefaultValue("Time.deltaTime")] float deltaTime)
		{
			return default(Vector3);
		}

		public static Vector3 SmoothDamp(in Vector3 current, in Vector3 target, ref Vector3 currentVelocity, float smoothTime, [DefaultValue("Mathf.Infinity")] float maxSpeed, [DefaultValue("Time.deltaTime")] float deltaTime)
		{
			return default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Vector3(float x, float y, float z)
		{
			this.x = 0f;
			this.y = 0f;
			this.z = 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Vector3(float x, float y)
		{
			this.x = 0f;
			this.y = 0f;
			z = 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Scale(Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Scale(Vector3 scale)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Cross(Vector3 lhs, Vector3 rhs)
		{
			return default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Cross(in Vector3 lhs, in Vector3 rhs)
		{
			return default(Vector3);
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
		public readonly bool Equals(Vector3 other)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly bool Equals(in Vector3 other)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Normalize(Vector3 value)
		{
			return default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Normalize(in Vector3 value)
		{
			return default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Normalize()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Dot(Vector3 lhs, Vector3 rhs)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Dot(in Vector3 lhs, in Vector3 rhs)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Project(Vector3 vector, Vector3 onNormal)
		{
			return default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 ProjectOnPlane(Vector3 vector, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Angle(Vector3 from, Vector3 to)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Angle(in Vector3 from, in Vector3 to)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float SignedAngle(Vector3 from, Vector3 to, Vector3 axis)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Distance(Vector3 a, Vector3 b)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 ClampMagnitude(Vector3 vector, float maxLength)
		{
			return default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Magnitude(Vector3 vector)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float SqrMagnitude(Vector3 vector)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Min(Vector3 lhs, Vector3 rhs)
		{
			return default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Min(in Vector3 lhs, in Vector3 rhs)
		{
			return default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Max(Vector3 lhs, Vector3 rhs)
		{
			return default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Max(in Vector3 lhs, in Vector3 rhs)
		{
			return default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 operator +(Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 operator -(Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 operator -(Vector3 a)
		{
			return default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 operator *(Vector3 a, float d)
		{
			return default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 operator *(float d, Vector3 a)
		{
			return default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 operator /(Vector3 a, float d)
		{
			return default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator ==(Vector3 lhs, Vector3 rhs)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator !=(Vector3 lhs, Vector3 rhs)
		{
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

		private static void Internal_Slerp_Injected(in Vector3 a, in Vector3 b, float t, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private static void Internal_RotateTowards_Injected(in Vector3 current, in Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta, out Vector3 ret)
		{
			ret = default(Vector3);
		}
	}
}
