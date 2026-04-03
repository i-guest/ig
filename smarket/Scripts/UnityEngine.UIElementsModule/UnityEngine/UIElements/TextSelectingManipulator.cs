using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal class TextSelectingManipulator
	{
		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal TextSelectingUtilities m_SelectingUtilities;

		private bool selectAllOnMouseUp;

		private TextElement m_TextElement;

		private Vector2 m_ClickStartPosition;

		private bool m_Dragged;

		private bool m_IsClicking;

		private const int k_DragThresholdSqr = 16;

		private int m_ConsecutiveMouseDownCount;

		private long m_LastMouseDownTimeStamp;

		internal bool isClicking
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		internal int cursorIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		internal int selectIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public TextSelectingManipulator(TextElement textElement)
		{
		}

		private void OnRevealCursor()
		{
		}

		private void OnSelectIndexChange()
		{
		}

		private void OnCursorIndexChange()
		{
		}

		internal bool RevealCursor()
		{
			return false;
		}

		internal bool HasSelection()
		{
			return false;
		}

		internal bool HasFocus()
		{
			return false;
		}

		internal void HandleEventBubbleUp(EventBase evt)
		{
		}

		private void OnFocusEvent()
		{
		}

		private void OnBlurEvent()
		{
		}

		private void OnKeyDown(KeyDownEvent evt)
		{
		}

		private void OnPointerDownEvent(PointerDownEvent evt)
		{
		}

		private void OnPointerMoveEvent(PointerMoveEvent evt)
		{
		}

		private void OnPointerUpEvent(PointerUpEvent evt)
		{
		}

		private void OnValidateCommandEvent(ValidateCommandEvent evt)
		{
		}

		private void OnExecuteCommandEvent(ExecuteCommandEvent evt)
		{
		}

		private bool MoveDistanceQualifiesForDrag(Vector2 start, Vector2 current)
		{
			return false;
		}
	}
}
