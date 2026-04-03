using System;
using System.Collections.Generic;
using UnityEngine.Localization.Pseudo;
using UnityEngine.Localization.SmartFormat.Core.Formatting;

namespace UnityEngine.Localization.Tables
{
	public class StringTableEntry : TableEntry
	{
		private FormatCache m_FormatCache;

		public FormatCache FormatCache
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsSmart
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal StringTableEntry()
		{
		}

		public void RemoveFromTable()
		{
		}

		internal FormatCache GetOrCreateFormatCache()
		{
			return null;
		}

		public string GetLocalizedString()
		{
			return null;
		}

		public string GetLocalizedString(params object[] args)
		{
			return null;
		}

		public string GetLocalizedString(IList<object> args)
		{
			return null;
		}

		public string GetLocalizedString(IFormatProvider formatProvider, IList<object> args)
		{
			return null;
		}

		public string GetLocalizedString(IFormatProvider formatProvider, IList<object> args, PseudoLocale pseudoLocale)
		{
			return null;
		}
	}
}
