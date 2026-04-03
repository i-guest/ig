using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	public abstract class UxmlAttributeDescription
	{
		public enum Use
		{
			None = 0,
			Optional = 1,
			Prohibited = 2,
			Required = 3
		}

		private string[] m_ObsoleteNames;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private string _003Ctype_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string _003CtypeNamespace_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Use _003Cuse_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private UxmlTypeRestriction _003Crestriction_003Ek__BackingField;

		public string name { get; set; }

		public IEnumerable<string> obsoleteNames
		{
			set
			{
			}
		}

		protected internal string type
		{
			[CompilerGenerated]
			set
			{
				_003Ctype_003Ek__BackingField = value;
			}
		}

		protected string typeNamespace
		{
			[CompilerGenerated]
			set
			{
				_003CtypeNamespace_003Ek__BackingField = value;
			}
		}

		public Use use
		{
			[CompilerGenerated]
			set
			{
				_003Cuse_003Ek__BackingField = value;
			}
		}

		public UxmlTypeRestriction restriction
		{
			[CompilerGenerated]
			set
			{
				_003Crestriction_003Ek__BackingField = value;
			}
		}

		internal bool TryFindValueInAttributeOverrides(string elementName, CreationContext cc, List<TemplateAsset.AttributeOverride> attributeOverrides, out string value)
		{
			value = null;
			return false;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal bool TryGetValueFromBagAsString(IUxmlAttributes bag, CreationContext cc, out string value)
		{
			value = null;
			return false;
		}

		internal bool TryGetAttributeOverrideValueFromBagAsString(IUxmlAttributes bag, CreationContext cc, out string value, out VisualTreeAsset sourceAsset)
		{
			value = null;
			sourceAsset = null;
			return false;
		}

		internal bool ValidateName()
		{
			return false;
		}

		internal bool TryGetValueFromBagAsString(IUxmlAttributes bag, CreationContext cc, out string value, out VisualTreeAsset sourceAsset)
		{
			value = null;
			sourceAsset = null;
			return false;
		}

		protected bool TryGetValueFromBag<T>(IUxmlAttributes bag, CreationContext cc, Func<string, T, T> converterFunc, T defaultValue, ref T value)
		{
			return false;
		}

		protected T GetValueFromBag<T>(IUxmlAttributes bag, CreationContext cc, Func<string, T, T> converterFunc, T defaultValue)
		{
			return default(T);
		}
	}
}
