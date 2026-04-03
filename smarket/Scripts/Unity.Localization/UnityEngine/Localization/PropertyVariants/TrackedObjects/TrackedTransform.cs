using System;
using System.Collections.Generic;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization.PropertyVariants.TrackedObjects
{
	[Serializable]
	[DisplayName("Transform", null)]
	[CustomTrackedObject(typeof(Transform), false)]
	public class TrackedTransform : TrackedObject
	{
		private Vector3 m_PositionToApply;

		private Quaternion m_RotationToApply;

		private Vector3 m_ScaleToApply;

		private Dictionary<string, Action<float>> m_PropertyHandlers;

		protected virtual void AddPropertyHandlers(Dictionary<string, Action<float>> handlers)
		{
		}

		public override bool CanTrackProperty(string propertyPath)
		{
			return false;
		}

		public override AsyncOperationHandle ApplyLocale(Locale variantLocale, Locale defaultLocale)
		{
			return default(AsyncOperationHandle);
		}
	}
}
