using System;

namespace UnityEngine.UIElements
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, Inherited = false)]
	public class UxmlObjectReferenceAttribute : Attribute
	{
		public string name;

		public Type[] types;

		public UxmlObjectReferenceAttribute()
		{
		}

		public UxmlObjectReferenceAttribute(string uxmlName)
		{
		}

		public UxmlObjectReferenceAttribute(string uxmlName, params Type[] acceptedTypes)
		{
		}
	}
}
