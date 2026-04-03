using System;
using UnityEngine.Bindings;

namespace UnityEngine.Jobs
{
	[NativeHeader("Runtime/Transform/ScriptBindings/TransformAccess.bindings.h")]
	public struct TransformAccess
	{
		private IntPtr hierarchy;

		private int index;

		public Vector3 position
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Quaternion rotation => default(Quaternion);

		public Quaternion localRotation
		{
			set
			{
			}
		}

		public Vector3 localScale => default(Vector3);

		public Matrix4x4 localToWorldMatrix => default(Matrix4x4);

		public bool isValid => false;

		public void SetPositionAndRotation(Vector3 position, Quaternion rotation)
		{
		}

		[NativeMethod(Name = "TransformAccessBindings::SetPositionAndRotation", IsThreadSafe = true, IsFreeFunction = true, ThrowsException = true)]
		private static void SetPositionAndRotation_Internal(ref TransformAccess access, ref Vector3 position, ref Quaternion rotation)
		{
		}

		[NativeMethod(Name = "TransformAccessBindings::GetPosition", IsThreadSafe = true, IsFreeFunction = true, ThrowsException = true)]
		private static void GetPosition(ref TransformAccess access, out Vector3 p)
		{
			p = default(Vector3);
		}

		[NativeMethod(Name = "TransformAccessBindings::SetPosition", IsThreadSafe = true, IsFreeFunction = true, ThrowsException = true)]
		private static void SetPosition(ref TransformAccess access, ref Vector3 p)
		{
		}

		[NativeMethod(Name = "TransformAccessBindings::GetRotation", IsThreadSafe = true, IsFreeFunction = true, ThrowsException = true)]
		private static void GetRotation(ref TransformAccess access, out Quaternion r)
		{
			r = default(Quaternion);
		}

		[NativeMethod(Name = "TransformAccessBindings::SetLocalRotation", IsThreadSafe = true, IsFreeFunction = true, ThrowsException = true)]
		private static void SetLocalRotation(ref TransformAccess access, ref Quaternion r)
		{
		}

		[NativeMethod(Name = "TransformAccessBindings::GetLocalScale", IsThreadSafe = true, IsFreeFunction = true, ThrowsException = true)]
		private static void GetLocalScale(ref TransformAccess access, out Vector3 r)
		{
			r = default(Vector3);
		}

		[NativeMethod(Name = "TransformAccessBindings::GetLocalToWorldMatrix", IsThreadSafe = true, IsFreeFunction = true, ThrowsException = true)]
		private static void GetLocalToWorldMatrix(ref TransformAccess access, out Matrix4x4 m)
		{
			m = default(Matrix4x4);
		}
	}
}
