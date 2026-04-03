using System;

namespace UnityEngine.UIElements
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class UxmlAttributeAttribute : Attribute
	{
		public string name;

		public string[] obsoleteNames;

		public UxmlAttributeAttribute()
		{
		}

		public UxmlAttributeAttribute(string name)
		{
		}

		public UxmlAttributeAttribute(string name, params string[] obsoleteNames)
		{
		}
	}
}
