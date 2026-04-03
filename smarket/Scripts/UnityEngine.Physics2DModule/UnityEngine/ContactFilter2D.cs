using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[Serializable]
	[NativeClass("ContactFilter", "struct ContactFilter;")]
	[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
	[NativeHeader("Modules/Physics2D/Public/Collider2D.h")]
	public struct ContactFilter2D
	{
		private static ContactFilter2D _noFilter;

		[NativeName("m_UseTriggers")]
		public bool useTriggers;

		[NativeName("m_UseLayerMask")]
		public bool useLayerMask;

		[NativeName("m_UseDepth")]
		public bool useDepth;

		[NativeName("m_UseOutsideDepth")]
		public bool useOutsideDepth;

		[NativeName("m_UseNormalAngle")]
		public bool useNormalAngle;

		[NativeName("m_UseOutsideNormalAngle")]
		public bool useOutsideNormalAngle;

		[NativeName("m_LayerMask")]
		public LayerMask layerMask;

		[NativeName("m_MinDepth")]
		public float minDepth;

		[NativeName("m_MaxDepth")]
		public float maxDepth;

		[NativeName("m_MinNormalAngle")]
		public float minNormalAngle;

		[NativeName("m_MaxNormalAngle")]
		public float maxNormalAngle;

		public const float NormalAngleUpperLimit = 359.9999f;

		private void CheckConsistency()
		{
		}

		public void SetLayerMask(LayerMask layerMask)
		{
		}

		public void SetDepth(float minDepth, float maxDepth)
		{
		}

		internal static ContactFilter2D CreateLegacyFilter(int layerMask, float minDepth, float maxDepth)
		{
			return default(ContactFilter2D);
		}
	}
}
