using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Animations
{
	[NativeHeader("Modules/Animation/Director/AnimationStreamHandles.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationStreamHandles.bindings.h")]
	[MovedFrom("UnityEngine.Experimental.Animations")]
	public struct TransformStreamHandle
	{
		private uint m_AnimatorBindingsVersion;

		private int handleIndex;

		private int skeletonIndex;

		private bool createdByNative => false;

		private bool hasHandleIndex => false;

		private bool hasSkeletonIndex => false;

		internal uint animatorBindingsVersion => 0u;

		public bool IsValid(AnimationStream stream)
		{
			return false;
		}

		private bool IsValidInternal(ref AnimationStream stream)
		{
			return false;
		}

		private bool IsSameVersionAsStream(ref AnimationStream stream)
		{
			return false;
		}

		public void Resolve(AnimationStream stream)
		{
		}

		public bool IsResolved(AnimationStream stream)
		{
			return false;
		}

		private bool IsResolvedInternal(ref AnimationStream stream)
		{
			return false;
		}

		private void CheckIsValidAndResolve(ref AnimationStream stream)
		{
		}

		public Vector3 GetPosition(AnimationStream stream)
		{
			return default(Vector3);
		}

		public void SetPosition(AnimationStream stream, Vector3 position)
		{
		}

		public Quaternion GetRotation(AnimationStream stream)
		{
			return default(Quaternion);
		}

		public void SetRotation(AnimationStream stream, Quaternion rotation)
		{
		}

		public Vector3 GetLocalPosition(AnimationStream stream)
		{
			return default(Vector3);
		}

		public void SetLocalPosition(AnimationStream stream, Vector3 position)
		{
		}

		public Quaternion GetLocalRotation(AnimationStream stream)
		{
			return default(Quaternion);
		}

		public void SetLocalRotation(AnimationStream stream, Quaternion rotation)
		{
		}

		public Vector3 GetLocalScale(AnimationStream stream)
		{
			return default(Vector3);
		}

		public void SetLocalScale(AnimationStream stream, Vector3 scale)
		{
		}

		public Matrix4x4 GetLocalToParentMatrix(AnimationStream stream)
		{
			return default(Matrix4x4);
		}

		public void GetLocalTRS(AnimationStream stream, out Vector3 position, out Quaternion rotation, out Vector3 scale)
		{
			position = default(Vector3);
			rotation = default(Quaternion);
			scale = default(Vector3);
		}

		public void SetLocalTRS(AnimationStream stream, Vector3 position, Quaternion rotation, Vector3 scale, bool useMask)
		{
		}

		public void GetGlobalTR(AnimationStream stream, out Vector3 position, out Quaternion rotation)
		{
			position = default(Vector3);
			rotation = default(Quaternion);
		}

		public Matrix4x4 GetLocalToWorldMatrix(AnimationStream stream)
		{
			return default(Matrix4x4);
		}

		public void SetGlobalTR(AnimationStream stream, Vector3 position, Quaternion rotation, bool useMask)
		{
		}

		[NativeMethod(Name = "Resolve", IsThreadSafe = true)]
		private void ResolveInternal(ref AnimationStream stream)
		{
		}

		[NativeMethod(Name = "TransformStreamHandleBindings::GetPositionInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private Vector3 GetPositionInternal(ref AnimationStream stream)
		{
			return default(Vector3);
		}

		[NativeMethod(Name = "TransformStreamHandleBindings::SetPositionInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private void SetPositionInternal(ref AnimationStream stream, Vector3 position)
		{
		}

		[NativeMethod(Name = "TransformStreamHandleBindings::GetRotationInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private Quaternion GetRotationInternal(ref AnimationStream stream)
		{
			return default(Quaternion);
		}

		[NativeMethod(Name = "TransformStreamHandleBindings::SetRotationInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private void SetRotationInternal(ref AnimationStream stream, Quaternion rotation)
		{
		}

		[NativeMethod(Name = "TransformStreamHandleBindings::GetLocalPositionInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private Vector3 GetLocalPositionInternal(ref AnimationStream stream)
		{
			return default(Vector3);
		}

		[NativeMethod(Name = "TransformStreamHandleBindings::SetLocalPositionInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private void SetLocalPositionInternal(ref AnimationStream stream, Vector3 position)
		{
		}

		[NativeMethod(Name = "TransformStreamHandleBindings::GetLocalRotationInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private Quaternion GetLocalRotationInternal(ref AnimationStream stream)
		{
			return default(Quaternion);
		}

		[NativeMethod(Name = "TransformStreamHandleBindings::SetLocalRotationInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private void SetLocalRotationInternal(ref AnimationStream stream, Quaternion rotation)
		{
		}

		[NativeMethod(Name = "TransformStreamHandleBindings::GetLocalScaleInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private Vector3 GetLocalScaleInternal(ref AnimationStream stream)
		{
			return default(Vector3);
		}

		[NativeMethod(Name = "TransformStreamHandleBindings::SetLocalScaleInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private void SetLocalScaleInternal(ref AnimationStream stream, Vector3 scale)
		{
		}

		[NativeMethod(Name = "TransformStreamHandleBindings::GetLocalToParentMatrixInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private Matrix4x4 GetLocalToParentMatrixInternal(ref AnimationStream stream)
		{
			return default(Matrix4x4);
		}

		[NativeMethod(Name = "TransformStreamHandleBindings::GetLocalTRSInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private void GetLocalTRSInternal(ref AnimationStream stream, out Vector3 position, out Quaternion rotation, out Vector3 scale)
		{
			position = default(Vector3);
			rotation = default(Quaternion);
			scale = default(Vector3);
		}

		[NativeMethod(Name = "TransformStreamHandleBindings::SetLocalTRSInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private void SetLocalTRSInternal(ref AnimationStream stream, Vector3 position, Quaternion rotation, Vector3 scale, bool useMask)
		{
		}

		[NativeMethod(Name = "TransformStreamHandleBindings::GetGlobalTRInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private void GetGlobalTRInternal(ref AnimationStream stream, out Vector3 position, out Quaternion rotation)
		{
			position = default(Vector3);
			rotation = default(Quaternion);
		}

		[NativeMethod(Name = "TransformStreamHandleBindings::GetLocalToWorldMatrixInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private Matrix4x4 GetLocalToWorldMatrixInternal(ref AnimationStream stream)
		{
			return default(Matrix4x4);
		}

		[NativeMethod(Name = "TransformStreamHandleBindings::SetGlobalTRInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private void SetGlobalTRInternal(ref AnimationStream stream, Vector3 position, Quaternion rotation, bool useMask)
		{
		}

		private static void GetPositionInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private static void SetPositionInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, [In] ref Vector3 position)
		{
		}

		private static void GetRotationInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, out Quaternion ret)
		{
			ret = default(Quaternion);
		}

		private static void SetRotationInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, [In] ref Quaternion rotation)
		{
		}

		private static void GetLocalPositionInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private static void SetLocalPositionInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, [In] ref Vector3 position)
		{
		}

		private static void GetLocalRotationInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, out Quaternion ret)
		{
			ret = default(Quaternion);
		}

		private static void SetLocalRotationInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, [In] ref Quaternion rotation)
		{
		}

		private static void GetLocalScaleInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private static void SetLocalScaleInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, [In] ref Vector3 scale)
		{
		}

		private static void GetLocalToParentMatrixInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, out Matrix4x4 ret)
		{
			ret = default(Matrix4x4);
		}

		private static void SetLocalTRSInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, [In] ref Vector3 position, [In] ref Quaternion rotation, [In] ref Vector3 scale, bool useMask)
		{
		}

		private static void GetLocalToWorldMatrixInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, out Matrix4x4 ret)
		{
			ret = default(Matrix4x4);
		}

		private static void SetGlobalTRInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, [In] ref Vector3 position, [In] ref Quaternion rotation, bool useMask)
		{
		}
	}
}
