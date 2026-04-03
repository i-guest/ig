namespace UnityEngine.Animations.Rigging
{
	[DisallowMultipleComponent]
	[AddComponentMenu("Animation Rigging/Multi-Parent Constraint")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.4/manual/constraints/MultiParentConstraint.html")]
	public class MultiParentConstraint : RigConstraint<MultiParentConstraintJob, MultiParentConstraintData, MultiParentConstraintJobBinder<MultiParentConstraintData>>
	{
		protected override void OnValidate()
		{
		}
	}
}
