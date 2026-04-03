using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[UsedByNativeCode]
	public readonly struct ContactPair
	{
		private const uint c_InvalidFaceIndex = 4294967295u;

		internal readonly EntityId m_ColliderID;

		internal readonly EntityId m_OtherColliderID;

		internal readonly IntPtr m_StartPtr;

		internal readonly uint m_NbPoints;

		internal readonly CollisionPairFlags m_Flags;

		internal readonly CollisionPairEventFlags m_Events;

		internal readonly Vector3 m_ImpulseSum;

		public Collider collider => null;

		public Collider otherCollider => null;

		public bool isCollisionEnter => false;

		public bool isCollisionExit => false;

		public bool isCollisionStay => false;

		internal bool hasRemovedCollider => false;

		internal int ExtractContactsArray(ContactPoint[] managedContainer, bool flipped)
		{
			return 0;
		}

		public ref ContactPairPoint GetContactPoint(int index)
		{
			throw null;
		}

		internal unsafe ContactPairPoint* GetContactPoint_Internal(int index)
		{
			return null;
		}
	}
}
