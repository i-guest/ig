using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements
{
	internal class RuntimePanel : BaseRuntimePanel, IRuntimePanel, IPanel, IDisposable
	{
		internal static readonly EventDispatcher s_EventDispatcher;

		private readonly PanelSettings m_PanelSettings;

		private static readonly List<UIDocument> s_EmptyDocumentList;

		public PanelSettings panelSettings => null;

		public static RuntimePanel Create(ScriptableObject ownerObject)
		{
			return null;
		}

		private RuntimePanel(ScriptableObject ownerObject)
			: base(null)
		{
		}

		internal override void Update()
		{
		}

		private void OnElementFocus(FocusEvent evt)
		{
		}
	}
}
