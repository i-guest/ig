using System;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements.StyleSheets
{
	[Serializable]
	[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal struct ScalableImage
	{
		public Texture2D normalImage;

		public Texture2D highResolutionImage;

		public override string ToString()
		{
			return null;
		}
	}
}
