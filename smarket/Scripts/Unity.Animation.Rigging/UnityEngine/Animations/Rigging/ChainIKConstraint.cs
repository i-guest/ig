namespace UnityEngine.Animations.Rigging
{
	[DisallowMultipleComponent]
	[AddComponentMenu("Animation Rigging/Chain IK Constraint")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.4/manual/constraints/ChainIKConstraint.html")]
	public class ChainIKConstraint : RigConstraint<ChainIKConstraintJob, ChainIKConstraintData, ChainIKConstraintJobBinder<ChainIKConstraintData>>
	{
		protected override void OnValidate()
		{
		}
	}
}
