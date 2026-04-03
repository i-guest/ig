using System;
using UnityEngine.Localization.SmartFormat.Core.Parsing;

namespace UnityEngine.Localization.SmartFormat.Core.Formatting
{
	public class FormattingException : Exception
	{
		public string Format { get; }

		public FormatItem ErrorItem { get; }

		public string Issue { get; }

		public int Index { get; }

		public override string Message => null;

		public FormattingException(FormatItem errorItem, Exception formatException, int index)
		{
		}

		public FormattingException(FormatItem errorItem, string issue, int index)
		{
		}
	}
}
