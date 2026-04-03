using System;

namespace UnityEngine.Rendering
{
	[Serializable]
	public sealed class LensFlareDataSRP : ScriptableObject
	{
		public LensFlareDataElementSRP[] elements;

		public bool HasAModulateByLightColorElement()
		{
			return false;
		}
	}
}
