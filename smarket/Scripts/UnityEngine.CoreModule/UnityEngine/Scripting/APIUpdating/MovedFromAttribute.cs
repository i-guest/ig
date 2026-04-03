using System;
using UnityEngine.Bindings;

namespace UnityEngine.Scripting.APIUpdating
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate)]
	public class MovedFromAttribute : Attribute
	{
		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal MovedFromAttributeData data;

		public MovedFromAttribute(bool autoUpdateAPI, string sourceNamespace = null, string sourceAssembly = null, string sourceClassName = null)
		{
		}

		public MovedFromAttribute(string sourceNamespace)
		{
		}
	}
}
