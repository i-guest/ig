using System;
using UnityEngine.Localization.SmartFormat.Core.Extensions;
using UnityEngine.Localization.SmartFormat.Utilities;

namespace UnityEngine.Localization.SmartFormat.Extensions
{
	[Serializable]
	public class PluralLocalizationFormatter : FormatterBase, IFormatterLiteralExtractor
	{
		[SerializeField]
		private string m_DefaultTwoLetterISOLanguageName;

		private PluralRules.PluralRuleDelegate m_DefaultPluralRule;

		public string DefaultTwoLetterISOLanguageName
		{
			get
			{
				return null;
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

		protected virtual PluralRules.PluralRuleDelegate GetPluralRule(IFormattingInfo formattingInfo)
		{
			return null;
		}

		public void WriteAllLiterals(IFormattingInfo formattingInfo)
		{
		}
	}
}
