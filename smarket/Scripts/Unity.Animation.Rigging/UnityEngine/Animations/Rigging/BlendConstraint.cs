namespace UnityEngine.Animations.Rigging
{
	[DisallowMultipleComponent]
	[AddComponentMenu("Animation Rigging/Blend Constraint")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.4/manual/constraints/BlendConstraint.html")]
	public class BlendConstraint : RigConstraint<BlendConstraintJob, BlendConstraintData, BlendConstraintJobBinder<BlendConstraintData>>
	{
		protected override void OnValidate()
		{
		}
	}
}
