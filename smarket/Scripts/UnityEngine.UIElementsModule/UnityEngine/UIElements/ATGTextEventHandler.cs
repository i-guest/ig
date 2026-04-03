using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace UnityEngine.UIElements
{
	internal class ATGTextEventHandler
	{
		private static readonly Regex s_ATagRegex;

		private static readonly Regex s_LinkTagRegex;

		private TextElement m_TextElement;

		private EventCallback<PointerDownEvent> m_LinkTagOnPointerDown;

		private EventCallback<PointerUpEvent> m_LinkTagOnPointerUp;

		private EventCallback<PointerMoveEvent> m_LinkTagOnPointerMove;

		private EventCallback<PointerOutEvent> m_LinkTagOnPointerOut;

		private EventCallback<PointerUpEvent> m_HyperlinkOnPointerUp;

		private EventCallback<PointerMoveEvent> m_HyperlinkOnPointerMove;

		private EventCallback<PointerOverEvent> m_HyperlinkOnPointerOver;

		private EventCallback<PointerOutEvent> m_HyperlinkOnPointerOut;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<Dictionary<string, string>> onComplexHyperlinkClicked;

		internal bool isOverridingCursor;

		internal int currentLinkIDHash;

		public ATGTextEventHandler(TextElement textElement)
		{
		}

		public void OnDestroy()
		{
		}

		private bool HasAllocatedLinkCallbacks()
		{
			return false;
		}

		private void AllocateLinkCallbacks()
		{
		}

		private bool HasAllocatedHyperlinkCallbacks()
		{
			return false;
		}

		private void AllocateHyperlinkCallbacks()
		{
		}

		private void HyperlinkOnPointerUp(PointerUpEvent pue)
		{
		}

		private static bool IsComplexHyperLink(string link, out Dictionary<string, string> hyperLinkData)
		{
			hyperLinkData = null;
			return false;
		}

		private void HyperlinkOnPointerOver(PointerOverEvent _)
		{
		}

		private void HyperlinkOnPointerMove(PointerMoveEvent pme)
		{
		}

		private void HyperlinkOnPointerOut(PointerOutEvent evt)
		{
		}

		private void LinkTagOnPointerDown(PointerDownEvent pde)
		{
		}

		private void LinkTagOnPointerUp(PointerUpEvent pue)
		{
		}

		private void LinkTagOnPointerMove(PointerMoveEvent pme)
		{
		}

		private void LinkTagOnPointerOut(PointerOutEvent poe)
		{
		}

		internal void RegisterLinkTagCallbacks()
		{
		}

		internal void UnRegisterLinkTagCallbacks()
		{
		}

		internal void RegisterHyperlinkCallbacks()
		{
		}

		internal void UnRegisterHyperlinkCallbacks()
		{
		}
	}
}
