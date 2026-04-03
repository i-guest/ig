using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Runtime/Math/MathScripting.h")]
	[Il2CppEagerStaticClassConstruction]
	[NativeClass("Matrix4x4f")]
	[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
	[NativeType(Header = "Runtime/Math/Matrix4x4.h")]
	public struct Matrix4x4 : IEquatable<Matrix4x4>, IFormattable
	{
		[NativeName("m_Data[0]")]
		public float m00;

		[NativeName("m_Data[1]")]
		public float m10;

		[NativeName("m_Data[2]")]
		public float m20;

		[NativeName("m_Data[3]")]
		public float m30;

		[NativeName("m_Data[4]")]
		public float m01;

		[NativeName("m_Data[5]")]
		public float m11;

		[NativeName("m_Data[6]")]
		public float m21;

		[NativeName("m_Data[7]")]
		public float m31;

		[NativeName("m_Data[8]")]
		public float m02;

		[NativeName("m_Data[9]")]
		public float m12;

		[NativeName("m_Data[10]")]
		public float m22;

		[NativeName("m_Data[11]")]
		public float m32;

		[NativeName("m_Data[12]")]
		public float m03;

		[NativeName("m_Data[13]")]
		public float m13;

		[NativeName("m_Data[14]")]
		public float m23;

		[NativeName("m_Data[15]")]
		public float m33;

		private static readonly Matrix4x4 zeroMatrix;

		private static readonly Matrix4x4 identityMatrix;

		public readonly Quaternion rotation
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(Quaternion);
			}
		}

		public readonly Vector3 lossyScale
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(Vector3);
			}
		}

		public readonly bool isIdentity
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return false;
			}
		}

		public readonly FrustumPlanes decomposeProjection
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(FrustumPlanes);
			}
		}

		public readonly Matrix4x4 inverse
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(Matrix4x4);
			}
		}

		public readonly Matrix4x4 transpose
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(Matrix4x4);
			}
		}

		public float this[int row, int column]
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

		public static Matrix4x4 zero
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(Matrix4x4);
			}
		}

		public static Matrix4x4 identity
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(Matrix4x4);
			}
		}

		[ThreadSafe]
		private readonly Quaternion GetRotation()
		{
			return default(Quaternion);
		}

		[ThreadSafe]
		private readonly Vector3 GetLossyScale()
		{
			return default(Vector3);
		}

		[ThreadSafe]
		private readonly bool IsIdentity()
		{
			return false;
		}

		[ThreadSafe]
		private readonly FrustumPlanes DecomposeProjection()
		{
			return default(FrustumPlanes);
		}

		[FreeFunction("MatrixScripting::TRS", IsThreadSafe = true)]
		private static Matrix4x4 Internal_TRS(in Vector3 pos, in Quaternion q, in Vector3 s)
		{
			return default(Matrix4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Matrix4x4 TRS(Vector3 pos, Quaternion q, Vector3 s)
		{
			return default(Matrix4x4);
		}

		[FreeFunction("MatrixScripting::SetTRS", IsThreadSafe = true)]
		private static void Internal_SetTRS(ref Matrix4x4 m, in Vector3 pos, in Quaternion q, in Vector3 s)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void SetTRS(Vector3 pos, Quaternion q, Vector3 s)
		{
		}

		[FreeFunction("MatrixScripting::Inverse3DAffine", IsThreadSafe = true)]
		private static bool Internal_Inverse3DAffine(in Matrix4x4 input, ref Matrix4x4 result)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool Inverse3DAffine(Matrix4x4 input, ref Matrix4x4 result)
		{
			return false;
		}

		[FreeFunction("MatrixScripting::Inverse", IsThreadSafe = true)]
		private static Matrix4x4 Internal_Inverse(in Matrix4x4 m)
		{
			return default(Matrix4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Matrix4x4 Inverse(Matrix4x4 m)
		{
			return default(Matrix4x4);
		}

		[FreeFunction("MatrixScripting::Transpose", IsThreadSafe = true)]
		private static Matrix4x4 Internal_Transpose(in Matrix4x4 m)
		{
			return default(Matrix4x4);
		}

		[FreeFunction("MatrixScripting::Ortho", IsThreadSafe = true)]
		public static Matrix4x4 Ortho(float left, float right, float bottom, float top, float zNear, float zFar)
		{
			return default(Matrix4x4);
		}

		[FreeFunction("MatrixScripting::Perspective", IsThreadSafe = true)]
		public static Matrix4x4 Perspective(float fov, float aspect, float zNear, float zFar)
		{
			return default(Matrix4x4);
		}

		[FreeFunction("MatrixScripting::LookAt", IsThreadSafe = true)]
		private static Matrix4x4 Internal_LookAt(in Vector3 from, in Vector3 to, in Vector3 up)
		{
			return default(Matrix4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Matrix4x4 LookAt(Vector3 from, Vector3 to, Vector3 up)
		{
			return default(Matrix4x4);
		}

		[FreeFunction("MatrixScripting::Frustum", IsThreadSafe = true)]
		public static Matrix4x4 Frustum(float left, float right, float bottom, float top, float zNear, float zFar)
		{
			return default(Matrix4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Matrix4x4 Frustum(FrustumPlanes fp)
		{
			return default(Matrix4x4);
		}

		public Matrix4x4(Vector4 column0, Vector4 column1, Vector4 column2, Vector4 column3)
		{
			m00 = 0f;
			m10 = 0f;
			m20 = 0f;
			m30 = 0f;
			m01 = 0f;
			m11 = 0f;
			m21 = 0f;
			m31 = 0f;
			m02 = 0f;
			m12 = 0f;
			m22 = 0f;
			m32 = 0f;
			m03 = 0f;
			m13 = 0f;
			m23 = 0f;
			m33 = 0f;
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
		public readonly bool Equals(Matrix4x4 other)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly bool Equals(in Matrix4x4 other)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Matrix4x4 operator *(Matrix4x4 lhs, Matrix4x4 rhs)
		{
			return default(Matrix4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 operator *(Matrix4x4 lhs, Vector4 vector)
		{
			return default(Vector4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator ==(Matrix4x4 lhs, Matrix4x4 rhs)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator !=(Matrix4x4 lhs, Matrix4x4 rhs)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly Vector4 GetColumn(int index)
		{
			return default(Vector4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly Vector4 GetRow(int index)
		{
			return default(Vector4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly Vector3 GetPosition()
		{
			return default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void SetColumn(int index, Vector4 column)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void SetRow(int index, Vector4 row)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly Vector3 MultiplyPoint(Vector3 point)
		{
			return default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly Vector3 MultiplyPoint3x4(Vector3 point)
		{
			return default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly Vector3 MultiplyVector(Vector3 vector)
		{
			return default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Matrix4x4 Scale(Vector3 vector)
		{
			return default(Matrix4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Matrix4x4 Translate(Vector3 vector)
		{
			return default(Matrix4x4);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Matrix4x4 Rotate(Quaternion q)
		{
			return default(Matrix4x4);
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

		private static void GetRotation_Injected(ref Matrix4x4 _unity_self, out Quaternion ret)
		{
			ret = default(Quaternion);
		}

		private static void GetLossyScale_Injected(ref Matrix4x4 _unity_self, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private static void DecomposeProjection_Injected(ref Matrix4x4 _unity_self, out FrustumPlanes ret)
		{
			ret = default(FrustumPlanes);
		}

		private static void Internal_TRS_Injected(in Vector3 pos, in Quaternion q, in Vector3 s, out Matrix4x4 ret)
		{
			ret = default(Matrix4x4);
		}

		private static void Internal_Inverse_Injected(in Matrix4x4 m, out Matrix4x4 ret)
		{
			ret = default(Matrix4x4);
		}

		private static void Internal_Transpose_Injected(in Matrix4x4 m, out Matrix4x4 ret)
		{
			ret = default(Matrix4x4);
		}

		private static void Ortho_Injected(float left, float right, float bottom, float top, float zNear, float zFar, out Matrix4x4 ret)
		{
			ret = default(Matrix4x4);
		}

		private static void Perspective_Injected(float fov, float aspect, float zNear, float zFar, out Matrix4x4 ret)
		{
			ret = default(Matrix4x4);
		}

		private static void Internal_LookAt_Injected(in Vector3 from, in Vector3 to, in Vector3 up, out Matrix4x4 ret)
		{
			ret = default(Matrix4x4);
		}

		private static void Frustum_Injected(float left, float right, float bottom, float top, float zNear, float zFar, out Matrix4x4 ret)
		{
			ret = default(Matrix4x4);
		}
	}
}
