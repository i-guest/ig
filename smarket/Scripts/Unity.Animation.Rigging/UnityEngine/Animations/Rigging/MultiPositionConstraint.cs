namespace UnityEngine.Animations.Rigging
{
	[DisallowMultipleComponent]
	[AddComponentMenu("Animation Rigging/Multi-Position Constraint")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.4/manual/constraints/MultiPositionConstraint.html")]
	public class MultiPositionConstraint : RigConstraint<MultiPositionConstraintJob, MultiPositionConstraintData, MultiPositionConstraintJobBinder<MultiPositionConstraintData>>
	{
		protected override void OnValidate()
		{
		}
	}
}
