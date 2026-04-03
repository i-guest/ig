using UnityEngine.Scripting;

namespace UnityEngine
{
	[UsedByNativeCode]
	public readonly struct ContactPairPoint
	{
		internal readonly Vector3 m_Position;

		internal readonly float m_Separation;

		internal readonly Vector3 m_Normal;

		internal readonly uint m_InternalFaceIndex0;

		internal readonly Vector3 m_Impulse;

		internal readonly uint m_InternalFaceIndex1;

		public Vector3 position => default(Vector3);

		public float separation => 0f;

		public Vector3 normal => default(Vector3);

		public Vector3 impulse => default(Vector3);
	}
}
