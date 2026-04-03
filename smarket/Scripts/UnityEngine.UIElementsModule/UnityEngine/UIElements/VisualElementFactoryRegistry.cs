using System;
using System.Collections.Generic;
using UnityEngine.Bindings;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements
{
	[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal class VisualElementFactoryRegistry
	{
		private static Dictionary<string, List<IUxmlFactory>> s_Factories;

		private static Dictionary<string, List<IUxmlFactory>> s_MovedTypesFactories;

		internal static Dictionary<string, List<IUxmlFactory>> factories
		{
			[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
			get
			{
				return null;
			}
		}

		internal static string GetMovedUIControlTypeName(Type type, MovedFromAttribute attr)
		{
			return null;
		}

		protected static void RegisterFactory(IUxmlFactory factory)
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal static bool TryGetValue(string fullTypeName, out List<IUxmlFactory> factoryList)
		{
			factoryList = null;
			return false;
		}

		private static void RegisterEngineFactories()
		{
		}

		internal static void RegisterUserFactories()
		{
		}
	}
}
