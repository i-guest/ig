using System.Runtime.CompilerServices;

namespace UnityEngine.InputSystem.Controls
{
	public class ButtonControl : AxisControl
	{
		private bool m_NeedsToCheckFramePress;

		private uint m_UpdateCountLastPressed;

		private uint m_UpdateCountLastReleased;

		private bool m_LastUpdateWasPress;

		public float pressPoint;

		internal static float s_GlobalDefaultButtonPressPoint;

		internal static float s_GlobalDefaultButtonReleaseThreshold;

		internal const float kMinButtonPressPoint = 0.0001f;

		internal bool needsToCheckFramePress { get; private set; }

		public float pressPointOrDefault => 0f;

		public bool isPressed => false;

		public bool wasPressedThisFrame => false;

		public bool wasReleasedThisFrame => false;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public new bool IsValueConsideredPressed(float value)
		{
			return false;
		}

		private void BeginTestingForFramePresses(bool currentlyPressed, bool pressedLastFrame)
		{
		}

		internal void UpdateWasPressed()
		{
		}
	}
}
