using System;
using UnityEngine.Localization.SmartFormat.Core.Extensions;
using UnityEngine.Localization.SmartFormat.Utilities;

namespace UnityEngine.Localization.SmartFormat.Extensions
{
	[Serializable]
	public class TimeFormatter : FormatterBase
	{
		[SerializeField]
		private TimeSpanFormatOptions m_DefaultFormatOptions;

		private string m_DefaultTwoLetterIsoLanguageName;

		public override string[] DefaultNames => null;

		public TimeSpanFormatOptions DefaultFormatOptions
		{
			get
			{
				return default(TimeSpanFormatOptions);
			}
			set
			{
			}
		}

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

		public override bool TryEvaluateFormat(IFormattingInfo formattingInfo)
		{
			return false;
		}

		private TimeTextInfo GetTimeTextInfo(IFormatProvider provider)
		{
			return null;
		}
	}
}
