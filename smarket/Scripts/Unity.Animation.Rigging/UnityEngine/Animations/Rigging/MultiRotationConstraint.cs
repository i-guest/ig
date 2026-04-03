namespace UnityEngine.Animations.Rigging
{
	[DisallowMultipleComponent]
	[AddComponentMenu("Animation Rigging/Multi-Rotation Constraint")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.4/manual/constraints/MultiRotationConstraint.html")]
	public class MultiRotationConstraint : RigConstraint<MultiRotationConstraintJob, MultiRotationConstraintData, MultiRotationConstraintJobBinder<MultiRotationConstraintData>>
	{
		protected override void OnValidate()
		{
		}
	}
}
