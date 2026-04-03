using UnityEngine.TextCore.Text;

namespace UnityEngine.UIElements
{
	internal class TextEventHandler
	{
		private TextElement m_TextElement;

		private EventCallback<PointerDownEvent> m_LinkTagOnPointerDown;

		private EventCallback<PointerUpEvent> m_LinkTagOnPointerUp;

		private EventCallback<PointerMoveEvent> m_LinkTagOnPointerMove;

		private EventCallback<PointerOutEvent> m_LinkTagOnPointerOut;

		private EventCallback<PointerUpEvent> m_ATagOnPointerUp;

		private EventCallback<PointerMoveEvent> m_ATagOnPointerMove;

		private EventCallback<PointerOverEvent> m_ATagOnPointerOver;

		private EventCallback<PointerOutEvent> m_ATagOnPointerOut;

		internal bool isOverridingCursor;

		internal int currentLinkIDHash;

		internal bool hasLinkTag;

		internal bool hasATag;

		private TextInfo textInfo => null;

		public TextEventHandler(TextElement textElement)
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

		private bool HasAllocatedATagCallbacks()
		{
			return false;
		}

		private void AllocateATagCallbacks()
		{
		}

		private void ATagOnPointerUp(PointerUpEvent pue)
		{
		}

		private void ATagOnPointerOver(PointerOverEvent _)
		{
		}

		private void ATagOnPointerMove(PointerMoveEvent pme)
		{
		}

		private void ATagOnPointerOut(PointerOutEvent evt)
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

		internal void HandleLinkAndATagCallbacks()
		{
		}

		internal void HandleLinkTag()
		{
		}

		internal void HandleATag()
		{
		}
	}
}
