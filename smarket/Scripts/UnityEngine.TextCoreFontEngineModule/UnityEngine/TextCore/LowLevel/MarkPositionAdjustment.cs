using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.TextCore.LowLevel
{
	[Serializable]
	[VisibleToOtherModules(new string[] { "UnityEngine.TextCoreTextEngineModule" })]
	[UsedByNativeCode]
	internal struct MarkPositionAdjustment
	{
		[NativeName("xCoordinate")]
		[SerializeField]
		private float m_XPositionAdjustment;

		[NativeName("yCoordinate")]
		[SerializeField]
		private float m_YPositionAdjustment;

		public float xPositionAdjustment
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float yPositionAdjustment
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}
	}
}
