using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	public class TextEditor
	{
		public enum DblClickSnapping : byte
		{
			WORDS = 0,
			PARAGRAPHS = 1
		}

		private readonly GUIContent m_Content;

		private TextSelectingUtilities m_TextSelecting;

		internal TextEditingUtilities m_TextEditing;

		internal IMGUITextHandle m_TextHandle;

		public TouchScreenKeyboard keyboardOnScreen;

		public int controlID;

		public GUIStyle style;

		[Obsolete("'hasHorizontalCursorPos' has been deprecated. Changes to this member will not be observed. Use 'hasHorizontalCursor' instead.", true)]
		public bool hasHorizontalCursorPos;

		public bool isPasswordField;

		public Vector2 scrollOffset;

		private string m_TextWithWhitespace;

		public Vector2 graphicalCursorPos;

		private Vector2 lastCursorPos;

		private Vector2 previousContentSize;

		public bool showCursor => false;

		public string text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal string textWithWhitespace
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Rect position { get; }

		[RequiredByNativeCode]
		public TextEditor()
		{
		}

		private void OnTextChangedHandle()
		{
		}

		private void OnContentTextChangedHandle()
		{
		}

		internal void UpdateTextHandle()
		{
		}

		[VisibleToOtherModules]
		internal void UpdateScrollOffset()
		{
		}

		internal virtual void OnCursorIndexChange()
		{
		}

		internal virtual void OnSelectIndexChange()
		{
		}
	}
}
