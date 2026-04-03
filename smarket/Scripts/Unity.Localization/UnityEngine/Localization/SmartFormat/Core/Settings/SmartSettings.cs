using System;
using System.Collections.Generic;

namespace UnityEngine.Localization.SmartFormat.Core.Settings
{
	[Serializable]
	public class SmartSettings
	{
		[SerializeField]
		private ErrorAction m_FormatErrorAction;

		[SerializeField]
		private ErrorAction m_ParseErrorAction;

		[Tooltip("Determines whether placeholders are case-sensitive or not.")]
		[SerializeField]
		private CaseSensitivityType m_CaseSensitivity;

		[Tooltip("This setting is relevant for the 'Parsing.LiteralText', If true (the default), character string literals are treated like in normal string.Format: string.Format(\"\t\") will return a \"TAB\" character If false, character string literals are not converted, just like with this string.Format: string.Format(@\"\t\") will return the 2 characters \"\" and \"t\"")]
		[SerializeField]
		private bool m_ConvertCharacterStringLiterals;

		public ErrorAction FormatErrorAction
		{
			get
			{
				return default(ErrorAction);
			}
			set
			{
			}
		}

		public ErrorAction ParseErrorAction
		{
			get
			{
				return default(ErrorAction);
			}
			set
			{
			}
		}

		public CaseSensitivityType CaseSensitivity
		{
			get
			{
				return default(CaseSensitivityType);
			}
			set
			{
			}
		}

		public bool ConvertCharacterStringLiterals
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal SmartSettings()
		{
		}

		internal IEqualityComparer<string> GetCaseSensitivityComparer()
		{
			return null;
		}

		internal StringComparison GetCaseSensitivityComparison()
		{
			return default(StringComparison);
		}
	}
}
