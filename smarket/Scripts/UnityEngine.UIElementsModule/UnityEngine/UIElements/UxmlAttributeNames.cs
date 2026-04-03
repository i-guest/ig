using System;

namespace UnityEngine.UIElements
{
	public readonly struct UxmlAttributeNames
	{
		public readonly string fieldName;

		public readonly string uxmlName;

		public readonly Type typeReference;

		public readonly string[] obsoleteNames;

		public UxmlAttributeNames(string fieldName, string uxmlName, Type typeReference = null, params string[] obsoleteNames)
		{
			this.fieldName = null;
			this.uxmlName = null;
			this.typeReference = null;
			this.obsoleteNames = null;
		}
	}
}
