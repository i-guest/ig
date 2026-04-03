using System;

namespace UnityEngine.UIElements
{
	[AttributeUsage(AttributeTargets.Class, Inherited = false)]
	public class UxmlElementAttribute : Attribute
	{
		public readonly string name;

		public LibraryVisibility visibility;

		internal readonly Type[] supportedChildTypes;

		public UxmlElementAttribute(string uxmlName)
		{
		}

		public UxmlElementAttribute(string uxmlName, params Type[] supportedTypes)
		{
		}
	}
}
