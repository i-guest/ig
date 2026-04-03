using System;

namespace UnityEngine
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
	public sealed class MultilineAttribute : PropertyAttribute
	{
		public readonly int lines;

		public MultilineAttribute()
		{
		}

		public MultilineAttribute(int lines)
		{
		}
	}
}
