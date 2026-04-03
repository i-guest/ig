using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeType(Header = "Runtime/Math/Quaternion.h")]
	[Il2CppEagerStaticClassConstruction]
	[DefaultMember("Item")]
	[NativeHeader("Runtime/Math/MathScripting.h")]
	[UsedByNativeCode]
	public struct Quaternion : IEquatable<Quaternion>, IFormattable
	{
		public float x;

		public float y;

		public float z;

		public float w;

		private static readonly Quaternion identityQuaternion;

		public const float kEpsilon = 1E-06f;

		public static Quaternion identity
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(Quaternion);
			}
		}

		public Vector3 eulerAngles
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

		public readonly Quaternion normalized
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(Quaternion);
			}
		}

		[FreeFunction("FromToQuaternionSafe", IsThreadSafe = true)]
		private static Quaternion Internal_FromToRotation(in Vector3 fromDirection, in Vector3 toDirection)
		{
			return default(Quaternion);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Quaternion FromToRotation(Vector3 fromDirection, Vector3 toDirection)
		{
			return default(Quaternion);
		}

		[FreeFunction("QuaternionScripting::Inverse", IsThreadSafe = true)]
		private static Quaternion Internal_Inverse(in Quaternion rotation)
		{
			return default(Quaternion);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Quaternion Inverse(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[FreeFunction("QuaternionScripting::Slerp", IsThreadSafe = true)]
		private static Quaternion Internal_Slerp(in Quaternion a, in Quaternion b, float t)
		{
			return default(Quaternion);
		}

		[FreeFunction("QuaternionScripting::SlerpUnclamped", IsThreadSafe = true)]
		private static Quaternion Internal_SlerpUnclamped(in Quaternion a, in Quaternion b, float t)
		{
			return default(Quaternion);
		}

		[FreeFunction("QuaternionScripting::Lerp", IsThreadSafe = true)]
		private static Quaternion Internal_Lerp(in Quaternion a, in Quaternion b, float t)
		{
			return default(Quaternion);
		}

		[FreeFunction("QuaternionScripting::LerpUnclamped", IsThreadSafe = true)]
		private static Quaternion Internal_LerpUnclamped(in Quaternion a, in Quaternion b, float t)
		{
			return default(Quaternion);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Quaternion Slerp(Quaternion a, Quaternion b, float t)
		{
			return default(Quaternion);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Quaternion SlerpUnclamped(Quaternion a, Quaternion b, float t)
		{
			return default(Quaternion);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Quaternion Lerp(Quaternion a, Quaternion b, float t)
		{
			return default(Quaternion);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Quaternion LerpUnclamped(Quaternion a, Quaternion b, float t)
		{
			return default(Quaternion);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Quaternion SlerpUnclamped(in Quaternion a, in Quaternion b, float t)
		{
			return default(Quaternion);
		}

		[FreeFunction("EulerToQuaternion", IsThreadSafe = true)]
		private static Quaternion Internal_FromEulerRad(in Vector3 euler)
		{
			return default(Quaternion);
		}

		[FreeFunction("QuaternionScripting::ToEuler", IsThreadSafe = true)]
		private static Vector3 Internal_ToEulerRad(in Quaternion rotation)
		{
			return default(Vector3);
		}

		[FreeFunction("QuaternionScripting::ToAxisAngle", IsThreadSafe = true)]
		private static void Internal_ToAxisAngleRad(in Quaternion q, out Vector3 axis, out float angle)
		{
			axis = default(Vector3);
			angle = default(float);
		}

		[FreeFunction("QuaternionScripting::AngleAxis", IsThreadSafe = true)]
		private static Quaternion Internal_AngleAxis(float angle, in Vector3 axis)
		{
			return default(Quaternion);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Quaternion AngleAxis(float angle, Vector3 axis)
		{
			return default(Quaternion);
		}

		[FreeFunction("QuaternionScripting::LookRotation", IsThreadSafe = true)]
		private static Quaternion Internal_LookRotation(in Vector3 forward, [DefaultValue("Vector3.up")] in Vector3 upwards)
		{
			return default(Quaternion);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Quaternion LookRotation(Vector3 forward, [DefaultValue("Vector3.up")] Vector3 upwards)
		{
			return default(Quaternion);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[ExcludeFromDocs]
		public static Quaternion LookRotation(Vector3 forward)
		{
			return default(Quaternion);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Quaternion(float x, float y, float z, float w)
		{
			this.x = 0f;
			this.y = 0f;
			this.z = 0f;
			this.w = 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Quaternion operator *(Quaternion lhs, Quaternion rhs)
		{
			return default(Quaternion);
		}

		public static Vector3 operator *(Quaternion rotation, Vector3 point)
		{
			return default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator ==(Quaternion lhs, Quaternion rhs)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator !=(Quaternion lhs, Quaternion rhs)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool IsEqualUsingDot(float dot)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Dot(Quaternion a, Quaternion b)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Dot(in Quaternion a, in Quaternion b)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Angle(Quaternion a, Quaternion b)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Angle(in Quaternion a, in Quaternion b)
		{
			return 0f;
		}

		private static Vector3 Internal_MakePositive(Vector3 euler)
		{
			return default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Quaternion Euler(float x, float y, float z)
		{
			return default(Quaternion);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Quaternion Euler(Vector3 euler)
		{
			return default(Quaternion);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void ToAngleAxis(out float angle, out Vector3 axis)
		{
			angle = default(float);
			axis = default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Quaternion RotateTowards(Quaternion from, Quaternion to, float maxDegreesDelta)
		{
			return default(Quaternion);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Quaternion Normalize(Quaternion q)
		{
			return default(Quaternion);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Quaternion Normalize(in Quaternion q)
		{
			return default(Quaternion);
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
		public readonly bool Equals(Quaternion other)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly bool Equals(in Quaternion other)
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

		private static void Internal_FromToRotation_Injected(in Vector3 fromDirection, in Vector3 toDirection, out Quaternion ret)
		{
			ret = default(Quaternion);
		}

		private static void Internal_Inverse_Injected(in Quaternion rotation, out Quaternion ret)
		{
			ret = default(Quaternion);
		}

		private static void Internal_Slerp_Injected(in Quaternion a, in Quaternion b, float t, out Quaternion ret)
		{
			ret = default(Quaternion);
		}

		private static void Internal_SlerpUnclamped_Injected(in Quaternion a, in Quaternion b, float t, out Quaternion ret)
		{
			ret = default(Quaternion);
		}

		private static void Internal_Lerp_Injected(in Quaternion a, in Quaternion b, float t, out Quaternion ret)
		{
			ret = default(Quaternion);
		}

		private static void Internal_LerpUnclamped_Injected(in Quaternion a, in Quaternion b, float t, out Quaternion ret)
		{
			ret = default(Quaternion);
		}

		private static void Internal_FromEulerRad_Injected(in Vector3 euler, out Quaternion ret)
		{
			ret = default(Quaternion);
		}

		private static void Internal_ToEulerRad_Injected(in Quaternion rotation, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private static void Internal_AngleAxis_Injected(float angle, in Vector3 axis, out Quaternion ret)
		{
			ret = default(Quaternion);
		}

		private static void Internal_LookRotation_Injected(in Vector3 forward, [DefaultValue("Vector3.up")] in Vector3 upwards, out Quaternion ret)
		{
			ret = default(Quaternion);
		}
	}
}
