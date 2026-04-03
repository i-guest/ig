using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace Unity.Properties.Internal
{
	[VisibleToOtherModules(new string[] { "UnityEditor.PropertiesModule" })]
	internal static class PropertiesInitialization
	{
		[RequiredByNativeCode(false)]
		public static void InitializeProperties()
		{
		}
	}
}
