using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[AttributeUsage(AttributeTargets.Class, Inherited = false)]
	[VisibleToOtherModules]
	internal sealed class AssetFileNameExtensionAttribute : Attribute
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly string _003CpreferredExtension_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly IEnumerable<string> _003CotherExtensions_003Ek__BackingField;

		public AssetFileNameExtensionAttribute(string preferredExtension, params string[] otherExtensions)
		{
		}
	}
}
