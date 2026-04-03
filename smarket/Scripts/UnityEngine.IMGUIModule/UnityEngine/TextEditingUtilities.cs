using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine.Bindings;
using UnityEngine.TextCore.Text;

namespace UnityEngine
{
	[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
	internal class TextEditingUtilities
	{
		internal struct KeyEvent : IEquatable<KeyEvent>
		{
			public KeyCode key { get; }

			public EventModifiers modifiers { get; }

			public KeyEvent(KeyCode key, EventModifiers modifiers)
			{
				this.key = default(KeyCode);
				this.modifiers = default(EventModifiers);
			}

			[CompilerGenerated]
			public override readonly string ToString()
			{
				return null;
			}

			[CompilerGenerated]
			private readonly bool PrintMembers(StringBuilder builder)
			{
				return false;
			}

			[CompilerGenerated]
			public static bool operator ==(KeyEvent left, KeyEvent right)
			{
				return false;
			}

			[CompilerGenerated]
			public override readonly int GetHashCode()
			{
				return 0;
			}

			[CompilerGenerated]
			public override readonly bool Equals(object obj)
			{
				return false;
			}

			[CompilerGenerated]
			public readonly bool Equals(KeyEvent other)
			{
				return false;
			}
		}

		private TextSelectingUtilities m_TextSelectingUtility;

		internal TextHandle textHandle;

		private int m_CursorIndexSavedState;

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal bool isCompositionActive;

		private bool m_UpdateImeWindowPosition;

		internal Action OnTextChanged;

		public bool multiline;

		private string m_Text;

		internal static readonly List<(KeyEvent keyEvent, TextEditOp operation)> s_GlobalKeyMappings;

		internal static readonly List<(KeyEvent keyEvent, TextEditOp operation)> s_MacKeyMappings;

		internal static readonly List<(KeyEvent keyEvent, TextEditOp operation)> s_WindowsLinuxKeyMappings;

		private char m_HighSurrogate;

		private bool hasSelection => false;

		internal bool revealCursor
		{
			set
			{
			}
		}

		internal int stringCursorIndex => 0;

		private int cursorIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		private int cursorIndexNoValidation
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		private int selectIndexNoValidation
		{
			set
			{
			}
		}

		internal int stringSelectIndex => 0;

		private int selectIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

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

		internal void SetTextWithoutNotify(string value)
		{
		}

		public TextEditingUtilities(TextSelectingUtilities selectingUtilities, TextHandle textHandle, string text)
		{
		}

		public bool UpdateImeState()
		{
			return false;
		}

		public bool ShouldUpdateImeWindowPosition()
		{
			return false;
		}

		public void SetImeWindowPosition(Vector2 worldPosition)
		{
		}

		public string GeneratePreviewString(bool richText)
		{
			return null;
		}

		public void EnableCursorPreviewState()
		{
		}

		public void RestoreCursorState()
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal bool HandleKeyEvent(KeyCode key, EventModifiers modifiers)
		{
			return false;
		}

		internal static TextEditOp? TextEditOpFromEnum(KeyCode key, EventModifiers modifiers, bool IsMacOsFamily)
		{
			return null;
		}

		private void PerformOperation(TextEditOp operation)
		{
		}

		public bool DeleteLineBack()
		{
			return false;
		}

		public bool DeleteWordBack()
		{
			return false;
		}

		public bool DeleteWordForward()
		{
			return false;
		}

		public bool Delete()
		{
			return false;
		}

		public bool Backspace()
		{
			return false;
		}

		public bool DeleteSelection()
		{
			return false;
		}

		public void ReplaceSelection(string replace)
		{
		}

		public bool Insert(char c)
		{
			return false;
		}

		public bool CanPaste()
		{
			return false;
		}

		public bool Cut()
		{
			return false;
		}

		public bool Paste()
		{
			return false;
		}

		private static string ReplaceNewlinesWithSpaces(string value)
		{
			return null;
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal void OnBlur()
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal bool TouchScreenKeyboardShouldBeUsed()
		{
			return false;
		}
	}
}
