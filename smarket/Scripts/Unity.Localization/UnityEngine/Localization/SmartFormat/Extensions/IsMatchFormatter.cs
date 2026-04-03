using System;
using System.Text.RegularExpressions;
using UnityEngine.Localization.SmartFormat.Core.Extensions;

namespace UnityEngine.Localization.SmartFormat.Extensions
{
	[Serializable]
	public class IsMatchFormatter : FormatterBase, IFormatterLiteralExtractor
	{
		public override string[] DefaultNames => null;

		public RegexOptions RegexOptions { get; set; }

		public override bool TryEvaluateFormat(IFormattingInfo formattingInfo)
		{
			return false;
		}

		public void WriteAllLiterals(IFormattingInfo formattingInfo)
		{
		}
	}
}
