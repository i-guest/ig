namespace UnityEngine.Animations.Rigging
{
	[DisallowMultipleComponent]
	[AddComponentMenu("Animation Rigging/Multi-Aim Constraint")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.4/manual/constraints/MultiAimConstraint.html")]
	public class MultiAimConstraint : RigConstraint<MultiAimConstraintJob, MultiAimConstraintData, MultiAimConstraintJobBinder<MultiAimConstraintData>>
	{
		protected override void OnValidate()
		{
		}
	}
}
