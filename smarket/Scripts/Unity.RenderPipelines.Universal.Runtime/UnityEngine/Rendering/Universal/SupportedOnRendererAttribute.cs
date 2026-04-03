using System;

namespace UnityEngine.Rendering.Universal
{
	[AttributeUsage(AttributeTargets.Class)]
	public class SupportedOnRendererAttribute : Attribute
	{
		public Type[] rendererTypes { get; }

		public SupportedOnRendererAttribute(Type renderer)
		{
		}

		public SupportedOnRendererAttribute(params Type[] renderers)
		{
		}
	}
}
