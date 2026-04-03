using System;
using System.Collections.Generic;
using UnityEngine.Localization.SmartFormat.Core.Extensions;
using UnityEngine.Localization.SmartFormat.Core.Parsing;

namespace UnityEngine.Localization.SmartFormat.Extensions
{
	[Serializable]
	public class ChooseFormatter : FormatterBase, IFormatterLiteralExtractor
	{
		[SerializeField]
		private char m_SplitChar;

		public char SplitChar
		{
			get
			{
				return '\0';
			}
			set
			{
			}
		}

		public override string[] DefaultNames => null;

		public override bool TryEvaluateFormat(IFormattingInfo formattingInfo)
		{
			return false;
		}

		private static Format DetermineChosenFormat(IFormattingInfo formattingInfo, IList<Format> choiceFormats, string[] chooseOptions)
		{
			return null;
		}

		public void WriteAllLiterals(IFormattingInfo formattingInfo)
		{
		}
	}
}
