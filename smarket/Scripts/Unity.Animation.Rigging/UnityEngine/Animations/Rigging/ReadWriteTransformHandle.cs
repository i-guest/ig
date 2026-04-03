namespace UnityEngine.Animations.Rigging
{
	public struct ReadWriteTransformHandle
	{
		private TransformStreamHandle m_Handle;

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

		public void SetLocalPosition(AnimationStream stream, Vector3 position)
		{
		}

		public void SetLocalRotation(AnimationStream stream, Quaternion rotation)
		{
		}

		public void SetLocalScale(AnimationStream stream, Vector3 scale)
		{
		}

		public void SetLocalTRS(AnimationStream stream, Vector3 position, Quaternion rotation, Vector3 scale, bool useMask = false)
		{
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

		public void SetPosition(AnimationStream stream, Vector3 position)
		{
		}

		public void SetRotation(AnimationStream stream, Quaternion rotation)
		{
		}

		public void SetGlobalTR(AnimationStream stream, Vector3 position, Quaternion rotation, bool useMask = false)
		{
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

		public static ReadWriteTransformHandle Bind(Animator animator, Transform transform)
		{
			return default(ReadWriteTransformHandle);
		}
	}
}
