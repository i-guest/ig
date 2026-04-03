using System.Collections.Generic;

namespace UnityEngine.Localization.SmartFormat.Utilities
{
	public static class PluralRules
	{
		public delegate int PluralRuleDelegate(decimal value, int pluralCount);

		public static readonly Dictionary<string, PluralRuleDelegate> IsoLangToDelegate;

		private static PluralRuleDelegate Singular => null;

		private static PluralRuleDelegate DualOneOther => null;

		private static PluralRuleDelegate DualWithZero => null;

		private static PluralRuleDelegate DualFromZeroToTwo => null;

		private static PluralRuleDelegate TripleOneTwoOther => null;

		private static PluralRuleDelegate RussianSerboCroatian => null;

		private static PluralRuleDelegate Arabic => null;

		private static PluralRuleDelegate Breton => null;

		private static PluralRuleDelegate Czech => null;

		private static PluralRuleDelegate Welsh => null;

		private static PluralRuleDelegate Manx => null;

		private static PluralRuleDelegate Langi => null;

		private static PluralRuleDelegate Lithuanian => null;

		private static PluralRuleDelegate Latvian => null;

		private static PluralRuleDelegate Macedonian => null;

		private static PluralRuleDelegate Moldavian => null;

		private static PluralRuleDelegate Maltese => null;

		private static PluralRuleDelegate Polish => null;

		private static PluralRuleDelegate Romanian => null;

		private static PluralRuleDelegate Tachelhit => null;

		private static PluralRuleDelegate Slovak => null;

		private static PluralRuleDelegate Slovenian => null;

		private static PluralRuleDelegate CentralMoroccoTamazight => null;

		public static PluralRuleDelegate GetPluralRule(string twoLetterIsoLanguageName)
		{
			return null;
		}

		private static bool Between(this decimal value, decimal min, decimal max)
		{
			return false;
		}
	}
}
