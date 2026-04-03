using UnityEngine.Bindings;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Animations
{
	[NativeHeader("Modules/Animation/Director/AnimationSceneHandles.h")]
	[MovedFrom("UnityEngine.Experimental.Animations")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationStreamHandles.bindings.h")]
	public struct TransformSceneHandle
	{
		private uint valid;

		private int transformSceneHandleDefinitionIndex;

		private bool createdByNative => false;

		private bool hasTransformSceneHandleDefinitionIndex => false;

		public bool IsValid(AnimationStream stream)
		{
			return false;
		}

		private void CheckIsValid(ref AnimationStream stream)
		{
		}

		public Vector3 GetPosition(AnimationStream stream)
		{
			return default(Vector3);
		}

		public Vector3 GetLocalPosition(AnimationStream stream)
		{
			return default(Vector3);
		}

		public Quaternion GetRotation(AnimationStream stream)
		{
			return default(Quaternion);
		}

		public Quaternion GetLocalRotation(AnimationStream stream)
		{
			return default(Quaternion);
		}

		public Vector3 GetLocalScale(AnimationStream stream)
		{
			return default(Vector3);
		}

		public void GetLocalTRS(AnimationStream stream, out Vector3 position, out Quaternion rotation, out Vector3 scale)
		{
			position = default(Vector3);
			rotation = default(Quaternion);
			scale = default(Vector3);
		}

		public Matrix4x4 GetLocalToParentMatrix(AnimationStream stream)
		{
			return default(Matrix4x4);
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

		[ThreadSafe]
		private bool HasValidTransform(ref AnimationStream stream)
		{
			return false;
		}

		[NativeMethod(Name = "TransformSceneHandleBindings::GetPositionInternal", IsFreeFunction = true, IsThreadSafe = true, HasExplicitThis = true)]
		private Vector3 GetPositionInternal(ref AnimationStream stream)
		{
			return default(Vector3);
		}

		[NativeMethod(Name = "TransformSceneHandleBindings::GetLocalPositionInternal", IsFreeFunction = true, IsThreadSafe = true, HasExplicitThis = true)]
		private Vector3 GetLocalPositionInternal(ref AnimationStream stream)
		{
			return default(Vector3);
		}

		[NativeMethod(Name = "TransformSceneHandleBindings::GetRotationInternal", IsFreeFunction = true, IsThreadSafe = true, HasExplicitThis = true)]
		private Quaternion GetRotationInternal(ref AnimationStream stream)
		{
			return default(Quaternion);
		}

		[NativeMethod(Name = "TransformSceneHandleBindings::GetLocalRotationInternal", IsFreeFunction = true, IsThreadSafe = true, HasExplicitThis = true)]
		private Quaternion GetLocalRotationInternal(ref AnimationStream stream)
		{
			return default(Quaternion);
		}

		[NativeMethod(Name = "TransformSceneHandleBindings::GetLocalScaleInternal", IsFreeFunction = true, IsThreadSafe = true, HasExplicitThis = true)]
		private Vector3 GetLocalScaleInternal(ref AnimationStream stream)
		{
			return default(Vector3);
		}

		[NativeMethod(Name = "TransformSceneHandleBindings::GetLocalTRSInternal", IsFreeFunction = true, IsThreadSafe = true, HasExplicitThis = true)]
		private void GetLocalTRSInternal(ref AnimationStream stream, out Vector3 position, out Quaternion rotation, out Vector3 scale)
		{
			position = default(Vector3);
			rotation = default(Quaternion);
			scale = default(Vector3);
		}

		[NativeMethod(Name = "TransformSceneHandleBindings::GetLocalToParentMatrixInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private Matrix4x4 GetLocalToParentMatrixInternal(ref AnimationStream stream)
		{
			return default(Matrix4x4);
		}

		[NativeMethod(Name = "TransformSceneHandleBindings::GetGlobalTRInternal", IsFreeFunction = true, IsThreadSafe = true, HasExplicitThis = true)]
		private void GetGlobalTRInternal(ref AnimationStream stream, out Vector3 position, out Quaternion rotation)
		{
			position = default(Vector3);
			rotation = default(Quaternion);
		}

		[NativeMethod(Name = "TransformSceneHandleBindings::GetLocalToWorldMatrixInternal", IsFreeFunction = true, HasExplicitThis = true, IsThreadSafe = true)]
		private Matrix4x4 GetLocalToWorldMatrixInternal(ref AnimationStream stream)
		{
			return default(Matrix4x4);
		}

		private static void GetPositionInternal_Injected(ref TransformSceneHandle _unity_self, ref AnimationStream stream, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private static void GetLocalPositionInternal_Injected(ref TransformSceneHandle _unity_self, ref AnimationStream stream, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private static void GetRotationInternal_Injected(ref TransformSceneHandle _unity_self, ref AnimationStream stream, out Quaternion ret)
		{
			ret = default(Quaternion);
		}

		private static void GetLocalRotationInternal_Injected(ref TransformSceneHandle _unity_self, ref AnimationStream stream, out Quaternion ret)
		{
			ret = default(Quaternion);
		}

		private static void GetLocalScaleInternal_Injected(ref TransformSceneHandle _unity_self, ref AnimationStream stream, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private static void GetLocalToParentMatrixInternal_Injected(ref TransformSceneHandle _unity_self, ref AnimationStream stream, out Matrix4x4 ret)
		{
			ret = default(Matrix4x4);
		}

		private static void GetLocalToWorldMatrixInternal_Injected(ref TransformSceneHandle _unity_self, ref AnimationStream stream, out Matrix4x4 ret)
		{
			ret = default(Matrix4x4);
		}
	}
}
