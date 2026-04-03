using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements
{
	public static class UxmlDescriptionCache
	{
		internal struct CachedDescription
		{
			public UxmlAttributeNames[] attributeNames;

			public bool editorOnly;
		}

		private static readonly Dictionary<Type, CachedDescription> s_NamesPerType;

		public static void RegisterType(Type type, UxmlAttributeNames[] attributeNames, bool isEditorOnly = false)
		{
		}
	}
}
