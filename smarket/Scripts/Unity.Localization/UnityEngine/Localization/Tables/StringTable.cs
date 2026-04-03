using System.Collections.Generic;

namespace UnityEngine.Localization.Tables
{
	public class StringTable : DetailedLocalizationTable<StringTableEntry>
	{
		public string GenerateCharacterSet()
		{
			return null;
		}

		internal IEnumerable<char> CollectLiteralCharacters()
		{
			return null;
		}

		public override StringTableEntry CreateTableEntry()
		{
			return null;
		}
	}
}
