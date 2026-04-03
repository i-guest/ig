namespace UnityEngine
{
	public struct ContactPoint
	{
		internal Vector3 m_Point;

		internal Vector3 m_Normal;

		internal Vector3 m_Impulse;

		internal EntityId m_ThisColliderEntityId;

		internal EntityId m_OtherColliderEntityId;

		internal float m_Separation;

		public Vector3 point => default(Vector3);

		public Vector3 normal => default(Vector3);
	}
}
