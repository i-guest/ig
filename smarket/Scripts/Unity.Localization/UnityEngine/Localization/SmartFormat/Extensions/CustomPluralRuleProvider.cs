using System;
using UnityEngine.Localization.SmartFormat.Utilities;

namespace UnityEngine.Localization.SmartFormat.Extensions
{
	public class CustomPluralRuleProvider : IFormatProvider
	{
		private readonly PluralRules.PluralRuleDelegate _pluralRule;

		public CustomPluralRuleProvider(PluralRules.PluralRuleDelegate pluralRule)
		{
		}

		public object GetFormat(Type formatType)
		{
			return null;
		}

		public PluralRules.PluralRuleDelegate GetPluralRule()
		{
			return null;
		}
	}
}
