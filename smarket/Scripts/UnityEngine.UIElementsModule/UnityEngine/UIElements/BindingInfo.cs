using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Properties;

namespace UnityEngine.UIElements
{
	public readonly struct BindingInfo
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private readonly VisualElement _003CtargetElement_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly BindingId _003CbindingId_003Ek__BackingField;

		public Binding binding { get; }

		private BindingInfo(VisualElement targetElement, in BindingId bindingId, Binding binding)
		{
			_003CtargetElement_003Ek__BackingField = null;
			_003CbindingId_003Ek__BackingField = default(BindingId);
			this.binding = null;
		}

		internal static BindingInfo FromRequest(VisualElement target, in PropertyPath targetPath, Binding binding)
		{
			return default(BindingInfo);
		}

		internal static BindingInfo FromBindingData(in DataBindingManager.BindingData bindingData)
		{
			return default(BindingInfo);
		}
	}
}
