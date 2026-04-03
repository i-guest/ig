namespace UnityEngine.Animations.Rigging
{
	[ExecuteInEditMode]
	[AddComponentMenu("Animation Rigging/Setup/Bone Renderer")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.4/manual/RiggingWorkflow.html#bone-renderer-component")]
	public class BoneRenderer : MonoBehaviour
	{
		public enum BoneShape
		{
			Line = 0,
			Pyramid = 1,
			Box = 2
		}

		public BoneShape boneShape;

		public bool drawBones;

		public bool drawTripods;

		[Range(0.01f, 5f)]
		public float boneSize;

		[Range(0.01f, 5f)]
		public float tripodSize;

		public Color boneColor;

		[SerializeField]
		private Transform[] m_Transforms;

		public Transform[] transforms => null;
	}
}
