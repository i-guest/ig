using System;
using UnityEngine.UI;

namespace UnityEngine.Localization.PropertyVariants.TrackedObjects
{
	[Serializable]
	[DisplayName("Layout Group", null)]
	[CustomTrackedObject(typeof(LayoutGroup), true)]
	public class TrackedLayoutGroup : JsonSerializerTrackedObject
	{
		protected override void PostApplyTrackedProperties()
		{
		}
	}
}
