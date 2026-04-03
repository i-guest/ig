namespace UnityEngine.Animations.Rigging
{
	public struct ReadOnlyTransformHandle
	{
		private TransformStreamHandle m_StreamHandle;

		private TransformSceneHandle m_SceneHandle;

		private byte m_InStream;

		public Vector3 GetLocalPosition(AnimationStream stream)
		{
			return default(Vector3);
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

		public Vector3 GetPosition(AnimationStream stream)
		{
			return default(Vector3);
		}

		public Quaternion GetRotation(AnimationStream stream)
		{
			return default(Quaternion);
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

		public bool IsResolved(AnimationStream stream)
		{
			return false;
		}

		public bool IsValid(AnimationStream stream)
		{
			return false;
		}

		public void Resolve(AnimationStream stream)
		{
		}

		public static ReadOnlyTransformHandle Bind(Animator animator, Transform transform)
		{
			return default(ReadOnlyTransformHandle);
		}
	}
}
