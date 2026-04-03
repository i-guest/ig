using DG.Tweening.Core;
using DG.Tweening.Plugins;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace DG.Tweening
{
	public static class TweenSettingsExtensions
	{
		public static T SetAutoKill<T>(this T t)
		{
			return default(T);
		}

		public static T SetAutoKill<T>(this T t, bool autoKillOnCompletion)
		{
			return default(T);
		}

		public static T SetId<T>(this T t, object objectId)
		{
			return default(T);
		}

		public static T SetId<T>(this T t, string stringId)
		{
			return default(T);
		}

		public static T SetId<T>(this T t, int intId)
		{
			return default(T);
		}

		public static T SetLink<T>(this T t, GameObject gameObject)
		{
			return default(T);
		}

		public static T SetLink<T>(this T t, GameObject gameObject, LinkBehaviour behaviour)
		{
			return default(T);
		}

		public static T SetTarget<T>(this T t, object target)
		{
			return default(T);
		}

		public static T SetLoops<T>(this T t, int loops)
		{
			return default(T);
		}

		public static T SetLoops<T>(this T t, int loops, LoopType loopType)
		{
			return default(T);
		}

		public static T SetEase<T>(this T t, Ease ease)
		{
			return default(T);
		}

		public static T SetEase<T>(this T t, Ease ease, float overshoot)
		{
			return default(T);
		}

		public static T SetEase<T>(this T t, Ease ease, float amplitude, float period)
		{
			return default(T);
		}

		public static T SetEase<T>(this T t, AnimationCurve animCurve)
		{
			return default(T);
		}

		public static T SetEase<T>(this T t, EaseFunction customEase)
		{
			return default(T);
		}

		public static T SetRecyclable<T>(this T t)
		{
			return default(T);
		}

		public static T SetRecyclable<T>(this T t, bool recyclable)
		{
			return default(T);
		}

		public static T SetUpdate<T>(this T t, bool isIndependentUpdate)
		{
			return default(T);
		}

		public static T SetUpdate<T>(this T t, UpdateType updateType)
		{
			return default(T);
		}

		public static T SetUpdate<T>(this T t, UpdateType updateType, bool isIndependentUpdate)
		{
			return default(T);
		}

		public static T SetInverted<T>(this T t)
		{
			return default(T);
		}

		public static T SetInverted<T>(this T t, bool inverted)
		{
			return default(T);
		}

		public static T OnStart<T>(this T t, TweenCallback action)
		{
			return default(T);
		}

		public static T OnPlay<T>(this T t, TweenCallback action)
		{
			return default(T);
		}

		public static T OnPause<T>(this T t, TweenCallback action)
		{
			return default(T);
		}

		public static T OnRewind<T>(this T t, TweenCallback action)
		{
			return default(T);
		}

		public static T OnUpdate<T>(this T t, TweenCallback action)
		{
			return default(T);
		}

		public static T OnStepComplete<T>(this T t, TweenCallback action)
		{
			return default(T);
		}

		public static T OnComplete<T>(this T t, TweenCallback action)
		{
			return default(T);
		}

		public static T OnKill<T>(this T t, TweenCallback action)
		{
			return default(T);
		}

		public static T OnWaypointChange<T>(this T t, TweenCallback<int> action)
		{
			return default(T);
		}

		public static T SetAs<T>(this T t, Tween asTween)
		{
			return default(T);
		}

		public static T SetAs<T>(this T t, TweenParams tweenParams)
		{
			return default(T);
		}

		public static Sequence Append(this Sequence s, Tween t)
		{
			return null;
		}

		public static Sequence Prepend(this Sequence s, Tween t)
		{
			return null;
		}

		public static Sequence Join(this Sequence s, Tween t)
		{
			return null;
		}

		public static Sequence Insert(this Sequence s, float atPosition, Tween t)
		{
			return null;
		}

		public static Sequence AppendInterval(this Sequence s, float interval)
		{
			return null;
		}

		public static Sequence PrependInterval(this Sequence s, float interval)
		{
			return null;
		}

		public static Sequence AppendCallback(this Sequence s, TweenCallback callback)
		{
			return null;
		}

		public static Sequence PrependCallback(this Sequence s, TweenCallback callback)
		{
			return null;
		}

		public static Sequence InsertCallback(this Sequence s, float atPosition, TweenCallback callback)
		{
			return null;
		}

		private static bool ValidateAddToSequence(Sequence s, Tween t, bool ignoreTween = false)
		{
			return false;
		}

		public static T From<T>(this T t)
		{
			return default(T);
		}

		public static T From<T>(this T t, bool isRelative)
		{
			return default(T);
		}

		public static T From<T>(this T t, bool setImmediately, bool isRelative)
		{
			return default(T);
		}

		public static TweenerCore<T1, T2, TPlugOptions> From<T1, T2, TPlugOptions>(this TweenerCore<T1, T2, TPlugOptions> t, T2 fromValue, bool setImmediately = true, bool isRelative = false) where TPlugOptions : struct
		{
			return null;
		}

		public static TweenerCore<Color, Color, ColorOptions> From(this TweenerCore<Color, Color, ColorOptions> t, float fromAlphaValue, bool setImmediately = true, bool isRelative = false)
		{
			return null;
		}

		public static TweenerCore<Vector3, Vector3, VectorOptions> From(this TweenerCore<Vector3, Vector3, VectorOptions> t, float fromValue, bool setImmediately = true, bool isRelative = false)
		{
			return null;
		}

		public static TweenerCore<Vector2, Vector2, CircleOptions> From(this TweenerCore<Vector2, Vector2, CircleOptions> t, float fromValueDegrees, bool setImmediately = true, bool isRelative = false)
		{
			return null;
		}

		public static T SetDelay<T>(this T t, float delay)
		{
			return default(T);
		}

		public static T SetDelay<T>(this T t, float delay, bool asPrependedIntervalIfSequence)
		{
			return default(T);
		}

		public static T SetRelative<T>(this T t)
		{
			return default(T);
		}

		public static T SetRelative<T>(this T t, bool isRelative)
		{
			return default(T);
		}

		public static T SetSpeedBased<T>(this T t)
		{
			return default(T);
		}

		public static T SetSpeedBased<T>(this T t, bool isSpeedBased)
		{
			return default(T);
		}

		public static Tweener SetOptions(this TweenerCore<float, float, FloatOptions> t, bool snapping)
		{
			return null;
		}

		public static Tweener SetOptions(this TweenerCore<Vector2, Vector2, VectorOptions> t, bool snapping)
		{
			return null;
		}

		public static Tweener SetOptions(this TweenerCore<Vector2, Vector2, VectorOptions> t, AxisConstraint axisConstraint, bool snapping = false)
		{
			return null;
		}

		public static Tweener SetOptions(this TweenerCore<Vector3, Vector3, VectorOptions> t, bool snapping)
		{
			return null;
		}

		public static Tweener SetOptions(this TweenerCore<Vector3, Vector3, VectorOptions> t, AxisConstraint axisConstraint, bool snapping = false)
		{
			return null;
		}

		public static Tweener SetOptions(this TweenerCore<Vector4, Vector4, VectorOptions> t, bool snapping)
		{
			return null;
		}

		public static Tweener SetOptions(this TweenerCore<Vector4, Vector4, VectorOptions> t, AxisConstraint axisConstraint, bool snapping = false)
		{
			return null;
		}

		public static Tweener SetOptions(this TweenerCore<Quaternion, Vector3, QuaternionOptions> t, bool useShortest360Route = true)
		{
			return null;
		}

		public static Tweener SetOptions(this TweenerCore<Color, Color, ColorOptions> t, bool alphaOnly)
		{
			return null;
		}

		public static Tweener SetOptions(this TweenerCore<Rect, Rect, RectOptions> t, bool snapping)
		{
			return null;
		}

		public static Tweener SetOptions(this TweenerCore<string, string, StringOptions> t, bool richTextEnabled, ScrambleMode scrambleMode = ScrambleMode.None, string scrambleChars = null)
		{
			return null;
		}

		public static Tweener SetOptions(this TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, bool snapping)
		{
			return null;
		}

		public static Tweener SetOptions(this TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, AxisConstraint axisConstraint, bool snapping = false)
		{
			return null;
		}

		public static Tweener SetOptions(this TweenerCore<Vector2, Vector2, CircleOptions> t, float endValueDegrees, bool relativeCenter = true, bool snapping = false)
		{
			return null;
		}

		public static TweenerCore<Vector3, Path, PathOptions> SetOptions(this TweenerCore<Vector3, Path, PathOptions> t, AxisConstraint lockPosition, AxisConstraint lockRotation = AxisConstraint.None)
		{
			return null;
		}

		public static TweenerCore<Vector3, Path, PathOptions> SetOptions(this TweenerCore<Vector3, Path, PathOptions> t, bool closePath, AxisConstraint lockPosition = AxisConstraint.None, AxisConstraint lockRotation = AxisConstraint.None)
		{
			return null;
		}

		public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, Vector3 lookAtPosition, Vector3? forwardDirection = null, Vector3? up = null)
		{
			return null;
		}

		public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, Vector3 lookAtPosition, bool stableZRotation)
		{
			return null;
		}

		public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, Transform lookAtTransform, Vector3? forwardDirection = null, Vector3? up = null)
		{
			return null;
		}

		public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, Transform lookAtTransform, bool stableZRotation)
		{
			return null;
		}

		public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, float lookAhead, Vector3? forwardDirection = null, Vector3? up = null)
		{
			return null;
		}

		public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, float lookAhead, bool stableZRotation)
		{
			return null;
		}

		private static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, OrientType orientType, Vector3 lookAtPosition, Transform lookAtTransform, float lookAhead, Vector3? forwardDirection = null, Vector3? up = null, bool stableZRotation = false)
		{
			return null;
		}

		private static void SetPathForwardDirection(this TweenerCore<Vector3, Path, PathOptions> t, Vector3? forwardDirection = null, Vector3? up = null)
		{
		}
	}
}
