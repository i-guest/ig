using System;

namespace UnityEngine.Localization.PropertyVariants.TrackedProperties
{
	[Serializable]
	public class BoolTrackedProperty : TrackedProperty<bool>
	{
		protected override bool ConvertFromString(string value)
		{
			return false;
		}

		protected override string ConvertToString(bool value)
		{
			return null;
		}
	}
}
