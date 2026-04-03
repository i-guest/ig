using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace DG.Tweening.Plugins
{
	public struct CircleOptions : IPlugOptions
	{
		public float endValueDegrees;

		public bool relativeCenter;

		public bool snapping;

		internal Vector2 center;

		internal float radius;

		internal float startValueDegrees;

		internal bool initialized;

		public void Reset()
		{
		}

		public void Initialize(Vector2 startValue, Vector2 endValue)
		{
		}
	}
}
