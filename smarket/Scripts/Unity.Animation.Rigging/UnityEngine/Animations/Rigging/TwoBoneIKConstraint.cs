namespace UnityEngine.Animations.Rigging
{
	[DisallowMultipleComponent]
	[AddComponentMenu("Animation Rigging/Two Bone IK Constraint")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.4/manual/constraints/TwoBoneIKConstraint.html")]
	public class TwoBoneIKConstraint : RigConstraint<TwoBoneIKConstraintJob, TwoBoneIKConstraintData, TwoBoneIKConstraintJobBinder<TwoBoneIKConstraintData>>
	{
		protected override void OnValidate()
		{
		}
	}
}
