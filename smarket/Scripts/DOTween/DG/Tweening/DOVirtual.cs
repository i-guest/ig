using UnityEngine;

namespace DG.Tweening
{
	public static class DOVirtual
	{
		public static Tweener Float(float from, float to, float duration, TweenCallback<float> onVirtualUpdate)
		{
			return null;
		}

		public static Tweener Int(int from, int to, float duration, TweenCallback<int> onVirtualUpdate)
		{
			return null;
		}

		public static Tweener Vector2(Vector2 from, Vector2 to, float duration, TweenCallback<Vector2> onVirtualUpdate)
		{
			return null;
		}

		public static Tweener Vector3(Vector3 from, Vector3 to, float duration, TweenCallback<Vector3> onVirtualUpdate)
		{
			return null;
		}

		public static Tweener Color(Color from, Color to, float duration, TweenCallback<Color> onVirtualUpdate)
		{
			return null;
		}

		public static float EasedValue(float from, float to, float lifetimePercentage, Ease easeType)
		{
			return 0f;
		}

		public static float EasedValue(float from, float to, float lifetimePercentage, Ease easeType, float overshoot)
		{
			return 0f;
		}

		public static float EasedValue(float from, float to, float lifetimePercentage, Ease easeType, float amplitude, float period)
		{
			return 0f;
		}

		public static float EasedValue(float from, float to, float lifetimePercentage, AnimationCurve easeCurve)
		{
			return 0f;
		}

		public static Vector3 EasedValue(Vector3 from, Vector3 to, float lifetimePercentage, Ease easeType)
		{
			return default(Vector3);
		}

		public static Vector3 EasedValue(Vector3 from, Vector3 to, float lifetimePercentage, Ease easeType, float overshoot)
		{
			return default(Vector3);
		}

		public static Vector3 EasedValue(Vector3 from, Vector3 to, float lifetimePercentage, Ease easeType, float amplitude, float period)
		{
			return default(Vector3);
		}

		public static Vector3 EasedValue(Vector3 from, Vector3 to, float lifetimePercentage, AnimationCurve easeCurve)
		{
			return default(Vector3);
		}

		public static Tween DelayedCall(float delay, TweenCallback callback, bool ignoreTimeScale = true)
		{
			return null;
		}
	}
}
