using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal class UxmlImageAttributeDescription : UxmlAttributeDescription
	{
		private Type m_AssetType;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Background _003CdefaultValue_003Ek__BackingField;

		public Background defaultValue
		{
			[CompilerGenerated]
			set
			{
				_003CdefaultValue_003Ek__BackingField = value;
			}
		}

		public Background GetValueFromBag(IUxmlAttributes bag, CreationContext cc)
		{
			return default(Background);
		}
	}
}
