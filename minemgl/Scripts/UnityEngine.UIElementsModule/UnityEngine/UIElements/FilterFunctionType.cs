using System;

namespace UnityEngine.UIElements
{
	[Serializable]
	internal enum FilterFunctionType
	{
		None = 0,
		Custom = 1,
		Tint = 2,
		Opacity = 3,
		Invert = 4,
		Grayscale = 5,
		Sepia = 6,
		Blur = 7,
		Count = 8
	}
}
