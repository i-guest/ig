using System;
using System.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	[Obsolete("UxmlObjectFactoryRegistry is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal class UxmlObjectFactoryRegistry
	{
		private static Dictionary<string, List<IBaseUxmlObjectFactory>> s_Factories;

		internal static Dictionary<string, List<IBaseUxmlObjectFactory>> factories
		{
			[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
			get
			{
				return null;
			}
		}

		protected static void RegisterFactory(IBaseUxmlObjectFactory factory)
		{
		}

		private static void RegisterEngineFactories()
		{
		}

		private static void RegisterUserFactories()
		{
		}
	}
}
