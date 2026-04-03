using System.Collections.Generic;

namespace UnityEngine.Animations.Rigging
{
	[DisallowMultipleComponent]
	[AddComponentMenu("Animation Rigging/Setup/Rig")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.4/manual/RiggingWorkflow.html#rig-component")]
	public class Rig : MonoBehaviour, IRigEffectorHolder
	{
		[SerializeField]
		[Range(0f, 1f)]
		private float m_Weight;

		[SerializeField]
		private List<RigEffectorData> m_Effectors;

		public float weight
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
