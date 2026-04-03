namespace UnityEngine.Localization.SmartFormat.Utilities
{
	public class TimeTextInfo
	{
		private readonly string[] d;

		private readonly string[] day;

		private readonly string[] h;

		private readonly string[] hour;

		private readonly string lessThan;

		private readonly string[] m;

		private readonly string[] millisecond;

		private readonly string[] minute;

		private readonly string[] ms;

		private readonly PluralRules.PluralRuleDelegate PluralRule;

		private readonly string[] s;

		private readonly string[] second;

		private readonly string[] w;

		private readonly string[] week;

		public TimeTextInfo(PluralRules.PluralRuleDelegate pluralRule, string[] week, string[] day, string[] hour, string[] minute, string[] second, string[] millisecond, string[] w, string[] d, string[] h, string[] m, string[] s, string[] ms, string lessThan)
		{
		}

		public TimeTextInfo(string week, string day, string hour, string minute, string second, string millisecond, string lessThan)
		{
		}

		private static string GetValue(PluralRules.PluralRuleDelegate pluralRule, int value, string[] units)
		{
			return null;
		}

		public string GetLessThanText(string minimumValue)
		{
			return null;
		}

		public virtual string GetUnitText(TimeSpanFormatOptions unit, int value, bool abbr)
		{
			return null;
		}
	}
}
