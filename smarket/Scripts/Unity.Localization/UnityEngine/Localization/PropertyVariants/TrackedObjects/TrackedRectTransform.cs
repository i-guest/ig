using System;
using System.Collections.Generic;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization.PropertyVariants.TrackedObjects
{
	[Serializable]
	[DisplayName("Rect Transform", null)]
	[CustomTrackedObject(typeof(RectTransform), false)]
	public class TrackedRectTransform : TrackedTransform
	{
		private Vector3 m_AnchorPosToApply;

		private Vector2 m_AnchorMinToApply;

		private Vector2 m_AnchorMaxToApply;

		private Vector2 m_PivotToApply;

		private Vector2 m_SizeDeltaToApply;

		protected override void AddPropertyHandlers(Dictionary<string, Action<float>> handlers)
		{
		}

		public override AsyncOperationHandle ApplyLocale(Locale variantLocale, Locale defaultLocale)
		{
			return default(AsyncOperationHandle);
		}
	}
}
