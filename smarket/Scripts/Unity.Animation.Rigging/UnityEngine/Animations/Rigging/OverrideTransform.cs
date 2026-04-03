namespace UnityEngine.Animations.Rigging
{
	[DisallowMultipleComponent]
	[AddComponentMenu("Animation Rigging/Override Transform")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.4/manual/constraints/OverrideTransform.html")]
	public class OverrideTransform : RigConstraint<OverrideTransformJob, OverrideTransformData, OverrideTransformJobBinder<OverrideTransformData>>
	{
		protected override void OnValidate()
		{
		}
	}
}
