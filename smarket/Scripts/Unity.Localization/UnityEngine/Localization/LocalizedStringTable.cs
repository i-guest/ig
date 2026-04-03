using System;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.Tables;

namespace UnityEngine.Localization
{
	[Serializable]
	public class LocalizedStringTable : LocalizedTable<StringTable, StringTableEntry>
	{
		protected override LocalizedDatabase<StringTable, StringTableEntry> Database => null;

		public LocalizedStringTable()
		{
		}

		public LocalizedStringTable(TableReference tableReference)
		{
		}
	}
}
