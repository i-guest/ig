namespace UnityEngine.Animations.Rigging
{
	[DisallowMultipleComponent]
	[AddComponentMenu("Animation Rigging/Damped Transform")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.4/manual/constraints/DampedTransform.html")]
	public class DampedTransform : RigConstraint<DampedTransformJob, DampedTransformData, DampedTransformJobBinder<DampedTransformData>>
	{
		protected override void OnValidate()
		{
		}
	}
}
