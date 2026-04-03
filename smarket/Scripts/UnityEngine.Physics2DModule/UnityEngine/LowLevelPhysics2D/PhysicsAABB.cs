using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.LowLevelPhysics2D
{
	[Serializable]
	public struct PhysicsAABB
	{
		[SerializeField]
		private Vector2 m_LowerBound;

		[SerializeField]
		private Vector2 m_UpperBound;

		public readonly bool isValid => false;

		public Vector2 lowerBound
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			readonly get
			{
				return default(Vector2);
			}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		public Vector2 upperBound
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			readonly get
			{
				return default(Vector2);
			}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		public override readonly string ToString()
		{
			return null;
		}
	}
}
