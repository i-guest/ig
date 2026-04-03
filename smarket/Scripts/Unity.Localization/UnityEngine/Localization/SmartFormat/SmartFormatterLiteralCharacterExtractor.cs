using System.Collections.Generic;
using UnityEngine.Localization.SmartFormat.Core.Formatting;

namespace UnityEngine.Localization.SmartFormat
{
	internal class SmartFormatterLiteralCharacterExtractor : SmartFormatter
	{
		private IEnumerable<char> m_Characters;

		public SmartFormatterLiteralCharacterExtractor(SmartFormatter parent)
		{
		}

		public IEnumerable<char> ExtractLiteralsCharacters(string value)
		{
			return null;
		}

		public override void Format(FormattingInfo formattingInfo)
		{
		}
	}
}
