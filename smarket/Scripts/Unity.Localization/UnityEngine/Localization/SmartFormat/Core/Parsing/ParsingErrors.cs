using System;
using System.Collections.Generic;

namespace UnityEngine.Localization.SmartFormat.Core.Parsing
{
	public class ParsingErrors : Exception
	{
		public class ParsingIssue
		{
			public int Index { get; }

			public int Length { get; }

			public string Issue { get; }

			public ParsingIssue(string issue, int index, int length)
			{
			}
		}

		private Format result;

		public List<ParsingIssue> Issues { get; }

		public bool HasIssues => false;

		public string MessageShort => null;

		public override string Message => null;

		public void Init(Format result)
		{
		}

		public void Clear()
		{
		}

		public void AddIssue(string issue, int startIndex, int endIndex)
		{
		}
	}
}
