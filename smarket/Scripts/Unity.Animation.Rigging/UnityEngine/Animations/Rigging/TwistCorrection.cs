namespace UnityEngine.Animations.Rigging
{
	[DisallowMultipleComponent]
	[AddComponentMenu("Animation Rigging/Twist Correction")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.4/manual/constraints/TwistCorrection.html")]
	public class TwistCorrection : RigConstraint<TwistCorrectionJob, TwistCorrectionData, TwistCorrectionJobBinder<TwistCorrectionData>>
	{
		protected override void OnValidate()
		{
		}
	}
}
