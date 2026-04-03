using System;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	[Serializable]
	[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal struct StyleSelectorPart
	{
		[SerializeField]
		private string m_Value;

		[SerializeField]
		private StyleSelectorType m_Type;

		internal object tempData;

		public string value
		{
			get
			{
				return null;
			}
			[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
			internal set
			{
			}
		}

		public StyleSelectorType type
		{
			get
			{
				return default(StyleSelectorType);
			}
			[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
			internal set
			{
			}
		}

		public override string ToString()
		{
			return null;
		}

		public static StyleSelectorPart CreateClass(string className)
		{
			return default(StyleSelectorPart);
		}

		public static StyleSelectorPart CreateId(string Id)
		{
			return default(StyleSelectorPart);
		}

		public static StyleSelectorPart CreatePredicate(object predicate)
		{
			return default(StyleSelectorPart);
		}
	}
}
