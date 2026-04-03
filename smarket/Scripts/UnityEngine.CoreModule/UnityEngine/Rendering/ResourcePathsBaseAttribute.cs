using System;

namespace UnityEngine.Rendering
{
	[AttributeUsage(AttributeTargets.Field, Inherited = true)]
	public abstract class ResourcePathsBaseAttribute : Attribute
	{
		protected ResourcePathsBaseAttribute(string[] paths, bool isField, SearchType location)
		{
		}
	}
}
