using System;
using System.Text.RegularExpressions;
using UnityEngine.Localization.SmartFormat.Core.Extensions;
using UnityEngine.Localization.SmartFormat.Core.Parsing;

namespace UnityEngine.Localization.SmartFormat.Extensions
{
	[Serializable]
	public class ConditionalFormatter : FormatterBase, IFormatterLiteralExtractor
	{
		private static readonly Regex _complexConditionPattern;

		public override string[] DefaultNames => null;

		public override bool TryEvaluateFormat(IFormattingInfo formattingInfo)
		{
			return false;
		}

		private static bool TryEvaluateCondition(Format parameter, decimal value, out bool conditionResult, out Format outputItem)
		{
			conditionResult = default(bool);
			outputItem = null;
			return false;
		}

		public void WriteAllLiterals(IFormattingInfo formattingInfo)
		{
		}
	}
}
