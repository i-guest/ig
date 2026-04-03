using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Localization.SmartFormat.Core.Settings;

namespace UnityEngine.Localization.SmartFormat.Core.Parsing
{
	[Serializable]
	public class Parser
	{
		public enum ParsingError
		{
			TooManyClosingBraces = 1,
			TrailingOperatorsInSelector = 2,
			InvalidCharactersInSelector = 3,
			MissingClosingBrace = 4
		}

		internal class ParsingErrorText
		{
			private readonly Dictionary<ParsingError, string> _errors;

			public string this[ParsingError parsingErrorKey] => null;

			internal ParsingErrorText()
			{
			}
		}

		[SerializeField]
		private char m_OpeningBrace;

		[SerializeField]
		private char m_ClosingBrace;

		[SerializeReference]
		[HideInInspector]
		private SmartSettings m_Settings;

		[Tooltip("If false, only digits are allowed as selectors. If true, selectors can be alpha-numeric. This allows optimized alpha-character detection. Specify any additional selector chars in AllowedSelectorChars.")]
		[SerializeField]
		private bool m_AlphanumericSelectors;

		[Tooltip("A list of allowable selector characters, to support additional selector syntaxes such as math. Digits are always included, and letters can be included with AlphanumericSelectors.")]
		[SerializeField]
		private string m_AllowedSelectorChars;

		[Tooltip("A list of characters that come between selectors. This can be \".\" for dot-notation, \"[]\" for arrays, or even math symbols. By default, there are no operators.")]
		[SerializeField]
		private string m_Operators;

		[Tooltip("If false, double-curly braces are escaped. If true, the AlternativeEscapeChar is used for escaping braces.")]
		[SerializeField]
		private bool m_AlternativeEscaping;

		[Tooltip("If AlternativeEscaping is true, then this character is used to escape curly braces.")]
		[SerializeField]
		private char m_AlternativeEscapeChar;

		[Tooltip("The character literal escape character e.g. for \t (TAB) and others. This is kind of overlapping functionality with `UseAlternativeEscapeChar` Note: In a future release escape characters for placeholders  and character literals should become the same.")]
		[SerializeField]
		internal const char m_CharLiteralEscapeChar = '\\';

		private static ParsingErrorText s_ParsingErrorText;

		public SmartSettings Settings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public event EventHandler<ParsingErrorEventArgs> OnParsingFailure
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public Parser(SmartSettings settings)
		{
		}

		public void AddAlphanumericSelectors()
		{
		}

		public void AddAdditionalSelectorChars(string chars)
		{
		}

		public void AddOperators(string chars)
		{
		}

		public void UseAlternativeEscapeChar(char alternativeEscapeChar = '\\')
		{
		}

		public void UseBraceEscaping()
		{
		}

		public void UseAlternativeBraces(char opening, char closing)
		{
		}

		public Format ParseFormat(string format, IList<string> formatterExtensionNames)
		{
			return null;
		}

		private Format HandleParsingErrors(ParsingErrors parsingErrors, Format currentResult)
		{
			return null;
		}

		private static bool FormatterNameExists(string name, IList<string> formatterExtensionNames)
		{
			return false;
		}
	}
}
