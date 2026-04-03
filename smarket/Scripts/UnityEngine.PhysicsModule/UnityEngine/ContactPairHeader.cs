using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[UsedByNativeCode]
	public readonly struct ContactPairHeader
	{
		internal readonly EntityId m_BodyID;

		internal readonly EntityId m_OtherBodyID;

		internal readonly IntPtr m_StartPtr;

		internal readonly uint m_NbPairs;

		internal readonly CollisionPairHeaderFlags m_Flags;

		internal readonly Vector3 m_RelativeVelocity;

		public Component body => null;

		public Component otherBody => null;

		internal bool hasRemovedBody => false;

		public ref ContactPair GetContactPair(int index)
		{
			throw null;
		}

		internal unsafe ContactPair* GetContactPair_Internal(int index)
		{
			return null;
		}
	}
}
