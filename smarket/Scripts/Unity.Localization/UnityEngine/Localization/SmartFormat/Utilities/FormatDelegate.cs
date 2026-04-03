using System;

namespace UnityEngine.Localization.SmartFormat.Utilities
{
	public class FormatDelegate : IFormattable
	{
		private readonly Func<string, string> getFormat1;

		private readonly Func<string, IFormatProvider, string> getFormat2;

		public FormatDelegate(Func<string, string> getFormat)
		{
		}

		public FormatDelegate(Func<string, IFormatProvider, string> getFormat)
		{
		}

		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}
	}
}
