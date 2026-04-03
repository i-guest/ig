using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using UnityEngine;

namespace DG.Tweening.Plugins
{
	public class CirclePlugin : ABSTweenPlugin<Vector2, Vector2, CircleOptions>
	{
		public override void Reset(TweenerCore<Vector2, Vector2, CircleOptions> t)
		{
		}

		public override void SetFrom(TweenerCore<Vector2, Vector2, CircleOptions> t, bool isRelative)
		{
		}

		public override void SetFrom(TweenerCore<Vector2, Vector2, CircleOptions> t, Vector2 fromValue, bool setImmediately, bool isRelative)
		{
		}

		public static ABSTweenPlugin<Vector2, Vector2, CircleOptions> Get()
		{
			return null;
		}

		public override Vector2 ConvertToStartValue(TweenerCore<Vector2, Vector2, CircleOptions> t, Vector2 value)
		{
			return default(Vector2);
		}

		public override void SetRelativeEndValue(TweenerCore<Vector2, Vector2, CircleOptions> t)
		{
		}

		public override void SetChangeValue(TweenerCore<Vector2, Vector2, CircleOptions> t)
		{
		}

		public override float GetSpeedBasedDuration(CircleOptions options, float unitsXSecond, Vector2 changeValue)
		{
			return 0f;
		}

		public override void EvaluateAndApply(CircleOptions options, Tween t, bool isRelative, DOGetter<Vector2> getter, DOSetter<Vector2> setter, float elapsed, Vector2 startValue, Vector2 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, UpdateNotice updateNotice)
		{
		}

		public Vector2 GetPositionOnCircle(CircleOptions options, float degrees)
		{
			return default(Vector2);
		}
	}
}
