using System.Collections.Generic;
using UnityEngine.Localization.SmartFormat.Core.Extensions;
using UnityEngine.Localization.SmartFormat.Core.Parsing;

namespace UnityEngine.Localization.SmartFormat.Core.Formatting
{
	public class FormattingInfo : IFormattingInfo, ISelectorInfo
	{
		public FormattingInfo Parent { get; private set; }

		public Selector Selector { get; set; }

		public FormatDetails FormatDetails { get; private set; }

		public object CurrentValue { get; set; }

		public Placeholder Placeholder { get; private set; }

		public int Alignment => 0;

		public string FormatterOptions => null;

		public Format Format { get; private set; }

		public List<FormattingInfo> Children { get; }

		public string SelectorText => null;

		public int SelectorIndex => 0;

		public string SelectorOperator => null;

		public object Result { get; set; }

		public void Init(FormatDetails formatDetails, Format format, object currentValue)
		{
		}

		public void Init(FormattingInfo parent, FormatDetails formatDetails, Format format, object currentValue)
		{
		}

		public void Init(FormattingInfo parent, FormatDetails formatDetails, Placeholder placeholder, object currentValue)
		{
		}

		public void ReleaseToPool()
		{
		}

		public void Write(string text)
		{
		}

		public void Write(string text, int startIndex, int length)
		{
		}

		public void Write(Format format, object value)
		{
		}

		public FormattingException FormattingException(string issue, FormatItem problemItem = null, int startIndex = -1)
		{
			return null;
		}

		private FormattingInfo CreateChild(Format format, object currentValue)
		{
			return null;
		}

		public FormattingInfo CreateChild(Placeholder placeholder)
		{
			return null;
		}
	}
}
