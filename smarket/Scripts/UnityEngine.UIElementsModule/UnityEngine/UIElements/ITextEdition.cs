using System;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	public interface ITextEdition
	{
		internal bool multiline { get; set; }

		bool isReadOnly { get; set; }

		int maxLength { get; set; }

		string placeholder { get; set; }

		bool isDelayed { get; set; }

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal Func<char, bool> AcceptCharacter { get; set; }

		internal Action<bool> UpdateScrollOffset { get; set; }

		internal Action UpdateValueFromText { get; set; }

		internal Action UpdateTextFromValue { get; set; }

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal Action MoveFocusToCompositeRoot { get; set; }

		internal Func<string> GetDefaultValueType { get; set; }

		char maskChar { get; set; }

		bool isPassword { get; set; }

		bool hidePlaceholderOnFocus { get; set; }

		bool autoCorrection
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		bool hideMobileInput
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		TouchScreenKeyboard touchScreenKeyboard => null;

		TouchScreenKeyboardType keyboardType
		{
			get
			{
				return default(TouchScreenKeyboardType);
			}
			set
			{
			}
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal void SaveValueAndText();

		internal void RestoreValueAndText();

		internal void UpdateText(string value);

		internal string CullString(string s);
	}
}
